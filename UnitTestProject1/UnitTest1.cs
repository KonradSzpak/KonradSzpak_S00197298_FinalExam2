using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KonradSzpak_S00197298_FinalExam2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game g1 = new Game()
            {
                Name = "It Takes Two",
                Platform = "PC, Xbox, PS, Switch",
                CriticScore = 88,
                Price = 69.99m,
                GameImage = "/images/ittakes2.jpg",
                Description = " From Hazelight comes It Takes Two an innovative co-op adventure where uniquely varied gameplay and emotional storytelling intertwine in a fantastical journey. Founded to push the creative boundaries of what's possible in games, Hazelight is the award-winning studio behind the critically acclaimed A Way Out and Brothers: A Tale of Two Sons."

               



            };

            decimal finalPrice = 62.991m;
            g1.DecreasePrice(.10);
            Assert.AreEqual(finalPrice, g1.Price);
        }
    }
}
