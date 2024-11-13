using System;
public class juegob4
{
    public static void ChooseAvatar()
    {
        //variables
        bool validAvatar = false;
        int userAvatar = 0;

        while (!validAvatar) {
            Console.WriteLine(PickAvatarTxt);
            userAvatar = int.Parse(Console.ReadLine());
            if ((userAvatar >= 1) && (userAvatar <= 4)) {
                validAvatar = true;
            }
            else
            {
                Console.WriteLine(InvalidAvatarTxt);
            }
        }



        public static void ChooseNameAvatar(ref string userName)
        {
            //variables
            bool validName = false;
            string userName = 0;

            while (!validName)
            {
                Console.WriteLine(ChooseNameTxt);
                userName = Console.ReadLine();
                if ((userName.Length >= 2) && (userName.Length <= 25)) {
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
            //variables
            bool validMalice = false;
            int userMalice = 0;

            while (!validMalice)
            {
                Console.WriteLine(ChooseMaliceTxt);
                userMalice = int.Parse(Console.ReadLine());
                if ((userMalice >= 1000) && (userMalice <= 50000)) {
                    validMalice = true;
                }
                else
                {
                    Console.WriteLine(InvalidMalice);
                }
            }
        }



        public static void DistributeMalice(int userMalice, string name)
        {
            //variables
            bool vowelsValid = false;
            int maliceModule = 0;
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
                reducedMalice = reducedMaliceMalice / 4;
                userMalice = userMalice * 0.95;
                maliceModule = userMalice + maliceModule;

                Console.WriteLine(TotalMaliceTxt + reducedMalice + ModuleMaliceTxt + maliceModule);
            }
        }
    }
}
