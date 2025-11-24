using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Alarm:Device
    {
        public int Threeshold;
        public Alarm(int val) { 
            Threeshold = val;
        }

       public void SetThreeshold(int value)
        {
            Threeshold = value;
        }
        public void Check_Temp()
        {
            if(Readings.Temp>=Threeshold)
            {
                Console.WriteLine($"Fire The Alarm Temperature is higher than {Threeshold} ");
            }
        }
    }
}
