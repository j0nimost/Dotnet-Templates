using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.Repositories
{
    public interface IWrapper
    {
        // Add individual repository
        // Example: IRepository<Customers> CustomerRepo {get;} 

        Task SaveAsync();
    }
}
