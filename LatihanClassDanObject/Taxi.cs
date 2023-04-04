using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    public class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            if (OnDuty == true){
                Console.WriteLine("On Duty : Yes ");
            }
            else{
                Console.WriteLine("On Duty : No ");
            }
            Console.WriteLine("Num Passenger: {0}", NumPassenger);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
    }
}
