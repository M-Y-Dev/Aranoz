using Aranoz.Application.Mediator.Commands.AddressCommands;
using Aranoz.Application.Mediator.Commands.AppRoleCommands;
using Aranoz.Application.Mediator.Commands.AppUserCommands;
using Aranoz.Application.Mediator.Commands.BannerCommands;
using Aranoz.Application.Mediator.Commands.BasketCommands;
using Aranoz.Application.Mediator.Commands.BasketItemCommands;
using Aranoz.Application.Mediator.Commands.BlogCategoryCommands;
using Aranoz.Application.Mediator.Commands.BlogCommands;
using Aranoz.Application.Mediator.Commands.BrandCommands;
using Aranoz.Application.Mediator.Commands.CategoryCommands;
using Aranoz.Application.Mediator.Commands.CommentCommands;
using Aranoz.Application.Mediator.Commands.ContactCommands;
using Aranoz.Application.Mediator.Commands.MessageCommands;
using Aranoz.Application.Mediator.Commands.OrderCommands;
using Aranoz.Application.Mediator.Commands.ProductCommands;
using Aranoz.Application.Mediator.Commands.ProductDetailCommands;
using Aranoz.Application.Mediator.Results.AddressResults;
using Aranoz.Application.Mediator.Results.AppRoleResults;
using Aranoz.Application.Mediator.Results.AppUserResults;
using Aranoz.Application.Mediator.Results.BannerResults;
using Aranoz.Application.Mediator.Results.BasketItemResults;
using Aranoz.Application.Mediator.Results.BasketResults;
using Aranoz.Application.Mediator.Results.BlogCategoryResults;
using Aranoz.Application.Mediator.Results.BlogResults;
using Aranoz.Application.Mediator.Results.BrandResults;
using Aranoz.Application.Mediator.Results.CategoryResults;
using Aranoz.Application.Mediator.Results.CommentResults;
using Aranoz.Application.Mediator.Results.ContactResults;
using Aranoz.Application.Mediator.Results.MessageResults;
using Aranoz.Application.Mediator.Results.OrderResults;
using Aranoz.Application.Mediator.Results.ProductDetailResults;
using Aranoz.Application.Mediator.Results.ProductResults;
using Aranoz.Domain.Entity;
using AutoMapper;

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

            CreateMap<Order, CreateOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
            CreateMap<Order, GetOrderQueryResult>().ReverseMap();
            CreateMap<Order, GetOrderByIdQueryResult>().ReverseMap();

            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();


            CreateMap<Basket, CreateBasketCommand>().ReverseMap();
            CreateMap<Basket, UpdateBasketCommand>().ReverseMap();
            CreateMap<Basket, GetBasketByIdQueryResult>().ReverseMap();
            CreateMap<Basket, GetBasketQueryResult>().ReverseMap();

            CreateMap<BasketItem, CreateBasketItemCommand>().ReverseMap();
            CreateMap<BasketItem, UpdateBasketItemCommand>().ReverseMap();
            CreateMap<BasketItem, GetBasketItemByIdQueryResult>().ReverseMap();
            CreateMap<BasketItem, GetBasketItemQueryResult>().ReverseMap();

            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
            CreateMap<Brand, GetBrandByIdQueryResult>().ReverseMap();
            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();

            CreateMap<ProductDetail, CreateProductDetailCommand>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailCommand>().ReverseMap();
            CreateMap<ProductDetail, GetProductDetailByIdQueryResult>().ReverseMap();
            CreateMap<ProductDetail, GetProductDetailQueryResult>().ReverseMap();

            CreateMap<Banner, CreateBannerCommand>().ReverseMap();
            CreateMap<Banner, UpdateBannerCommand>().ReverseMap();
            CreateMap<Banner, GetBannerByIdQueryResult>().ReverseMap();
            CreateMap<Banner, GetBannerQueryResult>().ReverseMap();

            CreateMap<Blog, CreateBlogCommand>().ReverseMap();
            CreateMap<Blog, UpdateBlogCommand>().ReverseMap();
            CreateMap<Blog, GetBlogByIdQueryResult>().ReverseMap();
            CreateMap<Blog, GetBlogQueryResult>().ReverseMap();

            CreateMap<BlogCategory, CreateBlogCategoryCommand>().ReverseMap();
            CreateMap<BlogCategory, UpdateBlogCategoryCommand>().ReverseMap();
            CreateMap<BlogCategory, GetBlogCategoryByIdQueryResult>().ReverseMap();
            CreateMap<BlogCategory, GetBlogCategoryQueryResult>().ReverseMap();


        }
    }
}
