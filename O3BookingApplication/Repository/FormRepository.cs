using Maintenance.DbModels;
using Microsoft.Extensions.Options;
using O3BookingApplication.IRepository;
using O3BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApplication.Repository
{
    public class FormRepository:IFormRepository
    {
        private readonly ObjectContext _context = null;
        public FormRepository(IOptions<Settings> settings)
        {
            _context = new ObjectContext(settings);
        }

        Task IFormRepository.Add(User user)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<User>> IFormRepository.Get()
        {
            throw new NotImplementedException();
        }

        Task<User> IFormRepository.Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
