using System.Runtime.CompilerServices;

namespace BarbeariaApi.Endpoints;

public static class ClienteEndpoints
{
    public static void MapClienteEndpoints(this WebApplication app)
    {

        app.MapGet("/buscar-cliente", () =>
        {
            var res = new
            {
                nome = "Alex"
            };

            return Results.Ok(res);
        });

        app.MapGet("/buscar-cliente/{Id}", (string Id) =>
        {
            var res = new
            {
                nome = "Alex",
                Id
            };

            return Results.Ok(res);
        });
    }
}
