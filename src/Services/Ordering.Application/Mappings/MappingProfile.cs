using AutoMapper;
using Ordering.Application.FeaturesOrders.Commands.CheckoutOrder;
using Ordering.Application.FeaturesOrders.Commands.UpdateOrder;
using Ordering.Application.FeaturesOrders.QueriesGetOrderList;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
