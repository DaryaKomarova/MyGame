using GameLibrary;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace TestProject1111
{
    public class Tests
    {
        Logic gameLogic;

        [SetUp]
        public void Setup()
        {
            gameLogic = new Logic();
        }

        [Test]
        public void TestNoWinAtStart()
        {
            gameLogic.RestartValues();
            Assert.IsFalse(gameLogic.CheckWin(Value.X));
            Assert.IsFalse(gameLogic.CheckWin(Value.O));
        }


        [Test]
        public void Test()
        {
            gameLogic.RestartValues();
            Assert.AreEqual(gameLogic.Turn, Value.X);
            gameLogic.MakeTurn(0, 0);
            Assert.AreEqual(gameLogic.Turn, Value.O);
            gameLogic.MakeTurn(0, 1);
            Assert.AreEqual(gameLogic.Turn, Value.X);
            //смена хода, смена переменной
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual();
           
            //Assert.(gameLogic.RestartValues())
            // после очистки поле пустое
            // нельзя сходить в непустую ячейку
            // нельзя сходить вне поля
            // проверка на победную комбинацию после 6 ходов
            // проверка на не победную комбинацию после 6 ходов
        }
    }
}