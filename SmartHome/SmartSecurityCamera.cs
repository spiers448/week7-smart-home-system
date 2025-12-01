using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class SmartSecurityCamera : SmartDevice
    {
        //private fields
        private string cameraResolution;

        //public properties
        public string CameraResolution
        {
            get { return cameraResolution; }
            set { cameraResolution = value; }
        }

        //contructor
        public SmartSecurityCamera(int deviceID, string deviceName, string cameraResolution, bool status) : base(deviceID, deviceName, status)
        {
            this.CameraResolution = cameraResolution;
        }

        //brightness method
        public void SetBrightness(Double brightness)
        {
            this.cameraResolution = cameraResolution;
            Console.WriteLine($"Resolution of {DeviceName} now set to {cameraResolution}");
        }

        //status override
        public override void getStatus()
        {
            base.getStatus();
            Console.WriteLine($"Resolution: {cameraResolution}");
        }
    }
}
