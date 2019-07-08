using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumberToWordConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            bool terminate = false;
            while (!terminate)
            {
                try
                {
                    Console.WriteLine("Enter a Number to convert to words");
                    value = Console.ReadLine();
                    if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    {

                        if (Regex.IsMatch(value, "[0-9]{1,10}"))
                        {
                            int number = Convert.ToInt32(value);
                            Console.WriteLine(Convertor.ConvertNumberToString(number));
                            Console.ReadKey();
                            terminate = true;
                        }
                        else
                        {
                            throw new FormatException(String.Format("Invalid number {0}", value));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter number to convert");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(String.Format("Unsupported or invalid number {0}", value));
                }
            }
        }
    }
}
