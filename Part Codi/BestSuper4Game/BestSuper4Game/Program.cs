using System;

namespace BestSuper4Game
{
    public class Program
    {
        const string PickAvatarTxt = "Escull un avatar entre [1-4]";
        const string InvalidAvatarTxt = "Opció incorrecta, intenta-ho un altre cop";
        const string ChooseNameTxt = "Escriu un nom per a l'avatar(2-25 caràcters,sense caràcter especials):";
        const string ChooseMaliceTxt = "Introdueix el nivell de maldat (1000 a 50000)";
        const string InvalidNameTxt = "El nom no és valid";
        const string InvalidMaliceTxt = "Opció incorrecta, intenta-ho  un altre cop";
        const string TotalMaliceTxt = "El total de malicia es: ";
        const string ModuleMaliceTxt = " i el restant es: ";
        const string Vowels = "aeiou";


        public static void Main()
        {
            string name = "";
            double userMalice = 0;

            ChooseAvatar();
            ChooseNameAvatar(ref name);
            ChooseMalice(ref userMalice);
            DistributeMalice(userMalice, ref name);
        }
        public static void ChooseAvatar()
        {
            bool validAvatar = false;
            int userAvatar = 0;

            while (!validAvatar)
            {
                Console.WriteLine(PickAvatarTxt);
                userAvatar = int.Parse(Console.ReadLine());

                if (userAvatar >= 1 && userAvatar <= 4)
                {
                    validAvatar = true;
                }
                else
                {
                    Console.WriteLine(InvalidAvatarTxt);
                }
            }

        }
        public static void ChooseNameAvatar(ref string name)
        {
            bool validName = false;
            // ERROR

            while (!validName)
            {
                Console.WriteLine(ChooseNameTxt);
                name = Console.ReadLine(); // ERROR,TUBIMOS QUE CAMBIAR LA VARIABLE MU MAL
                if (name.Length >= 2 && name.Length <= 25)
                {
                    validName = true;
                }
                else
                {
                    Console.WriteLine(InvalidNameTxt);
                }
            }
        }
        public static void ChooseMalice(ref double userMalice)
        {
            bool validMalice = false;
            // ERROR
            userMalice = 0;

            while (!validMalice)
            {
                Console.WriteLine(ChooseMaliceTxt);
                // ERROR
                userMalice = double.Parse(Console.ReadLine());
                if (userMalice >= 1000 && userMalice <= 50000)
                {
                    validMalice = true;
                }
                else
                {
                    Console.WriteLine(InvalidMaliceTxt);
                }
            }
        }
        public static void DistributeMalice(double userMalice, ref string name)
        {
            bool vowelsValid = false;
            double maliceModule = 0;
            // ERROR
            double reducedMalice = userMalice * 0.05;

            Checkvowels(ref vowelsValid, ref name);

            if (vowelsValid)
            {
                maliceModule = userMalice % 4;
                userMalice = userMalice / 4;

                Console.WriteLine(TotalMaliceTxt + userMalice + ModuleMaliceTxt + maliceModule);
            }
            else
            {
                maliceModule = reducedMalice % 4;
                reducedMalice = reducedMalice / 4;
                userMalice = userMalice * 0.95;
                maliceModule = userMalice + maliceModule;

                Console.WriteLine(TotalMaliceTxt + reducedMalice + ModuleMaliceTxt + maliceModule);
            }
        }
        public static void Checkvowels(ref bool vowelsValid, ref string name)
        {
            int count = 0;
            name = name.ToLower();
            for (int i = 0; i < name.Length; i++)
            {
                // ERROR
                if ((name[i]) == Vowels[0] || (name[i]) == Vowels[1] || (name[i]) == Vowels[2] || (name[i]) == Vowels[3] || (name[i]) == Vowels[4])
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                vowelsValid = true;
            }
        }
    }
}
