using Dapper;
using PracticaCalificada1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PracticaCalificada1.Repositories.SalesDB.Dapper
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        public CustomerRepository(string connectionString): base(connectionString)
        {

        }

        public IEnumerable<Customer> SearchByFirstName(string FirstName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@firstName", FirstName);

                return connection.Query<Customer>("dbo.CustomerSearchByFirstName", 
                    parameters, 
                    commandType: System.Data.CommandType.StoredProcedure);

            }
        }
    }
}
