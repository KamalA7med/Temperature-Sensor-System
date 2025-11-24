using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class TemperatureSensor
    {
       
        public event EventHandler<SensorReadings>Temperature_Chenged ;
        public void ReadTemp(int Temp)
        {
            Temperature_Chenged(this, new SensorReadings(Temp));
        }

    }
}
