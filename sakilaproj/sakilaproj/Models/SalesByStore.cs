using System;
using System.Collections.Generic;

namespace sakilaproj.Models
{
    public partial class SalesByStore
    {
        public int StoreId { get; set; }
        public string Store { get; set; }
        public string Manager { get; set; }
        public decimal? TotalSales { get; set; }
    }
}
