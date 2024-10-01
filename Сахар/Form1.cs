namespace Сахар
{
    public partial class Form1 : Form
    {
        private GameType gameType;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameType = GameType.PvsC;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameType = GameType.PvsP;
        }
    }

    public enum GameType
    {
        PvsP,
        PvsC
    }
}