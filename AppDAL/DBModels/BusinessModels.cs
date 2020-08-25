﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppDAL.DBModels
{
    public class LoginUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }        
        public string UserPerm { get; set; }        
        public ulong IsActive { get; set; }
        public DateTime? Dob { get; set; }        
    }
}
