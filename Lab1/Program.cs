using System.Diagnostics.Metrics;
using System;
using System.Text.RegularExpressions;

namespace LAB1
{
    internal class Program
    {//29535123p48723487597645723645
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a random string!");
                string input = Console.ReadLine();
                List<string> numStrings = new List<string>();

                for (int startValue = 0; startValue < input.Length; startValue++)
                {
                    for (int endValue = startValue + 1; endValue < input.Length; endValue++)
                    {
                        if (char.IsLetter(input[endValue]))
                        {
                            break;
                        }

                        if (input[startValue] == input[endValue])
                        {

                            numStrings.Add(input[startValue..(endValue + 1)]);

                            break;
                        }
                    }
                }
                numStrings.ForEach(s =>
                {
                    Console.Write(input[0..input.IndexOf(s, 0)]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(s);
                    Console.ResetColor();
                    Console.WriteLine(input[(input.IndexOf(s, 0) + s.Length)..^0]);
                    Console.ResetColor();
                });
                long sum = numStrings.Select(s => long.Parse(s)).Sum();
                Console.WriteLine($"The total sum is;  {sum}!");

            }
















        }
    }
}