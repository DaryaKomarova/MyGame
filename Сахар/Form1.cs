using System.Media;

namespace Сахар
{
    public partial class Form1 : Form
    {
        private GameType gameType;
        private Value[,] boardValues = new Value[3, 3];
        private Button[,] buttons = new Button[3, 3];
        private bool turn;

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
            foreach (var text in buttons)
            {
                text.Text = "";
            }
            //обнуляем значение
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    boardValues[i, j] = Value.empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameType = GameType.PvsC;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameType = GameType.PvsP;
        }
        // сделать ходы
        private void MakeTurn(int i, int j, Value value)
        {
            buttons[i, j].Text = value.ToString();
            boardValues[i, j] = value;
            turn = !turn;
            CheckWin(value);
        }

        private void CheckWin(Value value)
        {
            for (int stroka = 0; stroka < 3; stroka++)
            {
                if (boardValues[stroka, 0] == value &&
                    boardValues[stroka, 1] == value &&
                    boardValues[stroka, 2] == value)
                {
                    label1.Text = value.ToString() + " - w1n!!!";
                }
            }
            for (int stolbec = 0; stolbec < 3; stolbec++)
            {
                if (boardValues[0, stolbec] == value &&
                    boardValues[1, stolbec] == value &&
                    boardValues[2, stolbec] == value)
                {
                    label1.Text = value.ToString() + " - w1n!!!";
                }
            }
            if (boardValues[0, 0] == value &&
                    boardValues[1, 1] == value &&
                    boardValues[2, 2] == value)
            {
                label1.Text = value.ToString() + " - w1n!!!";
            }
            if (boardValues[0, 2] == value &&
                    boardValues[1, 1] == value &&
                    boardValues[2, 0] == value)
            {
                label1.Text = value.ToString() + " - w1n!!!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeTurn(0, 0, turn ? Value.L : Value.E);//если прав у,не нет х, для очер
            _1_1.Enabled = false;
        }

        private void _1_2_Click(object sender, EventArgs e)
        {
            MakeTurn(0, 1, turn ? Value.L : Value.E);
            _1_2.Enabled = false;
        }

        private void _1_3_Click(object sender, EventArgs e)
        {
            MakeTurn(0, 2, turn ? Value.L : Value.E);
            _1_3.Enabled = false;
        }

        private void _2_1_Click(object sender, EventArgs e)
        {
            MakeTurn(1, 0, turn ? Value.L : Value.E);
            _2_1.Enabled = false;
        }

        private void _2_2_Click(object sender, EventArgs e)
        {
            MakeTurn(1, 1, turn ? Value.L : Value.E);
            _2_2.Enabled = false;
        }

        private void _2_3_Click(object sender, EventArgs e)
        {
            MakeTurn(1, 2, turn ? Value.L : Value.E);
            _2_3.Enabled = false;
        }

        private void _3_1_Click(object sender, EventArgs e)
        {
            MakeTurn(2, 0, turn ? Value.L : Value.E);
            _3_1.Enabled = false;
        }

        private void _3_2_Click(object sender, EventArgs e)
        {
            MakeTurn(2, 1, turn ? Value.L : Value.E);
            _3_2.Enabled = false;
        }

        private void _3_3_Click(object sender, EventArgs e)
        {
            MakeTurn(2, 2, turn ? Value.L : Value.E);
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
        L, E, empty
    }
}
