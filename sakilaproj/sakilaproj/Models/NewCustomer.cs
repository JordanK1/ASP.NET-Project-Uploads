using System;
using System.Collections.Generic;

namespace sakilaproj.Models
{
    public partial class NewCustomer
    {
        public int NewCustomId { get; set; }
        public string Name { get; set; }
        public int? CodeNum { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
