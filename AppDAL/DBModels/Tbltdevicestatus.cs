using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tbltdevicestatus
    {
        public int Id { get; set; }
        public string Ipaddress { get; set; }
        public string Cpuid { get; set; }
        public string DeviceType { get; set; }
        public string Firmware { get; set; }
        public DateTime LastSyncTime { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ClosedOn { get; set; }
    }
}
