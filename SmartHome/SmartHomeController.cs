using SmartHome;

public class Program
{

    private static List<SmartDevice> devices = new List<SmartDevice>();
    static string destinationFilePath;

    private static void Main()
    {
        string folder = "Data";
        string filename = "smartdevices.csv";

        string destinationFilePath = CopyDataToWorkingDir(folder, filename);
        LoadSmartDevices(destinationFilePath);
        MainMenu();
    }

    public static void LoadSmartDevices(string destinationFilePath)
    {
        using (var reader = new StreamReader(destinationFilePath))
        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                //convert missing data into 0 for doubles and ints
                if (values[3].Length == 0)
                {
                    values[3] = "0";
                }
                if (values[6].Length == 0)
                {
                    values[6] = "0";
                }
                if (values[7].Length == 0)
                {
                    values[7] = "0";
                }
                if (values[8].Length == 0)
                {
                    values[8] = "0";
                }

                //read each value into currect variable
                int deviceID = int.Parse(values[0]);
                string deviceType = values[1];
                string deviceName = values[2];
                double brightness = Convert.ToDouble(values[3]);
                string colour = values[4];
                string cameraResolution = values[5];
                double currentTemperature = Convert.ToDouble(values[6]);
                double targetTemperature = Convert.ToDouble(values[7]);
                int speakerVolume = int.Parse(values[8]);

                //create an empty instanse of the smart device obejct, call it device
                SmartDevice device = null;

                //device type is decided through the csv file
                switch (deviceType)
                {
                    case "SmartLight":
                        device = new SmartLight(deviceID, deviceName, brightness, colour, true);
                        break;
                    case "SmartSecurityCamera":
                        device = new SmartSecurityCamera(deviceID, deviceName, cameraResolution, true);
                        break;
                    case "SmartThermostat":
                        device = new SmartThermostat(deviceID, deviceName, currentTemperature, targetTemperature, true);
                        break;
                    case "SmartSpeaker":
                        device = new SmartSpeaker(deviceID, deviceName, speakerVolume, true);
                        break;
                }

                //add the device into the list of devices
                if (device != null)
                {
                    devices.Add(device);
                }
            }
        }
    }

    //copy current data path to working directory
    public static string CopyDataToWorkingDir(string folder, string filename)
    {
        // Define the source and destination paths
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName; //optain project dir
        string sourceFilePath = Path.Combine(projectDirectory, folder, filename);                           //obtain filepath
        string destinationFilePath = Path.Combine(Environment.CurrentDirectory, filename);                  //set desired filepath

        // Copy the file to the working directory
        if (File.Exists(sourceFilePath))
        {
            File.Copy(sourceFilePath, destinationFilePath, true);
        }
        else
        {
            Console.WriteLine("Source file not found: " + sourceFilePath);
        }

        // Retrun the path to the copied file
        return destinationFilePath;
    }

    public static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Install new device");
            Console.WriteLine("2. Control a device");
            Console.WriteLine("3. View all devices");
            Console.WriteLine("4. Save device list");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option: ");
            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                //
                break;

                case "2":
                    //
                break;

                case "3":
                    ViewAllDevices();
                break;

                case "4":
                    //
                break;

                case "5":
                    //
                return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }

        public static void ViewAllDevices()
    {
        Console.WriteLine("All devices: ");
        foreach (var device in devices)
        {
            device.getStatus();
        }
    }
    }
}
