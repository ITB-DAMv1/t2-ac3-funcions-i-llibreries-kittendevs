using System;
namespace FuncionsLlibries{
    public class Funcionsllibreries
    {
        public static void ChooseNameAvatar(ref string userName)
        {
            bool validName = false;
            // ERROR
            string userName = "";

            while (!validName)
            {
                Console.WriteLine(ChooseNameTxt);
                userName = Console.ReadLine();
                if (userName.Length >= 2 && userName.Length <= 25)
                {
                    validName = true;
                }
                else
                {
                    Console.WriteLine(InvalidNameTxt);
                }
            }
        }
        public static void ChooseMalice(ref int userMalice)
        {
            bool validMalice = false;
            // ERROR
            int userMalice = 0;

            while (!validMalice)
            {
                Console.WriteLine(ChooseMaliceTxt);
                // ERROR
                userMalice = Console.ReadLine();
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
        public static void DistributeMalice(int userMalice, string name)
        {
            bool vowelsValid = false;
            int maliceModule = 0;
            // ERROR
            int reducedMalice = userMalice * 0.05;

            Checkvowels(vowelsValid, name);

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
        public static void Checkvowels(ref bool vowelsValid, string name)
        {
            int count = 0;

            for (int i = 0; i < name.Length; i++)
            {
                // ERROR
                if (ToLower(name[i]) == Vowels[0] || ToLower(name[i]) == Vowels[1] || ToLower(name[i]) == Vowels[2] || ToLower(name[i]) == Vowels[3] || ToLower(name[i]) == Vowels[4])
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