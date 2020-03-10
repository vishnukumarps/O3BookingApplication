using Maintenance.DbModels;
using Maintenance.IRepository;
using Microsoft.Extensions.Options;
using O3BookingApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Maintenance.Repository
{
    public class ServiceRepository:IServiceRepository
    {
        private readonly ObjectContext _context = null;
        public ServiceRepository(IOptions<Settings> settings)
        {
            _context = new ObjectContext(settings);
        }

      

        Task<IEnumerable<Service>> IServiceRepository.Get()
        {
            throw new NotImplementedException();
        }

        Task<Service> IServiceRepository.Get(string id)
        {
            throw new NotImplementedException();
        }

      
        public async Task Add(Service service)
        {

        }
    }
}
