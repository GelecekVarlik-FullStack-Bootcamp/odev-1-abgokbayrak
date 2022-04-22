using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Dto
{
    public partial class DtoRegion
    {
        public DtoRegion()
        {
            
        }
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}
