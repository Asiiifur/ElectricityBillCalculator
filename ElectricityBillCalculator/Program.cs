using System;

namespace ElectricityBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("Input Appliance power Watt :");
                double Watt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Uses Time (H)/Day:");
                double Time = Convert.ToInt32(Console.ReadLine());


                var unit = ((Watt * Time) / 1000);
                Console.WriteLine("Total Per Unit Par day");
                Console.WriteLine(unit);

                Console.WriteLine("Input Total Days In this Month:");
                double MonthDays = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input Per Unit Price:");
                double unitPrice = Convert.ToInt32(Console.ReadLine());

                var totalUnit = (unit * MonthDays);
                var TotalBill = (totalUnit * unitPrice);

                Console.WriteLine("---------------------");
                Console.WriteLine("Total Bill :");
                Console.WriteLine(TotalBill);


                Console.Read();


        
         }
    }
}
