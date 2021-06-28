using BabaFunkeReportManager.Interfaces;
using BabaFunkeReportManager.Models;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(BabaFunkeReportManager.Startup))]
namespace BabaFunkeReportManager
{
    public class ReportManagerJob
    {
        private readonly ICustomerService<Customer> _customerService;
        private readonly IEmailService<Customer> _emailService;

        public ReportManagerJob(ICustomerService<Customer> customerService, IEmailService<Customer> emailService)
        {
            _customerService = customerService;
            _emailService = emailService;
        }

        /// <summary>
        /// The TimerTrigger that's run on schedule. Adjust the property to run based on your preference.
        /// This [TimerTrigger("0 00 16 * * *")] runs once daily at exactly 4 PM
        /// To run every minute, use [TimerTrigger("0 */1 * * * *")]
        /// To run at 5 AM daily, use [TimerTrigger("0 0 5 * * *")]
        /// </summary>
        /// <returns></returns>
        [FunctionName("ReportManagerJob")]
        public async Task Run([TimerTrigger("0 00 16 * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var customers = await _customerService.GetNewCustomers();
            await _emailService.SendEmail(customers.ToList());
        }
    }
}
