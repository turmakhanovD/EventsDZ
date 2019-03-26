﻿using CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{

    public class DranduletCar : Car
    {
        public event CarEvent Finish;
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int DrivenDistance { get; set; }
        private Random rand;
        public DranduletCar()
        {
            rand = new Random();
        }
        public override void Drive()
        {

            int distancePerSec = rand.Next(1, MaxSpeed);

            DrivenDistance += distancePerSec;

            if (DrivenDistance >= 100)
            {
                Finish();
            }
        }
    }


}
