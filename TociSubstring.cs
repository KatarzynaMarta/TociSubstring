// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Substring plus Test Substringa");

namespace TociSubstring
{
    public class TociSubstring
    {

        //Substring("beatka",2,3) >2-a
        public virtual string Substring(string candidate, int position, int lenght)
        {
            string result = string.Empty;
            for (var i = position; i < position+lenght; i++)
            {
                result += candidate[i++];
            }

            return result;
        }
    }
}