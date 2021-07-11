using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Application.FeaturesOrders.QueriesGetOrderList
{
    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public string UserName { get; set; }

        public GetOrdersListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
