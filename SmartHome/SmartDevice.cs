using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class SmartDevice
    {
        //private fields
        private int deviceId;
        private string deviceName;
        private bool status;

        //public fields
        public int DeviceID
        {
            get { return deviceId; }
            set { deviceId = value; }
        }
        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        //constructor
        public SmartDevice(int deviceId, string deviceName, bool status)
        {
            this.deviceId = deviceId;
            this.deviceName = deviceName;
            this.status = status;
        }

        //turn on method
        public void turnOn()
        {
            Console.WriteLine($"{deviceName} (ID: {DeviceID}) is now turned on");
            status = true;
        }
        //turn off method
        public void turnOff()
        {
            Console.WriteLine($"{deviceName} (ID: {DeviceID}) is now turned off");
            status = false;
        }
        //get status method
        public virtual void getStatus()
        {
            Console.WriteLine($"{deviceName} (ID: {DeviceID}) is {(status ? "on" : "off")}");
            //return status;
        }
    }
}
