using System;
using System.Numerics;
public class Program
{
    const string PickAvatarTxt = "Escull un avatar entre [1-4]";
    const string InvalidAvatarTxt = "Opció incorrecta, intenta-ho un altre cop";
    const string ChoseeNameTxt = "Escriu un nom per a l'avatar(2-25 caràcters,sense caràcter especials):";
    const string InvalidNameeTxt = "Introdueix el nivell de maldat (1000 a 50000)";
    const string InvalidMalice = "Opció incorrecta, intenta-ho  un altre cop";
    const string TotalMaliceTxt = "El total de malicia es:";
    const string ModuleMaliceTxt = "i el restant es:";
    const string Vowels = "aeiou";

    string name = "";
    int userMalice = 0;
    public static void Main()
    {
        

        ChooseAvatar():
        ChooseNameAvatar(name);
        ChooseMalice(userMalice);
        DistributeMalice(userMalice, name);
    }
    public static void ChooseAvatar()
    {
        bool validAvatar = false;
        int userAvatar = 0;

        while (!validAvatar)
        {
            Console.WriteLine(PickAvatarTxt);
            userAvatar=int.Parse(Console.ReadLine());

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
}