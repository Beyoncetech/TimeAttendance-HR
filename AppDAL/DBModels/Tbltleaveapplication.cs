using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tbltleaveapplication
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public string Reason { get; set; }
        public int? ProcessLevel { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
