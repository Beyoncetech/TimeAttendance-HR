using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblremployeeouassignment
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Ouid { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ClosedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
