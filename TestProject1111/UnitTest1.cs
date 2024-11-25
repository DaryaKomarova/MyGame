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
            //ѕровер€ем пустые ли все €чейки
            gameLogic.RestartValues();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(gameLogic.BoardValues[i, j], null);//пуста€ ли €чейка
                }
            }
            // после очистки поле пустое
            // нельз€ сходить в непустую €чейку
            // нельз€ сходить вне пол€
            // проверка на победную комбинацию после 6 ходов
            // проверка на не победную комбинацию после 6 ходов
        }

        [Test]
        public void Test3()
        {
            //Ќельз€ сходить в непустую €чейку
            gameLogic.RestartValues();
            gameLogic.MakeTurn(2, 2);
            gameLogic.MakeTurn(2, 2);
            Assert.AreEqual(gameLogic.Turn, Value.O);
            gameLogic.MakeTurn(1, 2);
            gameLogic.MakeTurn(1, 2);
            Assert.AreEqual(gameLogic.Turn, Value.X);
        }

        [Test]
        public void Test4()
        {
            //Ќельз€ выйти за границы карты
            gameLogic.MakeTurn(3, 3);
            gameLogic.MakeTurn(-3, -1241231);
            gameLogic.MakeTurn(3, -3);
        }
    }
}