using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace test3
{
    public partial class Form2 : Form
    {

        public class Test
        {
            public int ID { get; set; }
            public string? Imie { get; set; }
            public string? Nazwisko { get; set; }
            public int Wiek { get; set; }
            public string? Stanowisko { get; set; }
        }
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

        public void Add(string imie, string nazwisko, string wiek, string stanowisko)
        {
            dataGridView1.Rows.Add(index++, imie, nazwisko, wiek, stanowisko);
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedCells[0].RowIndex < index)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    index--;
                }
            }
            //int ss = dataGridView1.SelectedRows.Count;

            //usless
            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }
        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // Tworzenie nagłówka pliku CSV
            string csvContent = "ID,Imie,nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Pomijaj wiersze niemieszczące się w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne wartości w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawartości do pliku CSV
            File.WriteAllText(filePath, csvContent);
        }

        private void ExportToJSON(DataGridView dataGridView, string filePath)
        {
            // Tworzenie nagłówka pliku CSV
            string csvContent = "ID,Imie,nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            Test[] numbers = new Test[dataGridView.RowCount];
            int i = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Pomijaj wiersze niemieszczące się w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne wartości w wierszu, oddzielone przecinkami
                    object[] temp2 = Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value);
                    Test temp = new Test
                    {

                        ID = Int32.Parse(temp2[0].ToString()),
                        Imie = temp2[1].ToString(),
                        Nazwisko = temp2[2].ToString(),
                        Wiek = Int32.Parse(temp2[0].ToString()),
                        Stanowisko = temp2[2].ToString()
                    };


                    numbers[i] = temp;
                    //csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    //.ToArray(), c => c.Value)) + Environment.NewLine;
                    i++;
                }
            }
            string jsonString = JsonSerializer.Serialize(numbers);
            // Zapisanie zawartości do pliku CSV
            File.WriteAllText(filePath, jsonString);
        }


        private void zapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizację zapisu pliku CSV";
            saveFileDialog1.ShowDialog();
            // Jeśli użytkownik wybierze lokalizację i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // Użyj metody ExportToCSV i podaj obiekt DataGridView oraz ścieżkę do pliku CSV
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }
        }
        private void LoadCSVToDataGridView(string filePath)
        {
            // Sprawdź, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Odczytaj zawartość pliku CSV
            string[] lines = File.ReadAllLines(filePath);
            // Tworzenie tabeli danych
            DataTable dataTable = new DataTable();
            // Dodanie kolumn na podstawie nagłówka
            string[] headers = lines[0].Split(',');



            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                label1.Text = index.ToString() + values[1] + values[2] + values[3] + values[4];
                Add(values[1], values[2], values[3], values[4]);
                //dataGridView1.Rows.Add(values);
            }
            // Przypisanie tabeli danych do DataGridView

        }
        private void wczytaj_Click(object sender, EventArgs e)
        {
            // Wyświetlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Jeśli użytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywołanie funkcji wczytującej dane z pliku CSV
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void JSONzap_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki JSON (*)|*|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizację zapisu pliku JSON";
            saveFileDialog1.ShowDialog();
            // Jeśli użytkownik wybierze lokalizację i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // Użyj metody ExportToCSV i podaj obiekt DataGridView oraz ścieżkę do pliku CSV
                ExportToJSON(dataGridView1, saveFileDialog1.FileName);
            }
        }


        private void LoadJSONToDataGridView(string filePath)
        {
            // Sprawdź, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik JSON nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Odczytaj zawartość pliku CSV
            string[] lines = File.ReadAllLines(filePath);
            // Tworzenie tabeli danych
            
            DataTable dataTable = new DataTable();
            // Dodanie kolumn na podstawie nagłówka


            List<Test> temp = JsonSerializer.Deserialize<List<Test>>(lines[0]);

            // Dodawanie wierszy do tabeli danych
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i] != null)
                {
                    dataGridView1.Rows.Add(temp[i].ID, temp[i].Imie, temp[i].Nazwisko, temp[i].Wiek, temp[i].Stanowisko);

                }

            }
            // Przypisanie tabeli danych do DataGridView

        }
        private void JSONwczyt_Click(object sender, EventArgs e)
        {
            // Wyświetlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki JSON (*.JSON)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik JSON do wczytania";
            openFileDialog1.ShowDialog();
            // Jeśli użytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywołanie funkcji wczytującej dane z pliku CSV
                LoadJSONToDataGridView(openFileDialog1.FileName);
            }
        }
    }
}
