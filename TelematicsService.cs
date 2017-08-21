using System;
using System.IO;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Telematics
{
    public class TelematicsService
    {
        JsonSerializer serializer = new JsonSerializer();
        public void Report(VehicleInfo vehicleInfo)
        {
            using (var writer = new StreamWriter(File.Open($"{vehicleInfo.VIN}.json", FileMode.OpenOrCreate)))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(writer, vehicleInfo);
            }
        }

        public void deJson(VehicleInfo vehicleInfo)
        {
            string[] files = System.IO.Directory.GetFiles("/Users/brandyn/dotnet/Telematics", "*.json");
            ///LIST CREATION GOES HERE
            List<object> vehicleList = new List<object>();
            foreach (var item in files)
            {
                using (StreamReader file = File.OpenText(item))
                {
                    var vehicleInfoObj = JsonConvert.DeserializeObject<VehicleInfo>(file.ReadToEnd());
                    vehicleList.Add(vehicleInfoObj);
                }
            }
        }

        public void updateHTML(VehicleInfo vehicleinf)
        {
            string html = File.ReadAllText("/Users/brandyn/dotnet/Telematics/Dashboard.html");
            Console.WriteLine(html);
        }
    }
}
