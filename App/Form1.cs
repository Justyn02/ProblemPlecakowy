using ProblemPlecakowy;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public int LiczbaPrzedmiotow;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int iloscPrzedmiotow))
            {
                LiczbaPrzedmiotow = iloscPrzedmiotow;

                textBox1.BackColor = Color.Green;
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.BackColor = DefaultBackColor;
            }
            else
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("WprowadŸ poprawn¹ liczbê przedmiotów.");
                textBox1.Clear();
            } 
        }
         

        public int Seed;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int seed))
            {
                Seed = seed;

                textBox2.BackColor = Color.Green;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.BackColor = DefaultBackColor;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                MessageBox.Show("WprowadŸ poprawn¹ liczbê przedmiotów i seed.");
                textBox2.Clear();
            }
        }



        public int Capacity;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int capacity))
            {
                Capacity = capacity;

                textBox3.BackColor = Color.Green;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox3.BackColor = DefaultBackColor;
            }
            else
            {
                textBox3.BackColor = Color.Red;
                MessageBox.Show("WprowadŸ poprawna pojemnosc.");
                textBox3.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LiczbaPrzedmiotow > 0 && Seed > 0 && Capacity >= 0)
            {
                Problem plecakowyProblem = new Problem(LiczbaPrzedmiotow, Seed);

                Result wynik = plecakowyProblem.Solve(Capacity);

                textBox5.Text = plecakowyProblem.ToString();
                textBox4.Text = wynik.ToString();

            }
            else
            {
                MessageBox.Show("WprowadŸ poprawn¹ liczbê przedmiotów i seed.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
