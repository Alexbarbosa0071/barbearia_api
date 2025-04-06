using System.Data;
using System.Runtime.CompilerServices;
using BarbeariaApi.Data;
using BarbeariaApi.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using static BarbeariaApi.Data.BarbeariaContext;

namespace BarbeariaApi.Endpoints;

public static class ClienteEndpoints
{
    public static void MapClienteEndpoints(this WebApplication app)
    {

        app.MapGet("/buscar-clientes", async (GetConnection connectionGetter) =>
        {
            using var conDb = await connectionGetter();
            var dataClient = conDb.QueryMultiple("Obter_Clientes", commandType: CommandType.StoredProcedure).Read<Cliente>();

            var res = new
            {
                clientes = dataClient
            };

            return Results.Ok(res);
        });

        app.MapGet("/criar-cliente", async ([FromBody] ClienteModel cliente, GetConnection connectionGetter) =>
        {
            using var conDb = await connectionGetter();
            var dataClient = conDb.QuerySingleOrDefault<Cliente>("Criar_Cliente", cliente, commandType: CommandType.StoredProcedure);

            var res = new
            {
                cliente = dataClient
            };

            return Results.Ok(res);
        });

        app.MapGet("/buscar-cliente/{Id}", async (string Id, GetConnection connectionGetter) =>
        {
            using var conDb = await connectionGetter();
            var dataClient = conDb.QuerySingleOrDefault<Cliente>("Obter_Clientes_Por_Id", new { Id }, commandType: CommandType.StoredProcedure);

            var res = new
            {
                cliente = dataClient
            };

            return Results.Ok(res);
        });

        app.MapDelete("/excluir-cliente/{idCliente}", async (int idCliente, GetConnection connectionGetter) =>
        {
            using var conDb = await connectionGetter();
            var dataClient = conDb.QuerySingleOrDefault<DeletarCliente>("Delete_Cliente", new { IdCliente = idCliente }, commandType: CommandType.StoredProcedure);

            var res = dataClient;
            return Results.Ok(res);
        });
    }


}
