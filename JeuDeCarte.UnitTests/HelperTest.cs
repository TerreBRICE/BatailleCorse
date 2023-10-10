using System;
using JeuDeCarte.Helpers;
namespace JeuDeCarte.UnitTests
{
	[TestClass]
	public class HelperTest
	{
        [TestMethod]
        public void Shuffle_Test()
		{
			var array = new string[] { "1", "2", "3", "4" , "5", "6" , "7" , "8" , "9" , "10"};

			var shuffledArray = array.Shuffle();

			CollectionAssert.AreNotEqual(array, shuffledArray);
			Assert.AreEqual(array.Length, shuffledArray.Length);

        }
	}
}

