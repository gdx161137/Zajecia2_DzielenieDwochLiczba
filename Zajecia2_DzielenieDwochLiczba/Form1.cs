namespace Zajecia2_DzielenieDwochLiczba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double liczba1 = Convert.ToDouble(textBox1.Text);
                double liczba2 = Convert.ToDouble(textBox2.Text);
                if (liczba2 == 0)
                {
                    label_wynik.Text = "B��d: Dzielenie przez zero!";
                }
                else
                {
                    double wynik = liczba1 / liczba2;
                    label_wynik.Text = wynik.ToString();
                }
            }
            catch (FormatException)
            {
                label_wynik.Text = "B��d: Wprowadzono b��dne dane wej�ciowe (np znaki zamiast liczb) lub pozostawiono puste pole";
            }
            catch (DivideByZeroException)
            {
                label_wynik.Text = "B��d: Dzielenie przez zero";
            }
            catch (Exception ex)
            {
                label_wynik.Text = "B��d";
            }
        }
    }
}
