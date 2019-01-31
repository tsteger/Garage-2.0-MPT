﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage_2._0_MPT.Models
{
    public class ListViewModel
    {
        public ParkingsHouseStatusViewModel ParkingsHouseStatusViewModel { get; set; }
        public IEnumerable<ParkedVehicle> ParkedVehicles { get; set; }
        public ParkedVehicle Header { get; set; }
    }
}
