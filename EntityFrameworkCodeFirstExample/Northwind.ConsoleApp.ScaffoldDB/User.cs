﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.ConsoleApp.ScaffoldDB
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? CustomerId { get; set; }
        public int? Role { get; set; }
    }
}
