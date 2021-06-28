using BabaFunkeCustomer.Web.Models;
using System;
using System.Collections.Generic;

namespace BabaFunkeCustomer.Web.Data
{
    public static class DataManager
    {
        /// <summary>
        /// A mock of customer data. In a real world application, this list would come from a database.
        /// In my real application, the data comes from my database of customers
        /// The data is then filtered to only report recent customers in the last 24 hours
        /// </summary>
        /// <returns></returns>
        public static List<Customer> GetMockCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Oprah Winfrey", Email = "johndoe@example.com", DateRegistered = DateTime.Now.AddDays(-1)},
                new Customer {Id = 2, Name = "Lupita Nyongo", Email = "lupitan@example.com", DateRegistered = DateTime.Now.AddDays(-1)},
                new Customer {Id = 3, Name = "Denzel Washington", Email = "denzelw@example.com", DateRegistered = DateTime.Now.AddDays(-1)},
                new Customer {Id = 4, Name = "Lewis Hamilton", Email = "lewish@example.com", DateRegistered = new DateTime(2021, 05, 27)},
                new Customer {Id = 5, Name = "John Doe", Email = "johndoe@example.com", DateRegistered = new DateTime(2021, 06, 5)}
            };
        }
    }
}
