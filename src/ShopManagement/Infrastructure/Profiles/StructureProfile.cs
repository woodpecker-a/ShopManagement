using AutoMapper;
using EO = Infrastructure.Entities;
using Infrastructure.BusinessObjects;

namespace Infrastructure.Profiles
{
    public class StructureProfile : Profile
    {
        public StructureProfile()
        {
            CreateMap<EO.Brand, Brand>()
                .ReverseMap();

            CreateMap<EO.Catagory, Catagory>()
                .ReverseMap();

            CreateMap<EO.Color, Color>()
                .ReverseMap();

            CreateMap<EO.Customer, Customer>()
                .ReverseMap();

            CreateMap<EO.Model, Model>()
                .ReverseMap();

            CreateMap<EO.Pricing, Pricing>()
                .ReverseMap();

            CreateMap<EO.Product, Product>()
                .ReverseMap();

            CreateMap<EO.ProductDetail, ProductDetail>()
                .ReverseMap();

            CreateMap<EO.ProductWarehouse, ProductWarehouse>()
                .ReverseMap();

            CreateMap<EO.PurchaseHistory, PurchaseHistory>()
                .ReverseMap();

            CreateMap<EO.Shopkeeper, Shopkeeper>()
                .ReverseMap();

            CreateMap<EO.Size, Size>()
                .ReverseMap();

            CreateMap<EO.Unit, Unit>()
                .ReverseMap();

            CreateMap<EO.Varient, Varient>()
                .ReverseMap();

            CreateMap<EO.WareHouse, WareHouse>()
                .ReverseMap();
        }
    }
}
