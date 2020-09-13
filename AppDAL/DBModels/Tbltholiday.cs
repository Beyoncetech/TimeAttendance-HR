using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tbltholiday
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
