using BarbeariaApi.Endpoints;
using BarbeariaApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddCollectionExtensions();

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "AllowOrigin",
        builder => {
            builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
        });
});
var app = builder.Build();
app.UseCors("AllowOrigin");

app.MapClienteEndpoints();

app.Run();
