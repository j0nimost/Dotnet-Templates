using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public interface IWrapper
    {
        // Add individual repository
        // Example: IRepository<Customers> CustomerRepo {get;} 

        Task SaveAsync();
    }
}
