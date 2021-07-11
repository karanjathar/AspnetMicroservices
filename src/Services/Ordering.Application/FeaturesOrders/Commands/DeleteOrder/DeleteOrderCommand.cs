using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Application.FeaturesOrders.Commands.DeleteOrder
{
    public class DeleteOrderCommand : IRequest
    {
        public int Id { get; set; }
    }
}
