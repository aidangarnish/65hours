using _65hours.Domain.AbstractRepository;
using _65hours.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65hours.Repository.EFRepository
{
    public class EFUserRequestRepository : RepositoryBase<UserRequest>, IUserRequestRepository
    {
        public EFUserRequestRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {}
    }
}
