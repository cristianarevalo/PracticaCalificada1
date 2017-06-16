using Dapper;
using PracticaCalificada1.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PracticaCalificada1.Repositories.SalesDB.Dapper
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(string connectionString): base(connectionString)
        {

        }

        public IEnumerable<Employee> SearchByLastName(string LastName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@lastName", LastName);

                return connection.Query<Employee>("dbo.EmployeeSearchByLastName", 
                    parameters, 
                    commandType: System.Data.CommandType.StoredProcedure);

            }
        }
    }
}
