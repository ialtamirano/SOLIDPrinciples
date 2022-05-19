using SOLIDPrinciples._3.LSP;

namespace TestProject1
{
    [TestClass]
    public class LISKOVPrinciplesTest
    {
        [TestMethod]
        public void ProduceQuackSound()
        {
            Duck duck = new Duck();
            string quack = duck.Quack();
            Assert.AreEqual("Quack", quack, "produces Quack sound");
        }

        [TestMethod]
        public void MechanicalDuckProduceQuackSound()
        {
            MechanicalDuck duck = new MechanicalDuck();
            string quack = duck.Quack();
            Assert.AreEqual("Quack", quack, "produces Quack sound");
        }

        [TestMethod]
        public void FemaileDuckProduceQuackSound()
        {
            FemaleDuck duck = new FemaleDuck();
            string quack = duck.Quack();
            Assert.AreEqual("Quack", quack, "produces Quack sound");
        }
    }
}