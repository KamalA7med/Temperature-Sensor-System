using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
          TemperatureSensor sensor = new TemperatureSensor();
           DisplayScreen screen= new DisplayScreen();
            Alarm alarm = new Alarm(50);
            screen.Connect(sensor);
            alarm.Connect(sensor);
            char ch;
            do
            {
                Console.Write("Enter  Tempeatur : ");
                sensor.ReadTemp(int.Parse(Console.ReadLine()));
                alarm.Check_Temp();
                screen.Display();
                Console.WriteLine("Do you Want To Enter Another one [Y/N]?");
                ch=char.Parse(Console.ReadLine());
            } while (ch=='Y'||ch=='y');
        }
    }
}
