using Pokemon_Console_Game.Classes;
using static Pokemon_Console_Game.Classes.Pokemon;
namespace Unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pokemon Charizard = new Pokemon();

            Charizard.name = "Charizard";
            Charizard.health = 100;
            Charizard.damage = 10;

            Pokemon Bulbasaurus = new Pokemon();

            Bulbasaurus.name = "Bulbasaurus";
            Bulbasaurus.health = 100;
            Bulbasaurus.damage = 10;

            Attack(Bulbasaurus.damage, Charizard);

            Assert.AreEqual(Charizard.health, 90);
        }
    }
}