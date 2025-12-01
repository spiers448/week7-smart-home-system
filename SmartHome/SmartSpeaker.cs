using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class SmartSpeaker : SmartDevice
    {
        //private fields
        private double speakerVolume;

        //public properties
        public double SpeakerVolume
        {
            get { return speakerVolume; }
            set { speakerVolume = value; }
        }

        //contructor
        public SmartSpeaker(int deviceID, string deviceName, double speakerVolume, bool status) : base(deviceID, deviceName, status)
        {
            this.SpeakerVolume = speakerVolume;
        }

        //brightness method
        public void SetVolume(Double volume)
        {   
            if (volume > 100)
            {
                volume = 100;
            }

            this.speakerVolume = volume;
            Console.WriteLine($"Resolution of {DeviceName} now set to {speakerVolume}%");
        }

        //status override
        public override void getStatus()
        {
            base.getStatus();
            Console.WriteLine($"Volume: {speakerVolume}%");
        }
    }
}
