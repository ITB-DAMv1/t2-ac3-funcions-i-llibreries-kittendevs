namespace TestingCodeTeam3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Constants Utilitzades
            const int MinAvatarNum = 1;
            const int MaxAvatarNum = 4;
            const int MinUserChar = 2;
            const int MaxUserChar = 25;
            const int MaxEvilNum = 50000; // Tenian las variables al reves
            const int MinEvilNum = 1000; // Esta por ejemlo era la max, en vez de la min
            const string InsertCharacterNumTxt = "Insereix el numero de selecció: [1-4]";
            const string InsertCharacterUsernameTxt = "Insereix el nom del personatje: llargada[2-25]";
            const string InsertEvilTxt = "Insereix el nivell de maldat: [1000-50000]";

            //Variables Utilitzades
            string userName = "";
            int avatarNum = 0;
            int maliceNum = 0;
            int avatarMalice = 0;
            int personDust = 0;
            int personMalice = 0;
            int vowelsNum = 0;
            bool isTwoVowels = false;


            // Funcion para escoger Avatar
            Console.WriteLine(InsertCharacterNumTxt);
            avatarNum = UserNumInput(MinAvatarNum, MaxAvatarNum);

            // Funcion para escribir nombre Usuario
            Console.WriteLine(InsertCharacterUsernameTxt);
            userName = UserStringInput(MinUserChar, MaxUserChar);

            // Funcion para escoger maldad
            Console.WriteLine(InsertEvilTxt);
            maliceNum = UserNumInput(MinEvilNum, MaxEvilNum);

            // Funcio per comprovar si hi han 2 o mes vocal en un String
            CheckVowels(ref isTwoVowels, ref userName, ref vowelsNum);

            // Funcio on ocorre la magia
            ConvertToMagicDust(maliceNum, ref personDust, ref avatarMalice, ref isTwoVowels, ref personMalice);
        }


        // Funcion para Inputs de Usuario tipo Int
        public static int UserNumInput(int min, int max) // SUPERMEGA UTIL FUNCIO
        {
            string MsgInvalidNum = $"Invalid Number, Try again..\nI only accept numbers within the range: {min} - {max}";
            int userNum;
            bool chekUserNum = int.TryParse(Console.ReadLine(), out userNum);

            while (!chekUserNum || (userNum < min || userNum > max))
            {
                Console.WriteLine(MsgInvalidNum);
                chekUserNum = int.TryParse(Console.ReadLine(), out userNum);
            }
            return userNum;
        }

        // Funcion para Inputs de Usuario tipo String
        public static string UserStringInput(int min, int max)
        {
            string MsgInvalidString = $"Invalid String, Try again..\n";
            string userString;
            userString = Console.ReadLine();
            bool chekUserString = CharacterSpecial(userString);


            while (chekUserString || (userString.Length < min || userString.Length > max))
            {
                Console.WriteLine(MsgInvalidString);
                userString = Console.ReadLine();
                chekUserString = CharacterSpecial(userString);
            }
            return userString;
        }

        // Funcio per comprovar que no hagin caracters estranys en un String
        public static bool IsSpecialCharacter(char c)
        {
            // Definimos los caracteres permitidos como una cadena
            string allowedChars = "abcdefghijklmnopqrstuvwxyz0123456789";

            // Verificamos si el carácter no está en la cadena
            return !allowedChars.Contains(c);
        }

        public static bool CharacterSpecial(string userName)
        {
            // Convertimos a minúsculas
            userName = userName.ToLower();

            // Recorremos cada carácter en el nombre de usuario
            foreach (char c in userName)
            {
                if (IsSpecialCharacter(c))
                    return true; // Encontrado carácter especial
            }

            return false; // No se encontraron caracteres especiales
        }

        // Funcio per comprovar si hi han 2 o mes vocal en un String
        public static void CheckVowels(ref bool twoVowels, ref string userName, ref int vowels)
        {
            foreach (char c in userName.ToLower())
            {
                switch (c)
                {
                    case 'a':
                        vowels = vowels + 1;
                        break;
                    case 'e':
                        vowels = vowels + 1;
                        break;
                    case 'i':
                        vowels = vowels + 1;
                        break;
                    case 'o':
                        vowels = vowels + 1;
                        break;
                    case 'u':
                        vowels = vowels + 1;
                        break;
                }
            }
            //era una cadena de else ifs
            if (vowels >= 2) twoVowels = true;
        }

        // Funcio on ocorre la magia
        private static void ConvertToMagicDust(int malice, ref int personDust, ref int avatarMalice, ref bool twoVowels, ref int personMalice)
        {
            if (twoVowels == true)
            {
                avatarMalice = malice % 4;
                personDust = malice / 4;
                Console.WriteLine($"Es repart {personDust} pols magica per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}"); //Original pseudocode didn't print
            }
            else
            {
                avatarMalice = malice / 10 * 8;
                personMalice = malice / 20;
                Console.WriteLine($"Es repart {personMalice} maldat per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}"); //Original pseudocode didn't print
            }
        }
    }
}
