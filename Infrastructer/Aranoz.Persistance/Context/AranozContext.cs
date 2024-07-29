using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aranoz.Persistance.Context
{
    public class AranozContext:DbContext
    {
        public AranozContext(DbContextOptions<AranozContext> context):base(context)
        {
            
        }
    }
}
