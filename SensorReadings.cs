using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class SensorReadings:EventArgs
    {
        public int Temp { get; }

        public SensorReadings(int Temp)
            { this.Temp = Temp; }
     

    }
}
