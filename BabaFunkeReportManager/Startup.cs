using BabaFunkeReportManager.Interfaces;
using BabaFunkeReportManager.Models;
using BabaFunkeReportManager.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace BabaFunkeReportManager
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();
            builder.Services.AddScoped<ICustomerService<Customer>, CustomerService>();
            builder.Services.AddScoped<IFileService<Customer>, FileService>();
            builder.Services.AddScoped<IEmailService<Customer>, EmailService>();
            builder.Services
                .AddFluentEmail("babafunke@babafunke.com") //Enter the Sender's Email 
                .AddSendGridSender("**************"); //Enter your SendGrid Api Key
        }
    }
}
