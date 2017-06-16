using Dapper;
using PracticaCalificada1.Models;
using System.Data.SqlClient;

namespace PracticaCalificada1.Repositories.SalesDB.Dapper
{

    public class ProductRepository : Repository<Product>, IProductRepository
    {

        public ProductRepository(string connectionString) : base(connectionString)
        {

        }

        public Product SearchByName(string Name)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@name", Name);

                return connection.QueryFirst<Product>("dbo.ProductSearchByName",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

            }
        }
    }
}
