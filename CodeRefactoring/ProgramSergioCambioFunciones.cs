//namespace t2_ac3_funcions_i_llibreries_team3;
using System;


namespace TestingCodeTeam3 
{
    class ActThreeGroupThreeCsMain
    {
        static void Main(string[] args)
        {
            const int MinCharNum = 1;
            const int MaxCharNum = 4;
            const int MinCharUser = 2;
            const int MaxCharUser = 25;
            const int MaxEvil = 1000;
            const int MinEvil = 50000;
            const string InsertCharacterNumTxt = "Insereix el numero de selecció: [1-4]";
            const string InsertCharacterUsernameTxt = "Insereix el nom del personatje: llargada[2-25]";
            const string InsertEvilTxt = "Insereix el nivell de maldat: [1000-50000]";
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

            while (!(characterNum <= MaxCharNum && characterNum >= MinCharNum))//Range in original pseudocode was (!(characterNum >= MaxCharNum && characterNum <= MinCharNum))
            {
                if (!(int.TryParse(Console.ReadLine(), out characterNum)))
                {
                    characterNum = 0;
                    Console.WriteLine(Error);
                }
            }

            Console.WriteLine(InsertCharacterUsernameTxt);

            while (!(userName.Length >= MinCharUser && userName.Length <= MaxCharUser))//Range in original pseudocode was (!(userName.Length <= MinCharUser && userName.Length >= MaxCharUser))
            {
                userName = Console.ReadLine();

                if (CharacterSpecial(userName)) userName = "";
            }

            Console.WriteLine(InsertEvilTxt);

            while (!(malice <= MinEvil && malice >= MaxEvil))//Range in original pseudocode was (!(malice >= MinEvil && malice <= MaxEvil))
            {
                if (!(int.TryParse(Console.ReadLine(), out malice)))
                {
                    malice = 0;
                    Console.WriteLine(Error);
                }
            }
            //TODO
            CheckVowels(ref twoVowels, ref userName, ref vowels);

            if (twoVowels == true)
            {
                ConvertToMagicDust(malice, ref personDust, ref avatarMalice);
                Console.WriteLine($"Es repart {personDust} per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}"); //Original pseudocode didn't print
            }
            else
            {
                DividirMaldat( ref avatarMalice, in malice, twoVowels);
                Console.WriteLine($"Es repart {personMalice} per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}"); //Original pseudocode didn't print
            }
        }
       
            //Estas dos funciones las he cambiado para que solo devuelvan una cosa y sea más fácil hacer el Assert.También he elimanado la variable donde repartian la maldad, porque no es necesaria.
         public static void DividirMaldat( ref int avatarMalice, in int malice, bool twoVowels)
        {
            if (twoVowels)
            {
                avatarMalice = 0;
            }
            else
            {
                avatarMalice = avatarMalice - (malice * 5 / 10);
            }
        }
        static void ConvertToMagicDust(bool twoVowels, int malice, ref int personDust, ref int avatarMalice)
        {

            if (twoVowels)
            {
                personDust = avatarMalice/4;
            }
            else
            {
                personDust = (malice * 5 / 10)/4;

            }
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
    }

}