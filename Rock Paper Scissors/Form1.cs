namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        int Rock = 0;
        int Paper = 1;
        int Scissors = 2;

        int Wins;
        int Losses;
        int Ties;

        int Choice = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Rock
            Choice = Rock;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Paper
            Choice = Paper;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Scissors
            Choice = Scissors;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Opponent = Random.Shared.Next(Rock, Scissors + 1);

            if (Opponent == Rock) // motståndarens val
            {
                label4.Text = "Rock";
            }
            else if (Opponent == Paper)
            {
                label4.Text = "Paper";
            }
            else if (Opponent == Scissors)
            {
                label4.Text = "Scissors";
            }

            if (Opponent == Rock && Choice == Paper) // Kollar om du vinner
            {
                Wins++;
            }
            else if (Opponent == Paper && Choice == Scissors)
            {
                Wins++;
            }
            
            if (Opponent == Rock && Choice == Scissors) // Kollar om du förlorar
            {
                Losses++;
            }
            else if (Opponent == Scissors && Choice == Paper)
            {
                Losses++;
            }

            if (Opponent == Choice) // Kollar om ni tar samma
            {
                Ties++;
            }

            // Skriver ut resultaten
            label1.Text = "Wins: " + Wins.ToString();
            label2.Text = "Losses: " + Losses.ToString();
            label3.Text = "Ties: " + Ties.ToString();
        }
    }
}
