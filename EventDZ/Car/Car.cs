using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public delegate void CarEvent();
    public abstract class Car
    {
        public event CarEvent Finish;

        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int DrivenDistance { get; set; }
        public abstract void Drive();
    }

}
