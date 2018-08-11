using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2, prediction = "";

            Console.WriteLine("Enter 1st name: ");
            name1 = Console.ReadLine();

            Console.WriteLine("Enter 2nd name: ");
            name2 = Console.ReadLine();

            var predict = new Predictor(name1, name2);
            prediction = predict.Compute();

            Console.WriteLine("{0} and {1} will be {2}.", name1, name2,prediction);
            Console.Read();
        }        
    }
}
