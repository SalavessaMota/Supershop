using System.Linq;
using System.Threading.Tasks;
using Supershop.Data.Entities;
using Supershop.Models;


namespace Supershop.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrdersAsync(string userName);


        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);


        Task AddItemToOrderAsync(AddItemViewModel model, string userName);


        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);
    }
}
