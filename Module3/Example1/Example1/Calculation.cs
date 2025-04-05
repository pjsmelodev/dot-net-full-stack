using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Calculation
    {
        public void Calculate(int num1, int num2)
        {
            int result = 0; 

            try
            {
                result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("I will always execute.");
                Console.WriteLine(result);
            }
        }

        public void CalculateAnother()
        {
            int num1, num2, result = 0;

            try
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
            }
            // Deve ser SEMPRE a última opção porque ela é a mais genérica e lida com qualquer erro
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("I will always execute.");
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
