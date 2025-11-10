using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class SmartDevice
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
            status = true;
        }
        //turn off method
        public void turnOff()
        {
            status = false;
        }
        //get status method
        public bool getStatus()
        {
            return status;
        }
    }
}
