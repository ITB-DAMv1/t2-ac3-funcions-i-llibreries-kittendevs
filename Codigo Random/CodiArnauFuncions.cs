using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Program
    {
        // CANVI
        const string InsertEvilTxt = "Insereix el nivell de maldat: [1000-50000]";
        const string InsertCharacterUsernameTxt = "Insereix el nom del personatje: llargada[2-25]";
        // ----
        static void Main(string[] args)
        {
            const int MinCharNum = 1;
            const int MaxCharNum = 4;
            const int MinCharUser = 2;
            const int MaxCharUser = 25;
            const int MaxEvil = 1000;
            const int MinEvil = 50000;
            const string InsertCharacterNumTxt = "Insereix el numero de selecció: [1-4]";
            const string Error = "Valor no valid";

            string userName = "";
            int characterNum = 0;
            int malice = 0;
            int avatarMalice = 0;
            int personDust = 0;
            int personMalice = 0;

            int vowels = 0;
            bool twoVowels = false;

            Console.WriteLine(InsertCharacterNumTxt);

            while (!(characterNum <= MaxCharNum && characterNum >= MinCharNum))
            {
                if (!(int.TryParse(Console.ReadLine(), out characterNum)))
                {
                    characterNum = 0;
                    Console.WriteLine(Error);
                }
            }
            // CANVI
            CharacterUsername(ref userName, MinCharUser, MaxCharUser);

            MaliceInRange(ref malice, MinEvil, MaxEvil);

            CheckVowels(ref twoVowels, ref userName, ref vowels);
            // -----

            if (twoVowels == true)
            {
                ConvertToMagicDust(malice, ref personDust, ref avatarMalice);
                Console.WriteLine($"Es repart {personDust} per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}");
            }
            else
            {
                DividirMaldat(ref personMalice, ref avatarMalice, in malice);
                Console.WriteLine($"Es repart {personMalice} per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}");
            }
        }
        // CANVI
        public static void MaliceInRange(ref int malice, int minRange, int maxRange)
        {
            Console.WriteLine(InsertEvilTxt);
            while (!(malice <= minRange && malice >= maxRange))
            {
                ReadMalice(ref malice);
            }
        }
        public static void ReadMalice(ref int malice)
        {
            if (!(int.TryParse(Console.ReadLine(), out malice)))
            {
                malice = 0;
                throw new Exception();
            }
        }
        public static void CharacterUsername(ref string userName, int minLength, int maxLength)
        {
            Console.WriteLine(InsertCharacterUsernameTxt);
            while (!(userName.Length >= minLength && userName.Length <= maxLength))
            {
                ReadCharacterUsername(ref userName);
            }
        }
        public static void ReadCharacterUsername(ref string userName)
        {
            userName = Console.ReadLine();

            if (CharacterSpecial(userName)) userName = "";
        }
        // ----
        public static void DividirMaldat(ref int personMalice, ref int avatarMalice, in int malice)
        {
            avatarMalice = malice / 10 * 8;
            personMalice = malice / 20;
        }

        static public bool CharacterSpecial(string userName)
        {
            userName = userName.ToLower();
            for (int i = 0; i < userName.Length; i++)
            {
                if (!(userName[i] == 'a' ||
                    userName[i] == 'b' ||
                    userName[i] == 'c' ||
                    userName[i] == 'd' ||
                    userName[i] == 'e' ||
                    userName[i] == 'f' ||
                    userName[i] == 'g' ||
                    userName[i] == 'h' ||
                    userName[i] == 'i' ||
                    userName[i] == 'j' ||
                    userName[i] == 'k' ||
                    userName[i] == 'l' ||
                    userName[i] == 'm' ||
                    userName[i] == 'n' ||
                    userName[i] == 'o' ||
                    userName[i] == 'p' ||
                    userName[i] == 'q' ||
                    userName[i] == 'r' ||
                    userName[i] == 's' ||
                    userName[i] == 't' ||
                    userName[i] == 'u' ||
                    userName[i] == 'v' ||
                    userName[i] == 'w' ||
                    userName[i] == 'x' ||
                    userName[i] == 'y' ||
                    userName[i] == 'z' ||
                    userName[i] == '0' ||
                    userName[i] == '1' ||
                    userName[i] == '2' ||
                    userName[i] == '3' ||
                    userName[i] == '4' ||
                    userName[i] == '5' ||
                    userName[i] == '6' ||
                    userName[i] == '7' ||
                    userName[i] == '8' ||
                    userName[i] == '9'))
                {
                    return true;
                }
            }
            return false;
        }
        public static void CheckVowels(ref bool twoVowels, ref string userName, ref int vowels)
        {
            foreach (char c in userName.ToLower())
            {
                if (c == 'a')
                    vowels = vowels + 1;
                else if (c == 'e')
                    vowels = vowels + 1;
                else if (c == 'i')
                    vowels = vowels + 1;
                else if (c == 'o')
                    vowels = vowels + 1;
                else if (c == 'u')
                    vowels = vowels + 1;
            }
            if (vowels >= 2) twoVowels = true;
        }
        public static void ConvertToMagicDust(int malice, ref int personDust, ref int avatarMalice)
        {

            avatarMalice = malice % 4;

            personDust = malice / 4;
        }
    }
}