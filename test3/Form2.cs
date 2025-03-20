using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace test3
{
    public partial class Form2 : Form
    {
        int index = 0;
        public Form2()
        {
            InitializeComponent();



            // Inicjalizacja DataGridView

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Form1 xdd = new Form1(this);
            xdd.Show();
        }

        public void Add(string imie,  string nazwisko, string wiek,string stanowisko)
        {
            dataGridView1.Rows.Add(index++, imie, nazwisko, wiek, stanowisko);
        }
    }
}
