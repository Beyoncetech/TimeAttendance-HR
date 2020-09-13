using System;
using System.Collections.Generic;
using System.Text;

namespace AppModel.BusinessModel.Master
{
    public class Shift
    {
        public int Id { get; set; }
        public byte[] Code { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? BreakFrom { get; set; }
        public DateTime? BreakTill { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
