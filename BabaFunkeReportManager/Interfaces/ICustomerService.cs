using System.Collections.Generic;
using System.Threading.Tasks;

namespace BabaFunkeReportManager.Interfaces
{
    public interface ICustomerService<T>
    {
        Task<IEnumerable<T>> GetNewCustomers();
    }
}
