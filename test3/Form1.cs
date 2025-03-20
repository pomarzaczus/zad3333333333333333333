namespace test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string test22 = "";
        Form2 test;
        public Form1(Form2 xddd)
        {
            InitializeComponent();
            test = xddd;
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            test.Add(textBox1.Text, textBox2.Text, textBox3.Text, test22);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int test = listBox1.SelectedIndex;
            test22 = listBox1.Text;
            ;
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
