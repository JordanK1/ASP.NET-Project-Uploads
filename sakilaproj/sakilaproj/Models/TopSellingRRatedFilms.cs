using System;
using System.Collections.Generic;

namespace sakilaproj.Models
{
    public partial class TopSellingRRatedFilms
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public short? Length { get; set; }
        public decimal? RentalSales { get; set; }
    }
}
