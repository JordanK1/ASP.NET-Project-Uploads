using System;
using System.Collections.Generic;

namespace sakilaproj.Models
{
    public partial class Customer2
    {
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public byte[] Crcard { get; set; }
    }
}
