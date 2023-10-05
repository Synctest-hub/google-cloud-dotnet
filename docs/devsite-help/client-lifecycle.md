# Client lifecycle

Note: much of this page is specific to the gRPC-based packages. The REST-based packages (Google.Cloud.Storage.V1,
Google.Cloud.BigQuery.V2 and Google.Cloud.Translation.V2) do have builders, but some of the properties
described below are not applicable. See the [clean-up page](cleanup.md) for more details about disposal of
REST clients.

Other than for some libraries with high-level manually-written API surfaces (such as Firestore and Spanner),
the "entry-points" into the Google Cloud Client Libraries for .NET are clients. Some packages
have multiple clients, others have only a single one; consult the reference documentation for the relevant package
(linked from the [GitHub repository](https://github.com/googleapis/google-cloud-dotnet) or
the [list of packages](https://cloud.google.com/dotnet/docs/reference)) to see the clients available for a particular
package. The rest of this page assumes a client class called `ExampleClient`.

## Creating a client

There are multiple ways of creating clients, depending on the nature of the application you're writing.
When integrating with ASP.NET Core, we recommend using dependency injection if possible.

Regardless of the application type, clients are thread-safe and we recommend creating a single client per service
unless you have specific requirements to use multiple instances (such as different credentials or endpoints per
client). Using a single client instance the entire application lifetime removes the need to worry about
cleaning up clients.

### Default initialization

The static `ExampleClient.Create()` method creates a new client using defaults for everything,
including the application default credentials.

### Explicitly using a builder

Every client has a corresponding builder class (e.g. `ExampleClientBuilder`) with `Build` and `BuildAsync`
methods.

The builder allows you to customize various aspects of the client, most notably credentials. For example,
if you load JSON containing the relevant credentials to use, you might construct a client with:

```csharp
var client = new ExampleClientBuilder
{
    JsonCredentials = json
}.Build();
```

For more details on what can be configured within a client, see the [client configuration documentation](client-configuration.md).

### Dependency injection (Microsoft.Extensions.DependencyInjection)

Every library includes an extension method for each client in the `Microsoft.Extensions.DependencyInjection` namespace,
targeting `IServiceCollection`. The name of the method is `Add` followed by the client class name. For example:

```csharp
public static IServiceCollection AddExampleClient(this IServiceCollection services, Action<ExampleClientBuilder> action = null)
```

This adds the client as a singleton, and returns the target service collection for the purposes of
method chaining. So for example, in an ASP.NET Core application you might write:

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddRazorPages()
    .AddExampleClient();
```

This will use other services provided by dependency injection when constructing the client. The following
types are requested from the service provider:

- `ILogger<ExampleClient>`
- `CallInvoker`
- `GrpcAdapter`
- `GrpcChannelOptions`
- `ChannelCredentials`
- `ICredential`
- `GoogleCredential`

If you need to configure the client builder more explicitly but still want to take advantage of
dependency injection, you can use the `Build(IServiceProvider)` or `BuildAsync(IServiceProvider)` methods
from the client builder.

For example, the `FirestoreDbBuilder` class allows a project ID to be specified, so you might configure this with:

```csharp
builder.Services
    .AddSingleton(provider => new FirestoreDbBuilder { ProjectId = "my-project-id" }.Build(provider));
```

Any properties explicitly set on the builder will not be requested from the service provider. For example,
if credentials are configured (in any form) on the builder, the `Build(IServiceProvider)` method will
not request `ChannelCredentials`, `ICredential` or `GoogleCredential`.

Additionally, in environments where Grpc.Net.Client will be used (e.g. .NET Core or .NET 5+) we recommend
adding the `GrpcNetClientAdapter` to the dependency injection services, which allows logging and `HttpClient`
construction to be configured in a consistent manner. For example:

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddRazorPages()
    .AddGrpcNetClientAdapter()
    .AddExampleClient();
```

#### Dependency injection in high-load-at-startup environments.

If your application uses Application Default Credentials while running in a Google runtime (Compute Engine,
GKE, Cloud Functions, etc.) and you expect high request load on application startup you may run into a known
issue that leads to thread starvation and high response latency. We are looking into a permanent fix,
but in the meantime you can use the following workaround: make certain you request Application
Default Credentials **during** startup configuration (you don't have to use them). For example:

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddRazorPages()
    .AddExampleClient();
// Workaround for possible thread starvation scenario.
GoogleCredential.GetApplicationDefaultCredential();
```

Note that on runtimes where high request loads lead to scaling up, the newly spawned environments are likely to
have high request load on startup which leads to this issue manifesting.

Please see https://github.com/googleapis/google-cloud-dotnet/issues/11092 for fresh updates.

## Clean-up

When a single client is used for an entire application lifecycle, there is no need to clean anything up.

When multiple clients are used but with the default application credentials and the default endpoint,
a *channel pool* is used so all clients use the same network connection. This means no clean-up is necessary.

When multiple clients are constructed in a customized way, each client requires its own network connection.
While these will eventually be garbage collected, if your application executes in a constrained environment,
you may wish to dispose of the channel directly.

The client builder exposes a `LastCreatedChannel` property, which returns a `ChannelBase` if the most recent
`Build` or `BuildAsync` call required the creation of a non-pooled channel, or null otherwise.
Different `ChannelBase` implementations have different cleanup implementations, but the `Shutdown` extension
method (in the `Google.Api.Gax.Grpc` namespace) will shut a channel down either synchronously or asynchronously
depending on the implementation.

In an ideal world, the clients themselves would implement `IDisposable` and "just do the right thing"; we expect
to improve this aspect of the libraries in a future major version.
