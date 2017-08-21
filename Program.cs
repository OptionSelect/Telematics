using System;
using System.IO;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Telematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Vechile Number. ");
            var vinInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Mileage. ");
            var odometerInput = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Consumption. ");
            var consumptionInput = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Miles at Last Oil Change. ");
            var lastOilChange = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Engine Size. ");
            var engineSize = double.Parse(Console.ReadLine());

            var newVehicle = new VehicleInfo(vinInput, odometerInput, consumptionInput, lastOilChange, engineSize); 
            new TelematicsService().Report(newVehicle);
            new TelematicsService().GenerateHTMLReport(newVehicle);
        }
    }
}
