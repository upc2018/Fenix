//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fenix
{
    using System;
    using System.Collections.Generic;
    
    public partial class CardStockItems
    {
        public int ID { get; set; }
        public bool ItemVerKit { get; set; }
        public int ItemOrKitID { get; set; }
        public int ItemOrKitUnitOfMeasureId { get; set; }
        public Nullable<decimal> ItemOrKitQuantity { get; set; }
        public Nullable<int> ItemOrKitQuality { get; set; }
        public decimal ItemOrKitFree { get; set; }
        public decimal ItemOrKitUnConsilliation { get; set; }
        public decimal ItemOrKitReserved { get; set; }
        public decimal ItemOrKitReleasedForExpedition { get; set; }
        public Nullable<decimal> ItemOrKitExpedited { get; set; }
        public int StockId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public int ModifyUserId { get; set; }
    }
}
