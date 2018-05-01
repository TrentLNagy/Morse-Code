using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Code
{
    class Program
    {
        private static Dictionary<char, string> _morseAlphabet;

        static void Main(string[] args)
        {
            CreateDictionary();
            string input = GetInput();
            Console.WriteLine(Encode(input));

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        private static void CreateDictionary()
        {
            _morseAlphabet = new Dictionary<char, string>()
            {
                //Letters
                {'a', ".-" },    {'b', "-..." },    {'c', "-.-." },
                {'d', "-.." },   {'e', "." },       {'f', "..-." },
                {'g', "--." },   {'h', "...." },    {'i', ".." },
                {'j', ".---" },  {'k', "-.-" },     {'l', ".-.." },
                {'m', "--" },    {'n', "-." },      {'o', "---" },
                {'p', ".--." },  {'q', "--.-" },    {'r', ".-." },
                {'s', "..." },   {'t', "-" },       {'u', "..-"},
                {'v', "...-" },  {'w', ".--" },     {'x', "-..-" },
                {'y', "-.--" },  {'z', "--.." },

                //Punctuation
                {'?', "----" },  {'.', "---." },    {'-', "..--" },
                {',', "--..--" },

                //Numbers
                {'1', ".----" }, {'2', "..---" },   {'3', "...--" },
                {'4', "....-" }, {'5', "....." },   {'6', "-...." },
                {'7', "--..." }, {'8', "---.." },   {'9', "----." },
                {'0', "-----" },
            };
        }

        private static string GetInput()
        {
            Console.WriteLine("Enter text to be encoded into Morse Code");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                input = input.ToLower();
            }

            return input;
        }

        private static string Encode(string input)
        {
            StringBuilder edit = new StringBuilder();

            foreach(char ch in input)
            {
                if (_morseAlphabet.ContainsKey(ch))
                {
                    edit.Append(_morseAlphabet[ch] + " ");
                }
                else if (ch == ' ')
                {
                    edit.Append("/ ");
                }
                else
                {
                    edit.Append(ch + " ");
                }
            }
            return edit.ToString();
        }

    }
}
