using Aranoz.Application.Base;
using Aranoz.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.ProductDetailCommands
{
    public class CreateProductDetailCommand : IRequest<Response<object>>
    {
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Rating { get; set; }
    }
}
