using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class SmartLight : SmartDevice
    {
        //private fields
        private double brightness;
        private string colour;

        //public properties
        public double Brightness
        {
            get { return brightness; }
            set { brightness = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        //contructor
        public SmartLight(int deviceID, string deviceName, double brightness, string colour, bool status) : base(deviceID, deviceName, status)
        {
            this.Brightness = brightness;
            this.Colour = colour;
        }

        //brightness method
        public void SetBrightness(Double brightness)
        {
            this.Brightness = brightness;
            Console.WriteLine($"Brightness of {DeviceName} now set to {Brightness}");
        }

        //colour method
        public void SetColour(string colour)
        {
            this.Colour = colour;
            Console.WriteLine($"Colour of {DeviceName} now set to {Colour}");
        }

        //status override
        public override void getStatus()
        {
            base.getStatus();
            Console.WriteLine($"Brightness: {Brightness}%, Colour: {Colour}");
        }
    }
}
