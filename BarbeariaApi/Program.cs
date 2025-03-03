using BarbeariaApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapClienteEndpoints();

app.Run();
