# logging-typed-tests

Testing the principle on the article: [High-performance logging with LoggerMessage in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/loggermessage?view=aspnetcore-2.0)

## Results

* n=100
    * elapsedMsMethod1: 102
    * elapsedMsMethod2: 126

* n=10000
    * elapsedMsMethod1: 8590
    * elapsedMsMethod2: 841

* n=50000
    * elapsedMsMethod1: 13728
    * elapsedMsMethod2: 4724