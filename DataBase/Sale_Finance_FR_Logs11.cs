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
    
    public partial class Sale_Finance_FR_Logs11
    {
        public int Id { get; set; }
        public Nullable<int> HTId { get; set; }
        public string HTSN { get; set; }
        public string Customer { get; set; }
        public string PayModel { get; set; }
        public Nullable<int> operator_id { get; set; }
        public string operator_name { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Remaks { get; set; }
    }
}
