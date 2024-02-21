using System;
using nombre_demander;

namespace generateur_mot_passe
{
    
    class program
    {
        

        static void Main(string[] args) 
        {
            const int NB_MOT_DE_PAPSSE = 10;
            
            // 1 Demander la longeur du mdp (demander Nombre)
            int longueurMotDePasse = Outils.DemandeNombrePositifNonNul("Longueur du mot de passe:");
            int choixAlpha = Outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                "1- Uniquement des caractères en minuscules\n" +
                "2- Des caractères minuscules et majuscules\n" +
                "3- Des caractères et des chiffres\n" +
                "4- Caractères, chiffres et caractères spéciaux \n" +
                "Votre choix : ", 1, 4);

            string minuscules = "abcdefghijklmnopqrstuvwxyz";

            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractSpeciaux = "&#+-_!?./)({}|";
            string alphabet;
            string motDePasse = "";
            
            
           
            Random rand = new Random();

            if (choixAlpha == 1)
            {
                alphabet = minuscules;
            }
            else if (choixAlpha == 2)
            {
                alphabet = minuscules + majuscules;
            }
            else if (choixAlpha == 3)
            {
                alphabet = minuscules + majuscules + chiffres;
            }
            else
            {
                alphabet = minuscules + majuscules + chiffres + caractSpeciaux;
            }
            
            int longeurAlpha = alphabet.Length;

            for (int x = 0; x < NB_MOT_DE_PAPSSE; x++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longeurAlpha);
                    motDePasse += alphabet[index];
                }


                Console.WriteLine("Mot de passe : " + motDePasse);
            }
      
        }

    }
}