using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class User
    {
        //private fields
        private int userId;
        private string userName;
        private string contactInfo;
        private string password;
        private bool isLoggedIn;

        //public properties
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        //constructor
        public User(int userId, string userName, string contactInfo, string password)
        {
            this.userId = userId;
            this.userName = userName;
            this.contactInfo = contactInfo;
            this.password = password;
        }

        //login method
        public bool logIn(string userName, string password)
        {
            if (userName == UserName && password == Password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Successfully logged in");
            }
            else
            {
                IsLoggedIn = false;
                Console.WriteLine("Username or password incorrect");
            }
            return IsLoggedIn;
        }

        //log out
        public void logOut()
        {
            if (IsLoggedIn)
            {
                Console.WriteLine("Logged out successfully");
            }
            else
            {
                Console.WriteLine("User is not logged in");
            }
        }

        //control method
        public void ControlDevice(int deviceId, string deviceName, string deviceAction)
        {
            if (isLoggedIn)
            {
                Console.WriteLine($"Performing action {deviceAction} with {deviceName}");
            }
            else
            {
                Console.WriteLine($"Please log in to use devices");
            }
        }

    }
}
