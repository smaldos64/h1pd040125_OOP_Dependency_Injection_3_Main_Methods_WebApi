# Dependency_Injection_3_Main_Methods_WebApi

Dette projekt er lavet for på en nem måde at illustrere forskellen mellem de 3 forskellige måder at lave Dependency Injection af et Interface i et C# WebApi projekts Controller klasse Constructor. 

De 3 forskellige måder er :

1) services.AddTransient<TInterface, TImplementation>()
   Description: Creates a new instance of the implementation (TImplementation) every time the interface (TInterface) is requested
   Use Cases: Ideal for lightweight, stateless services. Use it when you need a fresh instance for each request, such as database contexts or short-lived operations.
   
2) services.AddScoped<TInterface, TImplementation>()
   Description: Creates a new instance once per HTTP request (or "scope"). The same instance is reused within that request.
   Use Cases: Best for services that need to maintain state during a single request, such as database transactions or user-specific data
   
3) services.AddSingleton<TInterface, TImplementation>()
   Description: Creates a single instance of the implementation that is shared across the entire application's lifetime.
   Use Cases: Suitable for services that are stateless and thread-safe, such as configuration readers, loggers, or caching services.

Lige en detalje. For at kunne anvende Swagger i et Asp.Net 9 Web Api projekt, skal man lige gå ind i \Properties\LaunchSettings.json filen og indsætte en linje i denne fil. Denne linje er:
"launchUrl": "swagger",
Desuden skal man ændre linjen:
"launchBrowser": false, 
til:
"launchBrowser": true,
