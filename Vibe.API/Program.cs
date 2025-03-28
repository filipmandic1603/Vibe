using System.Text.Json.Serialization;
using Vibe.API.Middlewares;
using Vibe.Core;
using Vibe.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddCore();

builder.Services.AddControllers().AddJsonOptions
    (options =>
    {
        options.JsonSerializerOptions.Converters.Add
        (new JsonStringEnumConverter());
    });


builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseExceptionHandlingMiddleware();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
