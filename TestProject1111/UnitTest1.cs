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
            Assert.AreEqual();
           
            //Assert.(gameLogic.RestartValues())
            // ����� ������� ���� ������
            // ������ ������� � �������� ������
            // ������ ������� ��� ����
            // �������� �� �������� ���������� ����� 6 �����
            // �������� �� �� �������� ���������� ����� 6 �����
        }
    }
}