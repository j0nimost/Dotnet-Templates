using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public class RepoWrapper : IWrapper
    {
        // Implement IWrapper
        // Add private fields
        // Example: private Repository<Customers> _CustomerRepo;

        public RepoWrapper()
        {
            // Initialize all the database contexts as needed
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
