using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //expandedForm(12); // Should return '10 + 2'
            //expandedForm(42); // Should return '40 + 2'
            //expandedForm(70304); // Should return '70000 + 300 + 4'

            Console.WriteLine("12: " + expandedForm(12));
            Console.WriteLine("42: " + expandedForm(42));
            Console.WriteLine("70304: " + expandedForm(70304));

            Console.WriteLine("\n" + new string('-', 30) + "\n");

            Console.WriteLine("12: " + expandedForm2(12));
            Console.WriteLine("42: " + expandedForm2(42));
            Console.WriteLine("70304: " + expandedForm2(70304));
        }


        static string expandedForm(int value)
        {
            string result = default;
            double val = default;
            string length = value.ToString();
            double[] arr = new double[length.Length];


            for (int i = 0; i < length.Length; i++)
            {
                val = value;
                val = val % 10;
                val = val * Math.Pow(10, i);

                value = value / 10;

                arr[i] = val;           
            }

            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                else if (i != 0)
                {
                    result += arr[i] + " + ";
                }
                else
                {
                    result += arr[i];
                }
            }

            return result;
        }

        static string expandedForm2(int value)
        {
            string result = default;
            double val = default;
            string val2 = default;
            string length = value.ToString();
            string[] arr = new string[length.Length];


            for (int i = 0; i < length.Length; i++)
            {
                val = value;
                val = val % 10;
                val2 = val.ToString() +  "*" + Math.Pow(10, i).ToString();

                value = value / 10;

                if (val != 0)
                {
                    arr[i] = val2;
                }
               
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == null)
                {
                    continue;
                }
                else if (i != 0)
                {
                    result += arr[i] + " + ";
                }
                else
                {
                    result += arr[i];
                }
            }

            return result;
        }


    }
}