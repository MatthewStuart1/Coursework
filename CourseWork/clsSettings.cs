using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public static class Setting
    {
        //dictionary stores pairs of values https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/

        public static Dictionary<string, string> Settings = new Dictionary<string, string>();
        private static string file = "settings.txt";

        public static void Save()
        {
            using (StreamWriter streamwriter = new StreamWriter(file))
            {
                foreach (var keyValPair in Settings)
                {
                    streamwriter.WriteLine(keyValPair.Key + "=" + keyValPair.Value);
                }
            }
        }
        public static void Load()
        {
            if (File.Exists(file))
            {
                foreach (var line in File.ReadAllLines(file))
                {
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                        continue;
                    int i = line.IndexOf('=');
                    if (i > 0)
                    {
                        string key = line.Substring(0, i).Trim();
                        string value = line.Substring(i + 1).Trim();
                        Settings[key] = value;
                    }
                }
            }
            else
            {
                Settings["maxFlightHoursPerMonth"] = "100";
                Settings["minRestHoursBetweenFlights"] = "12";
                Settings["aircraftMaintenanceInterval"] = "100";
                Settings["defaultFlightLessonDuration"] = "90";
                Settings["maxStudentsPerInstructor"] = "5";
                Settings["cancellationFee"] = "50";
                Settings["bulkBookingDiscount"] = "10";
                Settings["fuelCostPerUnit"] = "4.50";
                Settings["serviceInterval"] = "100";
                Save();
            }
        }

    }
}
