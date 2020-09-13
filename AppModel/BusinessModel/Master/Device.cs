using System;
using System.Collections.Generic;
using System.Text;

namespace AppModel.BusinessModel.Master
{
    public class Device
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
