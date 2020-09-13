using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblrleavegroupassignment
    {
        public int Id { get; set; }
        public int LeaveGroupId { get; set; }
        public int LeaveTypeId { get; set; }
        public int? YearlyMaximum { get; set; }
        public int? MinPerApplicaation { get; set; }
        public int? MaxPerApplication { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ClosedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
