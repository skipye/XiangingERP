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
    
    public partial class Sale_Customers
    {
        public Sale_Customers()
        {
            this.Sale_Contract_Header = new HashSet<Sale_Contract_Header>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string Address_Delivery { get; set; }
        public string LinkMan { get; set; }
        public string LinkTel { get; set; }
        public string Email { get; set; }
        public Nullable<int> BelongUserId { get; set; }
        public string BelongUserName { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Department { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> DeleteFlag { get; set; }
    
        public virtual ICollection<Sale_Contract_Header> Sale_Contract_Header { get; set; }
    }
}
