using System;
using System.IO;
using System.Collections;
using Newtonsoft.Json;

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
    }
}