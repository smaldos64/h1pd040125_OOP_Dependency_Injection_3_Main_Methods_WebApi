using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;
using Dependency_Injection_3_Main_Methods_WebApi.Classes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<IRequestTransientService, RequestTransientService>();
builder.Services.AddScoped<IRequestScopedService, RequestScopedService>();
builder.Services.AddSingleton<IRequestSingletonService, RequestSingletonService>();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c => {  // LTPE
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger(); // LTPE
app.UseSwaggerUI();  // LTPE

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

