using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblrholidaygroupassignment
    {
        public int Id { get; set; }
        public int HolidayGroupId { get; set; }
        public int HolidayId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
