using BabaFunke.DataAccess;
using BabaFunkeCustomer.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabaFunkeCustomer.Web.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> _customerService;

        public CustomerController(IRepository<Customer> customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("api/customer")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _customerService.GetAllItems();
            return Ok(customers);
        }

    }
}
