using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace nombre_demander
{
    static class Outils
    {
        public static int DemandeNombrePositifNonNul(string question)
        {

            /*int nombre = DemanderNombre(question);
            if (nombre > 0)
            {
                return nombre;
            }
            Console.WriteLine("ERREUR : le mot de passe ne peut pas être égale à 0;");
            
            

            return DemandeNombrePositifNonNul(question);*/
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }
        public static int DemanderNombreEntre(string question, int min, int max)
        {

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            else
            {
                Console.WriteLine("ERREUR : le nombre doit être compris entre " + min + " et " + max);
            }


            return DemanderNombreEntre(question, min, max);
        }
        static int DemanderNombre(string question)
        {

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;

                }
                catch
                {
                    Console.WriteLine("ERREUR !");

                }
            }

            return 0;
        }
    }
}
