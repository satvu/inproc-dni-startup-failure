# Azure Functions in-proc .NET6 Startup Failure

- Used to investigate [startup failures](https://github.com/Azure/azure-functions-host/issues/8025) with .NET6 isolated. This is an in-proc app that lets us observe the difference in behavior of in-proc and isolated in surfacing the [startup error from the scneario in this comment](https://github.com/Azure/azure-functions-dotnet-worker/issues/747#issuecomment-989926373).
- The host fails to start up as soon as the app is deployed with the message `System.Private.CoreLib: The configuration file 'secrets.json' was not found and is not optional. The expected physical path was 'C:\Program Files (x86)\SiteExtensions\Functions\4.1.3\32bit\secrets.json'.`
  - Note: The isolated app still starts up even with identical `Startup.cs` code to the in-proc app.
