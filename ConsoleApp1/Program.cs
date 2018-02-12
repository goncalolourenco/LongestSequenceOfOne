using System;
using ConsoleApp1.Functions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2) System.Console.WriteLine("Command must have only 2 arguments");

            String command = args[0];
            if (command != "Longest")
            {
                System.Console.WriteLine("This app only receives command of type Longest");
                System.Console.ReadLine();
                return;
            }

            String values = args[1];
            try
            {
                System.Console.WriteLine(Functions.Functions.LongestSequenceOfOneV1(values.Split(',').Select(n => Convert.ToInt32(n)).ToArray()));

            }catch(Exception e)
            {
                System.Console.WriteLine("Provide a list of integers separated by ,");
            }

            System.Console.ReadLine();
        }
    }
}
