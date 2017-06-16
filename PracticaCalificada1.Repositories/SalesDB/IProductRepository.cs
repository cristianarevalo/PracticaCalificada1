using PracticaCalificada1.Models;

namespace PracticaCalificada1.Repositories.SalesDB
{
    public interface IProductRepository: IRepository<Product>
    {
        Product SearchByName(string Name);
    }
}
