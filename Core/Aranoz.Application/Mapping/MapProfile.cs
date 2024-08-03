using Aranoz.Application.Mediator.Commands.MessageCommands;
using Aranoz.Application.Mediator.Commands.CommentCommands;
using Aranoz.Application.Mediator.Results.MessageResults;
using Aranoz.Application.Mediator.Results.CommentResults;
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
using Aranoz.Application.Mediator.Commands.CategoryCommands;
using Aranoz.Application.Mediator.Results.CategoryResults;

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

            CreateMap<Message, CreateMessageCommand>().ReverseMap();
            CreateMap<Message, UpdateMessageCommand>().ReverseMap();
            CreateMap<Message, GetMessageByIdQueryResult>().ReverseMap();
            CreateMap<Message, GetMessageQueryResult>().ReverseMap();

            CreateMap<Comment, CreateCommentCommand>().ReverseMap();
            CreateMap<Comment, UpdateCommentCommand>().ReverseMap();
            CreateMap<Comment, GetCommentByIdQueryResult>().ReverseMap();
            CreateMap<Comment, GetCommentQueryResult>().ReverseMap();

            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, UpdateContactCommand>().ReverseMap();
            CreateMap<Contact, GetContactByIdQueryResult>().ReverseMap();
            CreateMap<Contact, GetContactQueryResult>().ReverseMap();

            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();


        }
    }
}
