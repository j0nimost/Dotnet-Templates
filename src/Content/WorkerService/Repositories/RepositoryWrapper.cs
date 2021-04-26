using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.Repositories
{
    public class RepositoryWrapper : IWrapper
    {
        // Implement IWrapper
        // Add private fields
        // Example: private Repository<Customers> _CustomerRepo;

        public RepositoryWrapper()
        {
            // Initialize all the contexts as needed
        }

        // Implement Repository Wrapper
        // Example: 
        // public IRepository<Customers> ClaimsRepo
        // {
        //    get
        //    {
        //        if (_CustomerRepo == null)
        //        {
        //            _CustomerRepo = new Repository<Customers>(this.context);
        //        }
        //        return _CustomerRepo;
        //    }
        // }

        public Task SaveAsync()
        {
            // Implement -> await context.SaveChangesAsync();
            throw new NotImplementedException();
        }
    }
}
