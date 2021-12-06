using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEmi
{
    public class Program
    {

        public static void Main(String[] args)
        {
            //object created
            var take = new Program();
            //taking user input
            try
            {
                Console.WriteLine("EMI Calculator for 2 wheeler");
                Console.WriteLine("Enter Principle Amount:");
                double p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rate of Interest:");
                double i = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter number of years:");
                double t = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Monthly Compounding:");
                double n = Convert.ToDouble(Console.ReadLine());

                var SpObject = new EmiCal();
                double emi = SpObject.emi_calculator(p, i, t, n);
                // print output
                Console.WriteLine("Monthly EMI is:" + emi);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            { }
            Console.ReadLine();
        }
    }
}

