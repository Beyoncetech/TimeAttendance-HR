using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblmemployee
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string CardId { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public string ShiftType { get; set; }
        public string WeeklyOff { get; set; }
        public int? HolidayGroupId { get; set; }
        public int? LeaveGroupId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
