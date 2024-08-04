﻿using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.ContactResults;
using Aranoz.Application.Mediator.Results.MessageResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.ContactQueries
{
    public class GetContactQuery : IRequest<Response<List<GetContactQueryResult>>>
    {
    }
}
