﻿using System;
using System.Collections.Generic;

namespace AppDAL.DBModels
{
    public partial class Tblmholidaygroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
