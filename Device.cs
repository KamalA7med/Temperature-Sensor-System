using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Device
    {
        protected SensorReadings Readings;
        public  void Connect(TemperatureSensor sensor) {
            sensor.Temperature_Chenged += SaveChanges;

        }
        private void SaveChanges(object sender,SensorReadings readings)
        {
            Readings=readings;
        }
    }
}
