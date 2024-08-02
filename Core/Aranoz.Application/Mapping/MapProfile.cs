using Aranoz.Application.Mediator.Commands.ProductCommands;
using Aranoz.Application.Mediator.Results.ProductResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aranoz.Application.Mediator.Commands.ProductCommands;
using Aranoz.Application.Mediator.Results.ProductResults;
using Aranoz.Application.Mediator.Commands.ContactCommands;
using Aranoz.Application.Mediator.Results.ContactResults;
using Aranoz.Application.Mediator.Commands.OrderCommands;
using Aranoz.Application.Mediator.Results.OrderResults;
using Aranoz.Application.Mediator.Commands.CategoryCommands;
using Aranoz.Application.Mediator.Results.CategoryResults;
using Aranoz.Application.Mediator.Commands.BasketCommands;
using Aranoz.Application.Mediator.Results.BasketResults;

namespace Aranoz.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdQueryResult>().ReverseMap();
            CreateMap<Product, GetProductQueryResult>().ReverseMap();

            CreateMap<Address, CreateAddressCommand>().ReverseMap();
            CreateMap<Address, UpdateAddressCommand>().ReverseMap();
            CreateMap<Address, GetAddressByIdQueryResult>().ReverseMap();
            CreateMap<Address, GetAddressQueryResult>().ReverseMap();
        }
    }
}
