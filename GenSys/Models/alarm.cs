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
    
    public partial class alarm
    {
        public int id { get; set; }
        public string device_id { get; set; }
        public string p2p_id { get; set; }
        public string ip { get; set; }
        public string token { get; set; }
        public string algorithm_id { get; set; }
        public long timestamp { get; set; }
        public string image { get; set; }
        public string message { get; set; }
        public string appendix { get; set; }
        public string state { get; set; }
        public string site { get; set; }
        public string alias { get; set; }
        public string type { get; set; }
        public Nullable<System.DateTime> datetime { get; set; }
        public Nullable<int> confirmed { get; set; }
    }
}
