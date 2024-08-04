using Aranoz.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class Address:BaseEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string AddressDetail { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
    }
}
