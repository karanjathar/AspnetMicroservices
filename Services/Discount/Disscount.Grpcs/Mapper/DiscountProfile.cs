using AutoMapper;
using Disscount.Grpcs.Entities;
using Disscount.Grpcs.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Disscount.Grpcs.Mapper
{
    public class DiscountProfile: Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
