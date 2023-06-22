namespace Scuola_Gorilla
{
    partial class Gestione_Voti
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
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            CbxMateria = new ComboBox();
            label13 = new Label();
            label16 = new Label();
            LblMatricola = new Label();
            TxtMatricola = new TextBox();
            textBox12 = new TextBox();
            DgwVoti = new DataGridView();
            Materie = new DataGridViewTextBoxColumn();
            Voti = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgwVoti).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(CbxMateria);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(LblMatricola);
            panel1.Controls.Add(TxtMatricola);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 500);
            panel1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(32, 30, 45);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(111, 96);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(157, 28);
            comboBox2.TabIndex = 40;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 61, 61);
            label1.Location = new Point(3, 99);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 39;
            label1.Text = "Classe";
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(231, 61, 61);
            button3.Location = new Point(0, 376);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(286, 71);
            button3.TabIndex = 38;
            button3.Text = "Aggiungi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(286, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 37;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(231, 61, 61);
            button1.Location = new Point(0, 447);
            button1.Name = "button1";
            button1.Size = new Size(286, 53);
            button1.TabIndex = 35;
            button1.Text = "Rimuovi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(32, 30, 45);
            comboBox1.DropDownHeight = 75;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "", "1", "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5", "5.5", "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10" });
            comboBox1.Location = new Point(109, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 28);
            comboBox1.TabIndex = 34;
            // 
            // CbxMateria
            // 
            CbxMateria.BackColor = Color.FromArgb(32, 30, 45);
            CbxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxMateria.FlatStyle = FlatStyle.Flat;
            CbxMateria.ForeColor = Color.White;
            CbxMateria.FormattingEnabled = true;
            CbxMateria.Location = new Point(109, 162);
            CbxMateria.Margin = new Padding(3, 4, 3, 4);
            CbxMateria.Name = "CbxMateria";
            CbxMateria.Size = new Size(157, 28);
            CbxMateria.TabIndex = 33;
            // 
            // label13
            // 
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(231, 1, 61);
            label13.Location = new Point(3, 232);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 32;
            label13.Text = "Voto";
            // 
            // label16
            // 
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(231, 61, 61);
            label16.Location = new Point(3, 162);
            label16.Name = "label16";
            label16.Size = new Size(86, 25);
            label16.TabIndex = 31;
            label16.Text = "Materia";
            // 
            // LblMatricola
            // 
            LblMatricola.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMatricola.ForeColor = Color.FromArgb(231, 61, 61);
            LblMatricola.Location = new Point(3, 24);
            LblMatricola.Name = "LblMatricola";
            LblMatricola.Size = new Size(111, 30);
            LblMatricola.TabIndex = 25;
            LblMatricola.Text = "Matricola";
            // 
            // TxtMatricola
            // 
            TxtMatricola.BackColor = Color.FromArgb(32, 30, 45);
            TxtMatricola.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricola.ForeColor = Color.White;
            TxtMatricola.Location = new Point(113, 24);
            TxtMatricola.Margin = new Padding(3, 5, 3, 5);
            TxtMatricola.Name = "TxtMatricola";
            TxtMatricola.Size = new Size(164, 30);
            TxtMatricola.TabIndex = 26;
            TxtMatricola.Text = "Inserisci Matricola";
            TxtMatricola.MouseClick += TxtMatricola_MouseClick;
            TxtMatricola.TextChanged += TxtMatricola_TextChanged_1;
            TxtMatricola.MouseLeave += TxtMatricola_MouseLeave;
            // 
            // textBox12
            // 
            textBox12.Dock = DockStyle.Top;
            textBox12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(286, 0);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(413, 27);
            textBox12.TabIndex = 36;
            textBox12.Text = "Voti Studente";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // DgwVoti
            // 
            DgwVoti.BackgroundColor = Color.White;
            DgwVoti.ColumnHeadersHeight = 29;
            DgwVoti.Columns.AddRange(new DataGridViewColumn[] { Materie, Voti });
            DgwVoti.Dock = DockStyle.Fill;
            DgwVoti.Location = new Point(0, 0);
            DgwVoti.Margin = new Padding(3, 4, 3, 4);
            DgwVoti.Name = "DgwVoti";
            DgwVoti.RowHeadersWidth = 51;
            DgwVoti.RowTemplate.Height = 24;
            DgwVoti.Size = new Size(414, 473);
            DgwVoti.TabIndex = 36;
            // 
            // Materie
            // 
            Materie.HeaderText = "Materie";
            Materie.MinimumWidth = 6;
            Materie.Name = "Materie";
            Materie.Width = 164;
            // 
            // Voti
            // 
            Voti.HeaderText = "Voti";
            Voti.MinimumWidth = 6;
            Voti.Name = "Voti";
            Voti.Width = 164;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(32, 30, 45);
            panel3.Controls.Add(DgwVoti);
            panel3.Location = new Point(286, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 473);
            panel3.TabIndex = 37;
            // 
            // Gestione_Voti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(699, 500);
            Controls.Add(panel3);
            Controls.Add(textBox12);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(699, 500);
            Name = "Gestione_Voti";
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgwVoti).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label LblMatricola;
        private TextBox TxtMatricola;
        private ComboBox CbxMateria;
        private Label label13;
        private Label label16;
        private TextBox textBox12;
        private ComboBox comboBox1;
        private DataGridView DgwVoti;
        private DataGridViewTextBoxColumn Materie;
        private DataGridViewTextBoxColumn Voti;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private ComboBox comboBox2;
        private Label label1;
    }
}