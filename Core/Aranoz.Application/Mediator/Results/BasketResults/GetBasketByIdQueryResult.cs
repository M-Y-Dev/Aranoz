﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Results.BasketResults
{
    public class GetBasketByIdQueryResult
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
