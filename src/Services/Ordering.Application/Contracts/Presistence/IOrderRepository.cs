using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Presistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {

        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
