﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Garage_2._0_MPT.Models
{    
    public class StatViewModel
    {
        public int TotalWeels { get; set; }
        public int TotalIncome { get; set; }
        public int TodayTotalIncome { get; set; }
        public string sTyp { get; set; }
        public IGrouping<string, string>[] myTypes { get; set; }

    }
}
