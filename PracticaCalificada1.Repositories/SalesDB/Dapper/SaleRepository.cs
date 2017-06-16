using PracticaCalificada1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCalificada1.Repositories.SalesDB.Dapper
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(string connectionString): base(connectionString)
        {

        }

        
    }
}
