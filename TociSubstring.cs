// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("Substring plus Test Substringa");
Console.WriteLine("Use of Substring");

TociSubstring.TociSubstring ts = new();                                         //ts to instancja klasy TociSubstring
#pragma warning disable CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
Console.Write("Word:");

string string_input = null;
string string_output = null;
int from_char = 0;
int to_char = 0;

#pragma warning restore CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
string_input = string.Empty;
string_input = ReadLine();


Console.Write("from nr:");
ts.LiczbaNieujemna = int.Parse(ReadLine());
from_char = ts.LiczbaNieujemna - 1;

Console.Write("to nr:");
ts.LiczbaNieujemna = int.Parse(ReadLine());
to_char = ts.LiczbaNieujemna - 1;

string_output = ts.Substring(string_input, from_char, to_char);
//Console.WriteLine(string_input);
WriteLine("substring : " + string_output);

ReadKey();


namespace TociSubstring
{
    public class TociSubstring
    {

        //Substring("beatka",2,3) >1-b,2-e,3-a,4-t,5-k,6-a
        public virtual string Substring(string candidate, int position, int lenght)
        {
            string result = string.Empty;
            if (candidate != string.Empty && position <= candidate.Length && lenght<candidate.Length)
            {

                for (i = position; i <= position + lenght; i++)
                {
                    result += candidate[i];
                }
            }

            return result;
        }


        private int liczbaNieujemna;

        public int LiczbaNieujemna
        {
            get => liczbaNieujemna;
            set
            {
                if (value >= 0 && value < int.MaxValue)
                    liczbaNieujemna = value;
            }
        }
    }
}