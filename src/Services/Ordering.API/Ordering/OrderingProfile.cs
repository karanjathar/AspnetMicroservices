using AutoMapper;
using Ordering.Application.FeaturesOrders.Commands.CheckoutOrder;
using Ordering.Infrastructure.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API.Ordering
{
	public class OrderingProfile : Profile
	{
		public OrderingProfile()
		{
			CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
		}
	}
}
