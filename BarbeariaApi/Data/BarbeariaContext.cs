using System.Data;

namespace BarbeariaApi.Data;

public class BarbeariaContext
{
    public delegate Task<IDbConnection> GetConnection();
}
