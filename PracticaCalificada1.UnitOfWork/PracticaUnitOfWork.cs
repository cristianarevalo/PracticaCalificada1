using PracticaCalificada1.Repositories.SalesDB;
using PracticaCalificada1.Repositories.SalesDB.Dapper;

namespace PracticaCalificada1.UnitOfWork
{
    public class PracticaUnitOfWork: IUnitOfWork
    {
        public PracticaUnitOfWork(string connectionString)
        {
            Customers = new CustomerRepository(connectionString);
            Products = new ProductRepository(connectionString);
            Sales = new SaleRepository(connectionString);
            Employees = new EmployeeRepository(connectionString);
        }

        public ICustomerRepository Customers { get; private set; }
        public IProductRepository Products { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public ISaleRepository Sales { get; private set; }
    }
}
