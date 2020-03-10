using O3BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApplication.IRepository
{
    public interface IFormRepository
    {
        Task<IEnumerable<User>> Get();
        Task<User> Get(string id);
        Task Add(User user);

    }
}
