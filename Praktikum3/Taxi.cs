using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    public class Taxi
    {
        //properties 
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name :{0}", DriverName);

            if(OnDuty)
            {
                Console.WriteLine("On Duty : YES");
            }
            else
            {
                Console.WriteLine("OnDuty : NO");
            }

            Console.WriteLine("Number Passenger : {0}", NumPassenger);
        }


        public void PickUpPassenger()
        {
            if(OnDuty)
            {
                Console.WriteLine("Driver {0} sedang menjemput penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("Driver {0} tidak sedang menjemput penumpang", DriverName);
            }
        }


        public void DropOffPassenger()
        {
            if (OnDuty)
            {
                Console.WriteLine("Driver {0} selesai mengantar penumpang", DriverName);
            }
            else
            {
                Console.WriteLine("Driver {0}", DriverName);
            }
        }

    }
}
