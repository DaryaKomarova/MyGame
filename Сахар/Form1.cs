using System.Media;

namespace Сахар
{
    public partial class Form1 : Form
    {
        private GameType gameType;
        private Logic logic;
        private Button[,] buttons = new Button[3, 3];

        public Form1()
        {
            InitializeComponent();
            buttons[0, 0] = _1_1;
            buttons[0, 1] = _1_2;
            buttons[0, 2] = _1_3;
            buttons[1, 0] = _2_1;
            buttons[1, 1] = _2_2;
            buttons[1, 2] = _2_3;
            buttons[2, 0] = _3_1;
            buttons[2, 1] = _3_2;
            buttons[2, 2] = _3_3;
            //очистка текста
            logic = new Logic();
            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameType = GameType.PvsC;
            RestartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameType = GameType.PvsP;
            RestartGame();
        }
        // сделать ходы

        private void MakeTurn(int i, int j)
        {
            label1.Text = $"Ход игрока - {logic.Turn.ToString()}"; //Указываем того, кто ходит
            logic.MakeTurn(i, j); //ходим на эту клетку
            ReloadValues();//Перезагружаем все значения
            if (logic.CheckWin(logic.Turn)) //проверяем, выиграли ли мы
            {
                label1.Text = $"Игрок {logic.Turn.ToString()} выиграл!";
                StopGame();
            }
        }

        private void StopGame()
        {
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void RestartGame()
        {
            foreach (var button in buttons)
            {
                //делаем работающими кнопки и убираем текст на них
                button.Enabled = true;
                button.Text = string.Empty;
            }
            logic.RestartValues();
        }

        public void ReloadValues()
        {
            Value[,] values = logic.BoardValues;
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (values[i,j] == Value.empty)
                    {
                        buttons[i, j].Text = string.Empty;
                        continue;
                    }
                    buttons[i, j].Text = values[i, j].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeTurn(0, 0);//если прав у,не нет х, для очер
            _1_1.Enabled = false;
        }

        private void _1_2_Click(object sender, EventArgs e)
        {
            MakeTurn(0, 1);
            _1_2.Enabled = false;
        }

        private void _1_3_Click(object sender, EventArgs e)
        {
            MakeTurn(0, 2);
            _1_3.Enabled = false;
        }

        private void _2_1_Click(object sender, EventArgs e)
        {
            MakeTurn(1, 0);
            _2_1.Enabled = false;
        }

        private void _2_2_Click(object sender, EventArgs e)
        {
            MakeTurn(1, 1);
            _2_2.Enabled = false;
        }

        private void _2_3_Click(object sender, EventArgs e)
        {
            MakeTurn(1, 2);
            _2_3.Enabled = false;
        }

        private void _3_1_Click(object sender, EventArgs e)
        {
            MakeTurn(2, 0);
            _3_1.Enabled = false;
        }

        private void _3_2_Click(object sender, EventArgs e)
        {
            MakeTurn(2, 1);
            _3_2.Enabled = false;
        }

        private void _3_3_Click(object sender, EventArgs e)
        {
            MakeTurn(2, 2);
            _3_3.Enabled = false;
        }
    }
    public enum GameType
    {
        PvsP,
        PvsC
    }
    public enum Value
    {
        O, X, empty
    }
}
