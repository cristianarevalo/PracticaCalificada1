using PracticaCalificada1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCalificada1.Repositories.SalesDB
{
    public interface IEmployeeRepository: IRepository<Employee>
    {
        IEnumerable<Employee> SearchByLastName(string LastName);
    }
}
