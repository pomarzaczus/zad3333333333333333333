namespace test3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            wczytaj = new Button();
            usun = new Button();
            zapisz = new Button();
            dataGridView1 = new DataGridView();
            dodaj = new Button();
            ID = new DataGridViewTextBoxColumn();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            Wiek = new DataGridViewTextBoxColumn();
            Stanowisko = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // wczytaj
            // 
            wczytaj.Location = new Point(75, 384);
            wczytaj.Name = "wczytaj";
            wczytaj.Size = new Size(75, 23);
            wczytaj.TabIndex = 0;
            wczytaj.Text = "wczytaj";
            wczytaj.UseVisualStyleBackColor = true;
            // 
            // usun
            // 
            usun.Location = new Point(613, 284);
            usun.Name = "usun";
            usun.Size = new Size(75, 23);
            usun.TabIndex = 2;
            usun.Text = "usun";
            usun.UseVisualStyleBackColor = true;
            // 
            // zapisz
            // 
            zapisz.Location = new Point(342, 384);
            zapisz.Name = "zapisz";
            zapisz.Size = new Size(75, 23);
            zapisz.TabIndex = 3;
            zapisz.Text = "zapisz";
            zapisz.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Imie, Nazwisko, Wiek, Stanowisko });
            dataGridView1.Location = new Point(37, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(420, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(613, 156);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(75, 23);
            dodaj.TabIndex = 5;
            dodaj.Text = "dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 30;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imie";
            Imie.Name = "Imie";
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.Name = "Nazwisko";
            // 
            // Wiek
            // 
            Wiek.HeaderText = "Wiek";
            Wiek.Name = "Wiek";
            Wiek.Width = 40;
            // 
            // Stanowisko
            // 
            Stanowisko.HeaderText = "Stanowisko";
            Stanowisko.Name = "Stanowisko";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dodaj);
            Controls.Add(dataGridView1);
            Controls.Add(zapisz);
            Controls.Add(usun);
            Controls.Add(wczytaj);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button usun;
        private Button wczytaj;
      
        private Button zapisz;
        private DataGridView dataGridView1;
        private Button dodaj;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn Wiek;
        private DataGridViewTextBoxColumn Stanowisko;
    }
}