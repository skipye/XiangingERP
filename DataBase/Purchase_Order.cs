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
    
    public partial class Purchase_Order
    {
        public int Id { get; set; }
        public string SN { get; set; }
        public Nullable<int> ApplyUserId { get; set; }
        public string ApplyUserName { get; set; }
        public Nullable<System.DateTime> ApplyDateTime { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> CheckedStatus { get; set; }
        public Nullable<int> CheckedUserId { get; set; }
        public string CheckedName { get; set; }
        public Nullable<System.DateTime> CheckedDateTime { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
        public string Name { get; set; }
    }
}