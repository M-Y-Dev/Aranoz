﻿using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.ProductCommands
{
    public class UpdateProductCommand : IRequest<Response<object>>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public int ProductStock { get; set; }
        public decimal Price { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryID { get; set; }
    }
}
