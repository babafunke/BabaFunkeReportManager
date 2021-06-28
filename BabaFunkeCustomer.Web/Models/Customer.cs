using BabaFunke.DataAccess;
using System;

namespace BabaFunkeCustomer.Web.Models
{
    public class Customer:IPrimaryKey
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
