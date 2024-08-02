using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Results.AddressResults
{
    public class GetAddressByIdQueryResult
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AddressDetail { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
