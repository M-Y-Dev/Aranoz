using Aranoz.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
    }
}
