﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PRN221_Asm02.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Type { get; set; }
    }
}
