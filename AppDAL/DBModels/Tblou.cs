using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblou
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OutypeId { get; set; }
        public int? ParenetOuid { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
