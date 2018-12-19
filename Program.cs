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
            string sexe = Console.ReadLine();

            if (age >= 18)
            {
                if (sexe == "homme")
                {
                    Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
                }
                else
                {
                    if (sexe == "femme")
                        Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeure.");
                    else
                        Console.WriteLine("Il y a une erreur dans la saisie.");
                }
            }
            else
            {
                if (sexe == "homme")
                {
                    Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
                }
                else
                {
                    if (sexe == "femme")
                        Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineure.");
                    else
                        Console.WriteLine("Il y a une erreur dans la saisie.");
                }
            }
                
        }
    }
}
