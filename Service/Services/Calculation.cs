using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class Calculation : ICalculation
    {


        
        public int Calculate(int n, int m)
        {
            string operation = Console.ReadLine();
            int result = 0;

            switch (operation)
            {
                case "+":
                    result = n + m;
                    break;
                case "-":
                    result = n - m;
                    break;
                case "*":
                    result = n * m;
                    break;
                case "/":
                    result = n / m;
                    break;
                default:
                    return -1;
            }
            return result;
        }

        public bool ICalculate(int n, int m)
        {
            throw new NotImplementedException();
        }

        void ICalculation.Calculate(int n, int m)
        {
            throw new NotImplementedException();
        }


    }
}
