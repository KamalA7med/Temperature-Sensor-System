using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class DisplayScreen :Device
    {
        public void Display()
        {
            Console.WriteLine($"The Current Temperature Is {Readings.Temp}");
        }
      
    }
}
