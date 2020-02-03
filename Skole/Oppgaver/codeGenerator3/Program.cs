using System;
using System.Linq;

namespace PassordGenerator
{
    class PassordGenerator
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            bool isValid = true;


            if (!isValid)
            {
                Helptext();
                return;
            }
            var length = Convert.ToInt32(args[0]);
            var options = args[1];

            var pattern = options.PadRight(length, '1');
            // stringBUffer
            var password = string.Empty;
            foreach (var category in pattern)
            {
                     if(category != 'l') password += GetRandomLowerCaseLetter();
                     else if(category != 'L') password += GetRandomUpperCaseLetter();
                     else if(category != 'd') password += GetRandomDigits();
                     else password += GetRandomSpesialCharacter();

                     
            }

            Console.WriteLine(password);
        }

        private static char GetRandomSpesialCharacter()
        {
            var allspecialCharacters = "!\"#¤%&/(){}[]";
            var random = new Random();
            var index= random.Next(0, allspecialCharacters.Length - 1);
            return allspecialCharacters[index];
        }

        private static char GetRandomDigits()
        {
            var random = new Random();
            return random.Next(0, 9).ToString()[0];
        }

        private static char GetRandomUpperCaseLetter() => GetRandomLetter(min: 'A', max: 'Z');

        private static char GetRandomLowerCaseLetter() => GetRandomLetter(min: 'a', max: 'z');

        private static char GetRandomLetter(char min, char max)
        {
            var ramdom = new Random();
            return (char) ramdom.Next(min, max);
        }


        private static bool IsValid(string[] args)
        {

            if (args.Length != 2) return false;

            if (args.Length == 2)
            {
                string characterNumber = args[0];
                foreach (var character in characterNumber)
                {
                    if (!char.IsDigit(character)) return false;
                }
            }

            var lengthStr = args[0];
            var options = args[1];



            //foreach (var character in options)
            //{
            //    if (character != 'l'
            //        && character != 'L'
            //        && character != 'd'
            //        && character != 's')
            //    {
            //        return false;
            //    }
            //}

            if (options.Any(character => character != 'l'
                                         && character != 'L'
                                         && character != 'd'
                                         && character != 's'))
            {
                return false;
            }

            //foreach (var character in lengthStr)
            //{
            //    if (char.IsDigit(character))
            //    {
            //        return false;
            //    }
            //}

            return lengthStr.All(char.IsDigit);
        }

        private static void Helptext()
        {
            Console.WriteLine("PasswordGenerator");
            Console.WriteLine("Options:");
            Console.WriteLine(" - l = lower case letter");
            Console.WriteLine(" - L = upper case letter");
            Console.WriteLine(" - d = digit");
            Console.WriteLine(" - s = special character(!\"#¤%&/(){}[])");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special characters");
            Console.WriteLine("         Min. 2 digits");
        }
    }
}
