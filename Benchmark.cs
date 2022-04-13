// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Hello, World!");

namespace TociSubstring
{
    public class Benchmark
    {
        
        //Substring("beatka",2,3) >ea
        public virtual string Substring(string candidate, int position, int lenght)
        {
            string result = string.Empty;
            for (var i = position; i < lenght; i++)
            {
                result += candidate[i++];
            }

            return result;
        }
    }
} 