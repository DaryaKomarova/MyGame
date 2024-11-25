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
            //����� ����, ����� ����������
        }

        [Test]
        public void Test2()
        {
            //��������� ������ �� ��� ������
            gameLogic.RestartValues();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(gameLogic.BoardValues[i, j], null);//������ �� ������
                }
            }
            // ����� ������� ���� ������
            // ������ ������� � �������� ������
            // ������ ������� ��� ����
            // �������� �� �������� ���������� ����� 6 �����
            // �������� �� �� �������� ���������� ����� 6 �����
        }

        [Test]
        public void Test3()
        {
            //������ ������� � �������� ������
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
            //������ ����� �� ������� �����
            gameLogic.MakeTurn(3, 3);
            gameLogic.MakeTurn(-3, -1241231);
            gameLogic.MakeTurn(3, -3);
        }
    }
}