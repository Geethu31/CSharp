using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Configuration
    {
        public static string ApplicationName;
        public string Language;
        static Configuration()
        {
            ApplicationName = "MyApp";
        }
        public Configuration(string language)
        {
            Language = language;
        }
        public void DisplayConfiguration()
        {
            Console.WriteLine($"Application Name: {ApplicationName}");
            Console.WriteLine($"User Language: {Language}");
        }
    }
}
