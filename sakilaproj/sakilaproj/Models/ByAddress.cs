using System;
using System.Collections.Generic;

namespace sakilaproj.Models
{
    public partial class ByAddress
    {
        public int AddressId { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
    }
}
