using BabaFunkeReportManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BabaFunkeReportManager.Extensions
{
    public static class DataFilter
    {
        public static List<Customer> GetFilteredList(this IEnumerable<Customer> items)
        {
            var yesterday = DateTime.Now.AddDays(-1);
            var selectedCustomers = items.Where(c => c.DateRegistered.Date == yesterday.Date);
            return selectedCustomers.ToList();
        }
    }
}
