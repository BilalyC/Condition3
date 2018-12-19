using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veillez taper votre âge :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Veillez indiquer votre sexe (homme ou femme) :");
            string gender = Console.ReadLine();

            if (age >= 18 && age < 120)
            {
                switch (gender)
                {
                    case "homme":
                        Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
                        break;
                    case "femme":
                        Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeure.");
                        break;
                    default:
                        Console.WriteLine("Il y a une erreur dans la saisie du sexe.");
                        break;
                }
            }
            else if (age > 0 && age < 18)
            {
                switch (gender)
                {
                    case "homme":
                        Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
                        break;
                    case "femme":
                        Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineure.");
                        break;
                    default:
                        Console.WriteLine("Il y a une erreur dans la saisie du sexe.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Il y a une erreur dans l'age.");
            }
        }
    }
}