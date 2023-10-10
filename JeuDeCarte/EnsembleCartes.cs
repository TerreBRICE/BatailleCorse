using System;
namespace JeuDeCarte
{
	public class EnsembleCartes
	{
		private Maillon<Carte> Cartes;

		public int NbElements {
			get {
					if (Cartes == null)
						{
							return 0;
						}
					var index = 1;
					var curseur = Cartes;

					while (curseur.Suivant != null)
						{
							curseur = Cartes.Suivant;
							index++;
						}

					return index;
				}
		}

        public EnsembleCartes()
		{
		}

		public Carte GetPremiereCarte()
		{
			return Cartes.Value;
		}

		public void AjouterALaFin(Carte nouvelleCarte)
		{
			if (Cartes == null)
			{
                Cartes = new Maillon<Carte>(nouvelleCarte, null);
				return;
            }

			var curseur = Cartes;
			while (curseur.Suivant != null)
			{
				curseur = Cartes.Suivant;
			}

			curseur.Suivant = new Maillon<Carte>(nouvelleCarte, null);
		}
	}
}

