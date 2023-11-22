using Knihovna;
using System.Text;

namespace AppKnihovna1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Zobraz(string s, ListBox listbox1)
        {
            StringBuilder slovo = new StringBuilder();
            foreach (char znak in s)
            {

                if (znak==' ')
                {
                    listbox1.Items.Add(slovo.ToString());
                    slovo=slovo.Clear();
                }
                else
                {
                    slovo.Append(znak);
                }
                
            }
            listbox1.Items.Add(slovo.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int[] pole = Pole.Nacti(5);
            for (int i = 0; i < pole.Length; i++)
            {
                listBox1.Items.Add(pole[i]); // natoèit cyklem
            }
            string vstupniText = textBox1.Text;

            string upravenyText = Pole.Smaz(vstupniText);
            MessageBox.Show(upravenyText);
            Zobraz(upravenyText, listBox2);

        }
    }
}