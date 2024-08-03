using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.AddressCommands
{
    public class CreateAddressCommand : IRequest<Response<object>>
    {
     
        public string Country { get; set; }
        public string City { get; set; }
        public string AddressDetail { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get => DateTime.Now; }
    }
}
