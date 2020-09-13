using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tbltleavebalance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ProcessingYearId { get; set; }
        public int OpenBalance { get; set; }
        public int Balance { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
