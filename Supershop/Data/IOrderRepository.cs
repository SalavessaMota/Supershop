﻿using Supershop.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Supershop.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrdersAsync(string userName);


        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);
    }
}
