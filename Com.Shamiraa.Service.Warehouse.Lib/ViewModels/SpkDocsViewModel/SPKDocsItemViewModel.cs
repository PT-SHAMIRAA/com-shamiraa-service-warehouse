﻿using Com.Shamiraa.Service.Warehouse.Lib.Utilities;
using Com.Shamiraa.Service.Warehouse.Lib.ViewModels.NewIntegrationViewModel;
using System.ComponentModel.DataAnnotations;

namespace Com.Shamiraa.Service.Warehouse.Lib.ViewModels.SpkDocsViewModel
{
    public class SPKDocsItemViewModel : BaseViewModel
    {
        public ItemViewModel item { get; set; }
        public double quantity { get; set; }
        public string remark { get; set; }
        public double sendquantity { get; set; }
        [MaxLength(255)]
        public string UId { get; set; }
        
    }
}