
using CarLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CarLibrary
{
    public class Game
    {
        public void Start()
        {
            SportCar sportCar = new SportCar() { MaxSpeed = 8, DrivenDistance = 0 };
            PassengerCar passengerCar = new PassengerCar() { MaxSpeed = 5, DrivenDistance = 0 };
            DranduletCar dranduletCar = new DranduletCar() { MaxSpeed = 3, DrivenDistance = 0 };


            sportCar.Finish += () =>
            {
                Console.WriteLine("Спорткар победил");

            };
            passengerCar.Finish += () =>
            {
                Console.WriteLine("Легковое авто победила!");
            };
            dranduletCar.Finish += () =>
            {
                Console.WriteLine("Драндулет победил?");
            };


            int countSec = 1;
            Console.WriteLine("seconds\t\tsportCar\tpassangerCar\tdranduletCar");
            Console.WriteLine("______________________________________________________________");
            while (true)
            {
                if (sportCar.DrivenDistance >= 100 || passengerCar.DrivenDistance >= 100 || dranduletCar.DrivenDistance >= 100)
                {
                    break;
                }

                sportCar.Drive();
                passengerCar.Drive();
                dranduletCar.Drive();
                Console.WriteLine("{0}\t\t{1}m\t\t{2}m\t\t{3}m", countSec++, sportCar.DrivenDistance, passengerCar.DrivenDistance, dranduletCar.DrivenDistance);

               
            }
        }
    }
}