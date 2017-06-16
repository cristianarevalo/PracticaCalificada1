using PracticaCalificada1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCalificada1.Repositories.SalesDB
{
    public interface IProductRepository: IRepository<Product>
    {
        Product SearchByName(string Name);
    }
}
