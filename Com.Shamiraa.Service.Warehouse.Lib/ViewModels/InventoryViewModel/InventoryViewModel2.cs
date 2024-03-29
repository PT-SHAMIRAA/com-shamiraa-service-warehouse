﻿using Com.Shamiraa.Service.Warehouse.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Shamiraa.Service.Warehouse.Lib.ViewModels.InventoryViewModel
{
    public class InventoryViewModel2 : BaseViewModel
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string StorageCode { get; set; }
        public string StorageName { get; set; }
        public string City { get; set; }
        public double Quantity { get; set; }
        public DateTimeOffset LatestDate { get; set; }
    }
}
