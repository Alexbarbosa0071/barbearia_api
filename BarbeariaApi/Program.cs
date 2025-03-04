using BarbeariaApi.Endpoints;
using BarbeariaApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddCollectionExtensions();
var app = builder.Build();

app.MapClienteEndpoints();

app.Run();
