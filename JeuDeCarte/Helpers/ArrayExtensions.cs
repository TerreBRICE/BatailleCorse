using System;
using System.Linq;

namespace JeuDeCarte.Helpers
{
	public static class ArrayExtensions
	{
		public static string[] Shuffle(this string[] array)
		{
			var CopyArray = array.ToList().ToArray();
            var ResultArray =new List<string>();
            Random random = new Random();

			var index = 0;

			while(index < array.Length)
			{
                int randomIndex = random.Next(0, CopyArray.Length);

				ResultArray.Add(CopyArray[randomIndex]);

                CopyArray = CopyArray.Where((source, index) => index != randomIndex).ToArray();

				index++;
            }

	
            return ResultArray.ToArray();
		}
	}
}

