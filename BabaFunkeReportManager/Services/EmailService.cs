using BabaFunkeReportManager.Data;
using BabaFunkeReportManager.Interfaces;
using BabaFunkeReportManager.Models;
using FluentEmail.Core;
using FluentEmail.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BabaFunkeReportManager.Services
{
    /// <summary>
    /// Handles the actual sending of the email
    /// </summary>
    public class EmailService : IEmailService<Customer>
    {
        private readonly IFileService<Customer> _fileService;
        private readonly IFluentEmail _fluentEmail;

        public EmailService(IFileService<Customer> fileService, IFluentEmail fluentEmail)
        {
            _fileService = fileService;
            _fluentEmail = fluentEmail;
        }

        public async Task SendEmail(List<Customer> customers)
        {
            Stream csvFile = null;
            try
            {
                csvFile = await _fileService.GenerateCsvFile(customers);

                //Attach the CSV file stream
                var attachment = new Attachment
                {
                    Data = csvFile,
                    ContentType = "text/csv",
                    Filename = $"CustomerReport_{DateTime.Now}.csv"
                };

                //Generate a list of recipients to send to.
                var emailList = MockData.GetEmailRecipients();
                var recipients = new List<Address>();
                recipients = emailList.Select(e => new Address
                {
                    EmailAddress = e
                }).ToList();

                //Send the email
                var email = await _fluentEmail
                    .To(recipients) //Or use To("example@example.com") if sending to one email
                    .Subject($"Registered Customers Report for {DateTime.Now}")
                    .Body("See attached the list of registered customers.")
                    .Attach(attachment)
                    .SendAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                csvFile.Dispose();
            }
        }
    }
}
