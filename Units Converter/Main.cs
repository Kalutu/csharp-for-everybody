using System;
using System.Windows.Forms;

namespace Units_Converted
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to unit converted software");
            Console.WriteLine("Enter the unit you want to convert");
            double unit = double.Parse(Console.ReadLine());

            UnitConverter unitConverter = new UnitConverter(unit);

            Console.WriteLine("Choose the unit you want to convert to");
            Console.WriteLine("1. Meters to Feet");
            Console.WriteLine("2. Meters to Centimeters");
            Console.WriteLine("3. Meters to Inches");
            Console.WriteLine("4. Feet to Meters");
            Console.WriteLine("5. Centimeters to Meters");
        

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(unitConverter.MetersToFeet());
                    break;
                case 2:
                    Console.WriteLine(unitConverter.MetersToCentimeters());
                    break;
                case 3:
                    Console.WriteLine(unitConverter.MetersToInches());
                    break;
                case 4:
                    Console.WriteLine(unitConverter.FeetToMeters());
                    break;
                case 5:
                    Console.WriteLine(unitConverter.CentimetersToMeters());
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
           
        }
    }
}