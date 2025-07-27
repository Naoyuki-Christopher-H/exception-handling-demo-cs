using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_demo_cs
{
    class Solution
    {
        public Solution()
        {
            try
            {
                Double Value_1;
                Double Value_2;
                Double Value_3;

                Console.WriteLine("Enter the first number:");
                Value_1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                Value_2 = Convert.ToDouble(Console.ReadLine());

                Value_3 = Value_1 / Value_2;

                Console.WriteLine($"RESULT: {Value_3}");
            }
            catch (FormatException Issue)
            {
                Console.WriteLine($"ERROR: {Issue.Message}");
                Console.WriteLine($"NOTE: Number's only.");
                Console.Write($"VALUE: ");
            }
            catch (DivideByZeroException Issue)
            {
                Console.WriteLine($"ERROR: {Issue.Message}");
                Console.WriteLine($"NOTE: You can not divide by zero.");
                Console.Write($"VALUE: ");
            }
            catch (Exception Issue)
            {
                Console.WriteLine($"ERROR: {Issue.Message}");
                Console.Write($"VALUE: ");
            }
        }
    }
}