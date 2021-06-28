using BabaFunkeReportManager.Extensions;
using BabaFunkeReportManager.Interfaces;
using BabaFunkeReportManager.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BabaFunkeReportManager.Services
{
    /// <summary>
    /// Handles the request and response to/from the Api to retrieve customer data
    /// </summary>
    public class CustomerService : ICustomerService<Customer>
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly string apiUrl = "https://localhost:44312/api/customer";

        public CustomerService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Gets a list of customers and returns the ones registered yesterday
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Customer>> GetNewCustomers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
            var client = _httpClient.CreateClient();
            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();
            var customers = JsonConvert.DeserializeObject<List<Customer>>(content);
            var recentCustomers = customers.GetFilteredList();
            return recentCustomers;
        }
    }
}
