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
    
    public partial class CRM_contract_header
    {
        public CRM_contract_header()
        {
            this.CRM_contract_detail = new HashSet<CRM_contract_detail>();
        }
    
        public int id { get; set; }
        public string SN { get; set; }
        public int customer_id { get; set; }
        public Nullable<System.DateTime> delivery_date { get; set; }
        public string delivery_channel { get; set; }
        public decimal amount { get; set; }
        public Nullable<decimal> amount_recommend { get; set; }
        public string freight_carrier { get; set; }
        public Nullable<decimal> prepay { get; set; }
        public Nullable<bool> measure_flag { get; set; }
        public string delivery_address { get; set; }
        public Nullable<int> signed_user_id { get; set; }
        public Nullable<int> signed_department_id { get; set; }
        public byte status { get; set; }
        public Nullable<int> check_user_id { get; set; }
        public string check_user_name { get; set; }
        public Nullable<System.DateTime> checked_date { get; set; }
        public string department { get; set; }
        public string SaleName { get; set; }
        public Nullable<System.DateTime> HTDate { get; set; }
        public int FR_flag { get; set; }
        public System.DateTime created_time { get; set; }
        public bool delete_flag { get; set; }
        public Nullable<int> reserved1 { get; set; }
        public Nullable<int> reserved2 { get; set; }
        public string reserved3 { get; set; }
    
        public virtual ICollection<CRM_contract_detail> CRM_contract_detail { get; set; }
        public virtual CRM_customers CRM_customers { get; set; }
    }
}