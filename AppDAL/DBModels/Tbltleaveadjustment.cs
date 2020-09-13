using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tbltleaveadjustment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime TrDate { get; set; }
        public string AdjustmentType { get; set; }
        public string Reason { get; set; }
        public int? ProcessLevel { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
