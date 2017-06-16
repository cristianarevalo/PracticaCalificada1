using PracticaCalificada1.Models;

namespace PracticaCalificada1.Repositories.SalesDB.Dapper
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(string connectionString): base(connectionString)
        {

        }

        
    }
}
