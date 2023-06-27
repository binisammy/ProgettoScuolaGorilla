namespace Scuola_Gorilla
{
    partial class Gestione_Studenti
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
            button5 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            LblClasse = new Label();
            LblMatricola = new Label();
            TxtMatricola = new TextBox();
            LblCognome = new Label();
            TxtCognome = new TextBox();
            LblNome = new Label();
            TxtNome = new TextBox();
            textBox11 = new TextBox();
            panel2 = new Panel();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(LblClasse);
            panel1.Controls.Add(LblMatricola);
            panel1.Controls.Add(TxtMatricola);
            panel1.Controls.Add(LblCognome);
            panel1.Controls.Add(TxtCognome);
            panel1.Controls.Add(LblNome);
            panel1.Controls.Add(TxtNome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 500);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Dock = DockStyle.Bottom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(231, 61, 61);
            button5.Location = new Point(0, 280);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(256, 40);
            button5.TabIndex = 33;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(231, 61, 61);
            button4.Location = new Point(0, 320);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(256, 45);
            button4.TabIndex = 32;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(231, 61, 61);
            button1.Location = new Point(0, 365);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(256, 45);
            button1.TabIndex = 29;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(231, 61, 61);
            button2.Location = new Point(0, 410);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(256, 45);
            button2.TabIndex = 30;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Dock = DockStyle.Bottom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(231, 61, 61);
            button3.Location = new Point(0, 455);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(256, 45);
            button3.TabIndex = 31;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.BackColor = Color.FromArgb(32, 30, 45);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1A", "1B", "2A", "2B", "3A", "3B", "4A", "4B", "5A", "5B" });
            comboBox1.Location = new Point(117, 240);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 26);
            comboBox1.TabIndex = 28;
            // 
            // LblClasse
            // 
            LblClasse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LblClasse.AutoSize = true;
            LblClasse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblClasse.ForeColor = Color.FromArgb(231, 61, 61);
            LblClasse.Location = new Point(12, 241);
            LblClasse.Name = "LblClasse";
            LblClasse.Size = new Size(79, 25);
            LblClasse.TabIndex = 23;
            LblClasse.Text = "Classe";
            // 
            // LblMatricola
            // 
            LblMatricola.AutoSize = true;
            LblMatricola.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMatricola.ForeColor = Color.FromArgb(231, 61, 61);
            LblMatricola.Location = new Point(12, 171);
            LblMatricola.Name = "LblMatricola";
            LblMatricola.Size = new Size(100, 25);
            LblMatricola.TabIndex = 19;
            LblMatricola.Text = "Matricola";
            // 
            // TxtMatricola
            // 
            TxtMatricola.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtMatricola.BackColor = Color.FromArgb(32, 30, 45);
            TxtMatricola.BorderStyle = BorderStyle.None;
            TxtMatricola.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricola.ForeColor = Color.White;
            TxtMatricola.Location = new Point(118, 176);
            TxtMatricola.Margin = new Padding(3, 4, 3, 4);
            TxtMatricola.Name = "TxtMatricola";
            TxtMatricola.Size = new Size(133, 17);
            TxtMatricola.TabIndex = 20;
            TxtMatricola.Text = "Inserisci Matricola";
            TxtMatricola.MouseClick += TxtMatricola_MouseClick;
            TxtMatricola.Leave += TxtMatricola_Leave;
            // 
            // LblCognome
            // 
            LblCognome.AutoSize = true;
            LblCognome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblCognome.ForeColor = Color.FromArgb(231, 61, 61);
            LblCognome.Location = new Point(13, 95);
            LblCognome.Name = "LblCognome";
            LblCognome.Size = new Size(105, 25);
            LblCognome.TabIndex = 17;
            LblCognome.Text = "Cognome";
            // 
            // TxtCognome
            // 
            TxtCognome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtCognome.BackColor = Color.FromArgb(32, 30, 45);
            TxtCognome.BorderStyle = BorderStyle.None;
            TxtCognome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCognome.ForeColor = Color.White;
            TxtCognome.Location = new Point(120, 100);
            TxtCognome.Margin = new Padding(3, 4, 3, 4);
            TxtCognome.Name = "TxtCognome";
            TxtCognome.Size = new Size(133, 17);
            TxtCognome.TabIndex = 18;
            TxtCognome.Text = "Inserisci Cognome";
            TxtCognome.MouseClick += TxtCognome_MouseClick;
            TxtCognome.Leave += TxtCognome_Leave;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblNome.ForeColor = Color.FromArgb(231, 61, 61);
            LblNome.Location = new Point(12, 27);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(68, 25);
            LblNome.TabIndex = 15;
            LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtNome.BackColor = Color.FromArgb(32, 30, 45);
            TxtNome.BorderStyle = BorderStyle.None;
            TxtNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNome.ForeColor = Color.White;
            TxtNome.Location = new Point(117, 32);
            TxtNome.Margin = new Padding(3, 4, 3, 4);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(133, 17);
            TxtNome.TabIndex = 16;
            TxtNome.Text = "Inserisci Nome";
            TxtNome.MouseClick += TxtNome_MouseClick;
            TxtNome.Leave += TxtNome_Leave;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(32, 30, 45);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Dock = DockStyle.Top;
            textBox11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(256, 0);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(444, 20);
            textBox11.TabIndex = 4;
            textBox11.Text = "Lista Studenti";
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(256, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 480);
            panel2.TabIndex = 5;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4 });
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 24;
            dataGridView3.Size = new Size(444, 480);
            dataGridView3.TabIndex = 3;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Matricola";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cognome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Classe";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Gestione_Studenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(700, 500);
            Controls.Add(panel2);
            Controls.Add(textBox11);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(700, 500);
            Name = "Gestione_Studenti";
            Text = "Gestione Studenti";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Label LblClasse;
        private Label LblMatricola;
        private TextBox TxtMatricola;
        private Label LblCognome;
        private TextBox TxtCognome;
        private Label LblNome;
        private TextBox TxtNome;
        private TextBox textBox11;
        private Button button5;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}