using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblmoutype
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
