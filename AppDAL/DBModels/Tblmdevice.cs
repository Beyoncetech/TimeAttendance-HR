using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblmdevice
    {
        public int Id { get; set; }
        public string Cpuid { get; set; }
        public string Ipaddress { get; set; }
        public string Name { get; set; }
        public int? Ouid { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
