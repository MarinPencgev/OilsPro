using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OilsPro.Data.Models;
using OilsPro.Web.Models.ViewModels;

namespace Oils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Receiver, EditReceiverViewModel>();
            CreateMap<EditReceiverViewModel, Receiver>();

            CreateMap<Order, CreateOrderViewModel>();

            CreateMap<EditCarrierViewModel, Carrier>();
            CreateMap<Carrier, EditCarrierViewModel>();

            CreateMap<EditProductViewModel, Product>();
            CreateMap<Product, EditProductViewModel>();
        }
    }
}