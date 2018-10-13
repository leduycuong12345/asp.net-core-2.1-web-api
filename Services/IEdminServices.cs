using OnlineShoppingWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public interface IEdminServices
    {
        Edmin addEdmin(Edmin items);
        Dictionary<string, Edmin> getEdmin();
    }
}
