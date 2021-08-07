using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uboatTorpidoProtractor
{
    class Program
    {
        public static string input = "none";
        public static int virtical = 0;
        public static int Direct = 0;
        public static int horizental = 0;
        public static double result = 0;
        public static double output = 0;
        public static int outputCount = 0;
        static void Main(string[] args)
        {
            while (outputCount <= Int32.MaxValue)
            {
                Console.WriteLine("Please enter the factor((virtical range):(Direct range):(hroizental range))");

                input = Console.ReadLine();
                string[] lines = input.Split(':');
                virtical = Convert.ToInt32(lines[0]);
                Direct = Convert.ToInt32(lines[1]);
                horizental = Convert.ToInt32(lines[2]);
                Maincarculation(virtical, Direct, horizental);
                Console.WriteLine();
                Console.WriteLine("The angle of torpido corse is : " + output);
                Console.WriteLine();
                outputCount += 1;
            }
            Console.WriteLine("Press any key to countinue ... ");
            Console.ReadKey();
        }
        
        static void Maincarculation(int virtical,int Direct,int horizental)
        {
            double carculatinoFactor = 0;
            pitaPlus(virtical, Direct);
            carculatinoFactor = horizental / result;
            output = carculatinoFactor * 90.0d;
            return;

        }

        public static void pitaPlus(double firstNumber, double SecondNumber)
        {
            double calculationfactor = 0;
            //make this value to public double result = 0; 
            calculationfactor = firstNumber * firstNumber + SecondNumber * SecondNumber; //squared
            result = Math.Sqrt(calculationfactor); //squrt the factor of calculation
            result = Math.Round(result, 3); //round the value
            return;


        }


        public static void pitaMinos(double firstNumber, double SecondNumber)
        {
            double calculationfactor = 0;
            if (firstNumber > SecondNumber)
            {
                calculationfactor = firstNumber * firstNumber - SecondNumber * SecondNumber; //squared
            }
            else
            {
                calculationfactor = SecondNumber * SecondNumber - firstNumber * firstNumber; //squared
            }
            result = Math.Sqrt(calculationfactor); //squrt the factor of calculation
            result = Math.Round(result, 3); //round the value
            return;

        }

    }
}
