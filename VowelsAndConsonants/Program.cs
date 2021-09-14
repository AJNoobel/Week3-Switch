using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht:");
            char usercharacter = Convert.ToChar(Console.ReadLine().ToLower());
            switch (usercharacter)
            {
                case 'a':
                    Console.WriteLine("täishäälik");
                        break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("täishäälik");
                    break;
                case 'U':
                    Console.WriteLine("täishäälik");
                    break;
                default:
                    Console.WriteLine("täishäälik");
                    break;




            }
        }
    }
}
