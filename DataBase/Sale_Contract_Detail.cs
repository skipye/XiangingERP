//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale_Contract_Detail
    {
        public int Id { get; set; }
        public int SaleContractHeadId { get; set; }
        public int ProductId { get; set; }
        public string ProductArea { get; set; }
        public string ProductSN { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public string WoodName { get; set; }
        public Nullable<bool> CustomFlag { get; set; }
        public Nullable<decimal> length { get; set; }
        public Nullable<decimal> width { get; set; }
        public Nullable<decimal> height { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> price_recommend { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Unit { get; set; }
        public string hardware_part { get; set; }
        public string decoration_part { get; set; }
        public string req_others { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        public virtual Sale_Contract_Header Sale_Contract_Header { get; set; }
    }
}