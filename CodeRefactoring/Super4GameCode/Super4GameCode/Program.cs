namespace Super4MainCode
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
            double avatarMalice = 0;
            double personDust = 0;
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
            WriteFinalAnswer(maliceNum, ref personDust, ref avatarMalice, ref isTwoVowels);
        }


        // Funcion para Inputs de Usuario tipo Int
        public static int UserNumInput(int min, int max) // SUPERMEGA UTIL FUNCIO
        {
            string MsgInvalidNum = $"Invalid Number, Try again..\nI only accept numbers within the range: {min} - {max}";
            int userNum;
            bool chekUserNum = int.TryParse(Console.ReadLine(), out userNum);

            while (!chekUserNum || IntIsInRange(min, max, userNum))
            {
                Console.WriteLine(MsgInvalidNum);
                chekUserNum = int.TryParse(Console.ReadLine(), out userNum);
            }
            return userNum;
        }

        public static bool IntIsInRange(int min, int max, int userNum)
        {
            return (userNum < min || userNum > max);
        }



        // Funcion para Inputs de Usuario tipo String
        public static string UserStringInput(int min, int max)
        {
            string MsgInvalidString = $"Invalid String, Try again..\n";
            string userString;
            userString = Console.ReadLine();
            bool chekUserString = CharacterSpecial(userString);


            while (chekUserString || StringIsInRange(min, max, userString))
            {
                Console.WriteLine(MsgInvalidString);
                userString = Console.ReadLine();
                chekUserString = CharacterSpecial(userString);
            }
            return userString;
        }

        public static bool StringIsInRange(int min, int max, string userString)
        {
            return (userString.Length < min || userString.Length > max);
        }

        // Funcio per comprovar que no hagin caracters estranys en un String
        static public bool IsSpecialCharacter(char c)
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


        public static void DividirMaldat(ref double avatarMalice, in double maliceNum, bool isTwoVowels)
        {
            if (isTwoVowels)
            {
                avatarMalice = 0;
            }
            else
            {
                avatarMalice = maliceNum - (maliceNum * 5 / 100);
            }
        }
        public static double ConvertToMagicDust(double maliceNum)
        {
            return maliceNum / 4;

        }
        public static double ConvertToMagicDust(double maliceNum, int percent)
        {

            return (maliceNum * percent / 100) / 4;
        }

        // Funcio on ocorre la magia
        private static void WriteFinalAnswer(double maliceNum, ref double personDust, ref double avatarMalice, ref bool isTwoVowels)
        {
            if (isTwoVowels)
            {
                personDust = ConvertToMagicDust(maliceNum);
                DividirMaldat(ref avatarMalice, maliceNum, isTwoVowels);

                Console.WriteLine($"Es repart {personDust} pols magica per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}"); //Original pseudocode didn't print
            }
            else
            {
                personDust = ConvertToMagicDust(maliceNum, 5);
                DividirMaldat(ref avatarMalice, maliceNum, isTwoVowels);

                Console.WriteLine($"Es repart {personDust} de pols màgica per cada membre de l'equip i et queda un nivell de maldad de {avatarMalice}"); //Original pseudocode didn't print
            }
        }
    }
}