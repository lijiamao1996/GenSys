//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenSys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sys_operation_log
    {
        public int id { get; set; }
        public string log_type { get; set; }
        public string log_name { get; set; }
        public Nullable<int> user_id { get; set; }
        public string class_name { get; set; }
        public string method { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string succeed { get; set; }
        public string message { get; set; }
    }
}
