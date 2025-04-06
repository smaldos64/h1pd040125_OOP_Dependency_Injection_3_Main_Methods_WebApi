using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;
using Dependency_Injection_3_Main_Methods_WebApi.Classes;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

//builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<IRequestTransientService, RequestTransientService>();

builder.Services.AddControllers();

//builder.Services.AddCors(options =>  // LTPE
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//        builder => builder.AllowAnyOrigin()
//        .AllowAnyMethod()
//        .AllowAnyHeader()
//        .SetIsOriginAllowed((host) => true));
//});

//builder.Services.AddEndpointsApiExplorer();

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

//app.UseCors(MyAllowSpecificOrigins); // LTPE

app.UseAuthorization();

app.MapControllers();

app.Run();

