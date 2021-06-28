using BabaFunke.DataAccess;
using BabaFunkeCustomer.Web.Data;
using BabaFunkeCustomer.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BabaFunkeCustomer.Web.Services
{
    public class CustomerService : SqlServerEfRepository<Customer>
    {
        public override async Task<IEnumerable<Customer>> GetAllItems()
        {
            var customers = DataManager.GetMockCustomers();
            return await Task.Run(() => customers);
        }
    }
}
