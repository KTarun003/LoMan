﻿using LoMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoMan.ViewModels
{
    public class RecoveryVM
    {
        public Loan loan { get; set; }
        public string Type { get; set; }
        public float Penalty { get; set; }
        public string PreviousUrl { get; set; }
    }
}
