using System;
namespace JeuDeCarte
{
	public class Maillon<T> where T: class
	{
		
		public Maillon(T value, Maillon<T> suivant)
		{
            Value = value;
            Suivant = suivant;
        }

        public T Value { get; }
        public Maillon<T> Suivant { get; set; }
    }
}

