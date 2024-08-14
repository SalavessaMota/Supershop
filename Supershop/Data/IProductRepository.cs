using Supershop.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Supershop.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();


        IEnumerable<SelectListItem> GetComboProducts();
    }
}
