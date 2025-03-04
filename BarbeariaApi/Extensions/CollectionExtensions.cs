using Microsoft.Data.SqlClient;
using static BarbeariaApi.Data.BarbeariaContext;

namespace BarbeariaApi.Extensions;

public static class CollectionExtensions
{
    public static WebApplicationBuilder AddCollectionExtensions(this WebApplicationBuilder builder)
    {
        var connectionString = "data source=vm-dev\\SQLEXPRESS;initial catalog=Barbearia;user id=alexprojeto;password=alexprojeto123;TrustServerCertificate=true";

        IServiceCollection serviceCollection = builder.Services.AddScoped<GetConnection>(sp =>
        async () =>
        {
            var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            return connection;

        });
        return builder;
    }
}
