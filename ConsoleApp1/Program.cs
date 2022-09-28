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


            //Console.WriteLine(expandedForm(12));
            //expandedForm2(153);
            Console.WriteLine(expandedForm2(70304));
            //double d = 702;
            //var m = d / 10;
            // m = d % 10;
            //m = m * 10;

            //Console.WriteLine(m);
        }



        static string expandedForm(int value)
        {
            string result = default;
            double val = default;
            string length = value.ToString();


                for (int i = 0; i < length.Length; i++)
                {
                    val = value;
                    val = val % 10;
                    val = val * Math.Pow(10, i);
                    
                    value = value / 10;
                    if (i != length.Length - 1)
                    {
                        result += val + " + ";
                    }
                    else
                    {
                        result += val;
                    }
                }
           

            return result;
        }

        static string expandedForm2(int value)
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

        //static string expandedForm(int value)
        //{
        //    string result = null;
        //    string val = value.ToString();

        //    for (int i = 0; i <= val.Length; i++)
        //    {
        //        result += val.Substring(i, 1) + new string('0', val.Length - i-1) + "+";
        //    }
        //    return result;
        //}
    }
}