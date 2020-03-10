
using O3BookingApp.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maintenance.IRepository
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>> Get();
        Task<Service> Get(string id);
        Task Add(Service service);

    }
}
