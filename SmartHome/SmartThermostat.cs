using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class SmartThermostat : SmartDevice
    {
        //private fields
        private double currentTemperature;
        private double targetTemperature;

        //public properties
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }
        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }

        //contructor
        public SmartThermostat(int deviceID, string deviceName, double currentTemperature, double targetTemperature, bool status) : base(deviceID, deviceName, status)
        {
            this.TargetTemperature = targetTemperature;
            this.CurrentTemperature = currentTemperature;
        }

        //brightness method
        public void SetTemperature(Double targetTemperature)
        {
            this.currentTemperature = targetTemperature;
            Console.WriteLine($"Resolution of {DeviceName} now set to {targetTemperature}");
        }

        //status override
        public override void getStatus()
        {
            base.getStatus();
            Console.WriteLine($"Current temperature: {CurrentTemperature}");
        }
    }
}
