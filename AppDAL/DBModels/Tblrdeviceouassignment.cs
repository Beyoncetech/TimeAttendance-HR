using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblrdeviceouassignment
    {
        public int Id { get; set; }
        public int Ouid { get; set; }
        public int DeviceId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ClosedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
