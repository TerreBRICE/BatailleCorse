using System;
namespace JeuDeCarte.UnitTests
{
    [TestClass]
    public class DistributionCarteTest
	{
        [TestMethod]
        public void WhenNewGameTHeTwoPlayerHasFiveDiffCards()
        {
            var game = new BatailleCorse();

            Assert.AreEqual(3, game.joueur1.NbElements);
            Assert.AreEqual(3, game.joueur2.NbElements);

        }
	}

}

