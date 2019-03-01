﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataObjects
{
    public class VMItemSupplierItem :  Product
    {
        public int ItemID { get; set; }
        public int SupplierID { get; set; }

        public bool PrimarySupplier { get; set; }

        public int LeadTimeDays { get; set; }

        public decimal UnitPrice { get; set; }
        public bool ItemSupplierActive { get; set; }

    }
}