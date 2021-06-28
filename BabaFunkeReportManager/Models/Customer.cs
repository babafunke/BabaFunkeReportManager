using System;

namespace BabaFunkeReportManager.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
