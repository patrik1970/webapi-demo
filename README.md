#WebAPI .NET Core 5 with OpenAPI and NSwag

I have done this WebAPI by watching this tutorial [https://www.youtube.com/watch?v=nY-w9wPFEuY](https://www.youtube.com/watch?v=nY-w9wPFEuY)

## Software requirements

Visual Studios 2019 updated to version 16.8 and updated to .NET Core 5

##This demo project contains 

Project name: WebAPI
Contains:
```
ASP.NET Core web Application
ASP.NET Core Web API
ASP.NET Core 5.0
No Authentication
Configure for HTTPS
Enable OpenAPI support

```

Project name: ConsoleDemo
Contains:
```
Console App (.NET Core)
```
## Good to know

The ConsoleDemo shall simulate a client.
In the tutorial you can learn how to connect a Blazor App to the WebAPI
To start this in the right way you must go to the main project an right click on that and click on Set startup projects. Get down to multiple startup projects and set OurDemoApi to action Start and place it first on the list. Then set ConsoleDemo to action Start without debugging an place it as second on the list. Click OK and start the solution.
