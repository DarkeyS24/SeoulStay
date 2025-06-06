﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeoulStay.Models
{
    public class User
    {
        public Int64 Id { get; set; }
        public Guid Guid { get; set; } = Guid.Empty;
        public Int64 UserTypeId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public byte Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int FamilyCount { get; set; }
    }
}
