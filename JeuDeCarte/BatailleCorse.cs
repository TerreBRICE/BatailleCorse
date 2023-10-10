using System;
using JeuDeCarte.Helpers;
namespace JeuDeCarte
{
	public class BatailleCorse
	{
		//public string[] allCards = new[] { "5", "6", "7", "8", "9", "10", "V", "D", "R", "A" };
        public string[] allCards = new[] { "5", "6", "7","V", "D", "R" };
        public EnsembleCartes joueur1 = new();
        public EnsembleCartes joueur2 = new();

        public BatailleCorse()
		{
            DistributionDesCartes();
        }

        private void DistributionDesCartes()
        {
            int index = 0;
            var shuffledCards = allCards.Shuffle();
            foreach (var card in shuffledCards)
            {
                if (index % 2 == 0)
                {
                    joueur1.AjouterALaFin(new Carte() { numero = shuffledCards[index] });
                }
                else
                {
                    joueur2.AjouterALaFin(new Carte() { numero = shuffledCards[index] });
                }
                index++;
            }
        }

		public void Jouer()
		{

		}




	}
}

