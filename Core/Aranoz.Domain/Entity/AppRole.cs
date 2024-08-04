using Aranoz.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class AppRole:BaseEntity 
    { 
        public string RoleName { get; set; }     
        public List<AppUser> AppUsers { get; set; }
    }
}
