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
    
    public partial class Address_Info
    {
        public Address_Info()
        {
            this.OrderInfo = new HashSet<OrderInfo>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telphone { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string addressNo { get; set; }
        public Nullable<System.Guid> MemberId { get; set; }
        public Nullable<int> RegionId { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public Nullable<bool> IsTop { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<bool> State { get; set; }
    
        public virtual ICollection<OrderInfo> OrderInfo { get; set; }
    }
}