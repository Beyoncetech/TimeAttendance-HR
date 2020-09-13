using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tbltleaveupdaterule
    {
        public int Id { get; set; }
        public int LeaveGroupAssignmentId { get; set; }
        public string TimeOfUpdate { get; set; }
        public string AddPeriod { get; set; }
        public string UpdateRule { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
