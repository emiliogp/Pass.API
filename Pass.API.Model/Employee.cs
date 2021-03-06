﻿using System;
using System.Collections.Generic;
using System.Text;
using Pass.API.Interfaces.Entities;

namespace Pass.API.Model
{
    public class EmployeeDTO : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NetworkId { get; set; }
        public string Job { get; set; }
    }
}
