using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sakilaproj.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Payment = new HashSet<Payment>();
            Rental = new HashSet<Rental>();
        }

        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z]*")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z]*")]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int AddressId { get; set; }
        public string Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Rental> Rental { get; set; }
    }
}
