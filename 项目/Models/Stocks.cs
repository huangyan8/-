//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 项目.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stocks
    {
        public string StockID { get; set; }
        public string PPID { get; set; }
        public Nullable<System.DateTime> StockDate { get; set; }
        public Nullable<System.DateTime> StockInDate { get; set; }
        public Nullable<int> StockUser { get; set; }
        public Nullable<int> StockState { get; set; }
        public string StockDesc { get; set; }
    }
}
