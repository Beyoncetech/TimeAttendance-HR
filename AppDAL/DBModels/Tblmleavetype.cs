﻿using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblmleavetype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
