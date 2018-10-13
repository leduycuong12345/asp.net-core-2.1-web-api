using OnlineShoppingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public class EdminServices :IEdminServices
    {
        private readonly Dictionary<string, Edmin> _edmin;
        public EdminServices()
        {
            _edmin = new Dictionary<string, Edmin>();
        }

        public Edmin addEdmin(Edmin items)
        {
            _edmin.Add(items.edminName,items);
            return items;
        }

        public Dictionary<string, Edmin> getEdmin()
        {
            return _edmin;
        }
    }
}
