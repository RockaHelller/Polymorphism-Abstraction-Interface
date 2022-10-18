using Service.Services;
using Service.Services.Interfaces;
using System;

namespace Polymorphism_Abstraction_Interface_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Add First Number");
            int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Add Operation");
            //string operation = Console.ReadLine();

            Console.WriteLine("Please Add Second Number");
            int m = int.Parse(Console.ReadLine());
            
            ICalculation calculation = new Calculation();

            Console.WriteLine(calculation.ICalculate(n, m));











        }





    }






}
