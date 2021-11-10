using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting array values for the Math Methods
            var firstSumArray = new double[] { 2, 4 };
            var secondSumArray = new double[] { 2, 4, 6 };
            var thirdSumArray = new double[] { 1, 1, 1, 1, 1 };
            var diffArray = new double[] { 10, 8 };
            var prodArray = new double[] { 5, 3 };
            var quotArray = new double[] { 9, 2 };
            var remainArray = new double[] { 12, 10 };

            //Referencing Math Methods for the array values
            var firstSum = Add(firstSumArray);
            var secondSum = Add(secondSumArray);
            var thirdSum = Add(thirdSumArray);
            var differnce = Subtract(diffArray);
            var product = Multiply(prodArray);
            var quotient = Divide(quotArray);
            var remainder = Modulus(remainArray);

            //Output of math methods while calling array index's to show the values used
            Console.WriteLine($"{firstSumArray[0]} + {firstSumArray[1]} = {firstSum}");
            Console.WriteLine($"{secondSumArray[0]} + {secondSumArray[1]} + {secondSumArray[2]} = {secondSum}");
            Console.WriteLine($"{thirdSumArray[0]} + {thirdSumArray[1]} + {thirdSumArray[2]} + {thirdSumArray[3]} + {thirdSumArray[4]} = {thirdSum}");
            Console.WriteLine($"{diffArray[0]} - {diffArray[1]} = {differnce}");
            Console.WriteLine($"{prodArray[0]} * {prodArray[1]} = {product}");
            Console.WriteLine($"{quotArray[0]} / {quotArray[1]} = {quotient}");
            Console.WriteLine($"{remainArray[0]} mod {remainArray[1]} = {remainder}");

            Console.ReadLine();
        }

        //Math Methods using params - Addition, Subtraction, Multiplication, Division, and Modulus

        private static double Add(params double[] numbers) //Addition Method with Params
        {
            double value = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                value += numbers[i];
            }

            return value;
        }
        private static double Subtract(params double[] numbers) //Substraction Method with Prams
        {
            double value = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                value -= numbers[i];
            }

            return value;
        }
        private static double Multiply(params double[] numbers) //Multiplication Method with Prams
        {
            double value = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                value *= numbers[i];
            }

            return value;
        }
        private static double Divide(params double[] numbers) //Division Method with Prams
        {
            double value = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                value /= numbers[i];
            }

            return value;
        }
        private static double Modulus(params double[] numbers) //Modulus Method with Prams
        {
            double value = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                value %= numbers[i];
            }

            return value;
        }

    }

}
