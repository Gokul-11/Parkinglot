using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ParkingLot
{
    public class Program
    {
        static readonly string InputFile = @"F:\.net\ParkingLot\Input\ParkingLot.txt";

        public static List<int> ParkingSlots { get; set; }

        public static List<VehicleInfo> VehicleDetails = null;

        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(InputFile);
            foreach (string line in lines)
            {
                var key = line.Split(' ');
                switch (key.First())
                {
                    case "create_parking_lot":
                        CreatParkingLot(Convert.ToInt32(key.Last()));
                        break;

                    case "park":
                        ParkVehicle(key[1], key[2]);
                        break;

                    case "leave":
                        LeaveVehicle(Convert.ToInt32(key.Last()));
                        break;

                    case "status":
                        VehicleList();
                        break;

                    case "registration_numbers_for_cars_with_colour":
                        GetRegistrationNumberWithVehicleColor(key.Last());
                        break;

                    case "slot_numbers_for_cars_with_colour":
                        GetSlotNumbersWithVehicleColor(key.Last());
                        break;

                    case "slot_number_for_registration_number":
                        GetSlotNumbersWithRegistratinNumber(key.Last());
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public static void CreatParkingLot(int noOfSlots)
        {
            ParkingSlots = new List<int>();
            for (int slotnum = 1; slotnum <= noOfSlots; slotnum++)
            {
                ParkingSlots.Add(slotnum);
            }

            VehicleDetails = new List<VehicleInfo>();

            Console.WriteLine("Created a parking lot with {0} slots", noOfSlots);
        }

        public static void ParkVehicle(string registrationNumber, string color)
        {
            int slotNumber = ParkingSlots.OrderBy(x => x).FirstOrDefault();
            if (slotNumber > 0)
            {
                VehicleDetails.Add(new VehicleInfo { SlotNo = slotNumber, RegistrationNumber = registrationNumber, Color = color });
                ParkingSlots.Remove(slotNumber);
                Console.WriteLine("\nAllocated slot number: {0}", slotNumber);
            }
            else
            {
                Console.WriteLine("\nSorry, parking lot is full");
            }
        }

        public static void LeaveVehicle(int slotNo)
        {
            VehicleDetails.Remove(VehicleDetails.FirstOrDefault(x => x.SlotNo == slotNo));
            ParkingSlots.Add(slotNo);
            Console.WriteLine("\nSlot number {0} is free", slotNo);
        }

        public static void VehicleList()
        {
            Console.WriteLine("\nSlot No.\tRegistration No\tColour");
            foreach (var info in VehicleDetails)
            {
                Console.WriteLine("\n{0}\t{1}\t{2}", info.SlotNo, info.RegistrationNumber, info.Color);
            }
        }

        public static void GetRegistrationNumberWithVehicleColor(string color)
        {
            var registrationNumbers = string.Join(',', VehicleDetails.Where(x => x.Color == color).Select(x => x.RegistrationNumber).ToList());
            Console.WriteLine("\n{0}", registrationNumbers);
        }

        public static void GetSlotNumbersWithVehicleColor(string color)
        {
            var slotnumbers = string.Join(',', VehicleDetails.Where(x => x.Color == color).Select(x => x.SlotNo).ToList());
            Console.WriteLine("\n{0}", slotnumbers);
        }

        public static void GetSlotNumbersWithRegistratinNumber(string registrationNumber)
        {
            var vehicleInfo = VehicleDetails.Where(x => x.RegistrationNumber == registrationNumber).FirstOrDefault();
            if(vehicleInfo != null)
            {
                Console.WriteLine("\n{0}", vehicleInfo.SlotNo);
            }
            else
            {
                Console.WriteLine("\nNot found");
            }
        }
    }

    public class VehicleInfo
    {
        public int SlotNo { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
    }
}
