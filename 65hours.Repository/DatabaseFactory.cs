using _65hours.Repository.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65hours.Repository
{
    public class DatabaseFactory : IDisposable, IDatabaseFactory
    {
        private ApplicationDbContext dataContext;
        public ApplicationDbContext Get()
        {
            return dataContext ?? (dataContext = new ApplicationDbContext());
        }

        public void Dispose()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
