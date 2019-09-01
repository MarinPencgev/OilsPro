using AutoMapper;
using OilsPro.Data.Models;
using OilsPro.Web.Models.ViewModels.Carrier;
using OilsPro.Web.Models.ViewModels.Order;
using OilsPro.Web.Models.ViewModels.Product;
using OilsPro.Web.Models.ViewModels.Receiver;

namespace OilsPro.Web
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