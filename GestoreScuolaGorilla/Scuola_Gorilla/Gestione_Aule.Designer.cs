namespace Scuola_Gorilla
{
    partial class Gestione_Aule
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
            button8 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            BtnDeleteMateria = new Button();
            BtnClearMateria = new Button();
            BtnAddMateria = new Button();
            TxtNuovaMateria = new TextBox();
            BtnAggiungiMateria = new Button();
            ClbListaMaterie = new CheckedListBox();
            label8 = new Label();
            label14 = new Label();
            TxtIDaula = new TextBox();
            textBox12 = new TextBox();
            panel2 = new Panel();
            dataGridView4 = new DataGridView();
            ID_aula = new DataGridViewTextBoxColumn();
            Materie = new DataGridViewTextBoxColumn();
            Studenti = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(BtnDeleteMateria);
            panel1.Controls.Add(BtnClearMateria);
            panel1.Controls.Add(BtnAddMateria);
            panel1.Controls.Add(TxtNuovaMateria);
            panel1.Controls.Add(BtnAggiungiMateria);
            panel1.Controls.Add(ClbListaMaterie);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(TxtIDaula);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 612);
            panel1.TabIndex = 2;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Bottom;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.FromArgb(231, 61, 61);
            button8.Location = new Point(0, 460);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(307, 38);
            button8.TabIndex = 18;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Bottom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(231, 61, 61);
            button4.Location = new Point(0, 498);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(307, 38);
            button4.TabIndex = 21;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(231, 61, 61);
            button1.Location = new Point(0, 536);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(307, 38);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(231, 61, 61);
            button2.Location = new Point(0, 574);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(307, 38);
            button2.TabIndex = 20;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteMateria
            // 
            BtnDeleteMateria.Anchor = AnchorStyles.Right;
            BtnDeleteMateria.FlatAppearance.BorderSize = 0;
            BtnDeleteMateria.FlatStyle = FlatStyle.Flat;
            BtnDeleteMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnDeleteMateria.Location = new Point(120, 403);
            BtnDeleteMateria.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteMateria.Name = "BtnDeleteMateria";
            BtnDeleteMateria.Size = new Size(67, 28);
            BtnDeleteMateria.TabIndex = 17;
            BtnDeleteMateria.Text = "Delete";
            BtnDeleteMateria.UseVisualStyleBackColor = true;
            BtnDeleteMateria.Click += BtnDeleteMateria_Click;
            // 
            // BtnClearMateria
            // 
            BtnClearMateria.Anchor = AnchorStyles.Right;
            BtnClearMateria.FlatAppearance.BorderSize = 0;
            BtnClearMateria.FlatStyle = FlatStyle.Flat;
            BtnClearMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnClearMateria.Location = new Point(245, 403);
            BtnClearMateria.Margin = new Padding(3, 4, 3, 4);
            BtnClearMateria.Name = "BtnClearMateria";
            BtnClearMateria.Size = new Size(59, 28);
            BtnClearMateria.TabIndex = 16;
            BtnClearMateria.Text = "Clear";
            BtnClearMateria.UseVisualStyleBackColor = true;
            BtnClearMateria.Click += BtnClearMateria_Click;
            // 
            // BtnAddMateria
            // 
            BtnAddMateria.Anchor = AnchorStyles.Left;
            BtnAddMateria.FlatAppearance.BorderSize = 0;
            BtnAddMateria.FlatStyle = FlatStyle.Flat;
            BtnAddMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnAddMateria.Location = new Point(6, 403);
            BtnAddMateria.Margin = new Padding(3, 4, 3, 4);
            BtnAddMateria.Name = "BtnAddMateria";
            BtnAddMateria.Size = new Size(59, 28);
            BtnAddMateria.TabIndex = 15;
            BtnAddMateria.Text = "Add";
            BtnAddMateria.UseVisualStyleBackColor = true;
            BtnAddMateria.Click += BtnAddMateria_Click;
            // 
            // TxtNuovaMateria
            // 
            TxtNuovaMateria.Anchor = AnchorStyles.Left;
            TxtNuovaMateria.BackColor = Color.FromArgb(32, 30, 45);
            TxtNuovaMateria.BorderStyle = BorderStyle.FixedSingle;
            TxtNuovaMateria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNuovaMateria.ForeColor = Color.FromArgb(231, 61, 61);
            TxtNuovaMateria.Location = new Point(6, 354);
            TxtNuovaMateria.Margin = new Padding(3, 4, 3, 4);
            TxtNuovaMateria.Name = "TxtNuovaMateria";
            TxtNuovaMateria.Size = new Size(298, 30);
            TxtNuovaMateria.TabIndex = 14;
            TxtNuovaMateria.Text = "Inserisci nuova Materia";
            TxtNuovaMateria.TextAlign = HorizontalAlignment.Center;
            TxtNuovaMateria.MouseClick += TxtNuovaMateria_MouseClick;
            TxtNuovaMateria.Leave += TxrNuovaMateria_Leave;
            // 
            // BtnAggiungiMateria
            // 
            BtnAggiungiMateria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnAggiungiMateria.FlatAppearance.BorderSize = 0;
            BtnAggiungiMateria.FlatStyle = FlatStyle.Flat;
            BtnAggiungiMateria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAggiungiMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnAggiungiMateria.Location = new Point(6, 307);
            BtnAggiungiMateria.Margin = new Padding(3, 4, 3, 4);
            BtnAggiungiMateria.Name = "BtnAggiungiMateria";
            BtnAggiungiMateria.Size = new Size(298, 39);
            BtnAggiungiMateria.TabIndex = 9;
            BtnAggiungiMateria.Text = "Aggiungi/Elimina Materia";
            BtnAggiungiMateria.UseVisualStyleBackColor = true;
            BtnAggiungiMateria.Click += button5_Click;
            // 
            // ClbListaMaterie
            // 
            ClbListaMaterie.BackColor = Color.FromArgb(32, 30, 45);
            ClbListaMaterie.CheckOnClick = true;
            ClbListaMaterie.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ClbListaMaterie.ForeColor = Color.White;
            ClbListaMaterie.FormattingEnabled = true;
            ClbListaMaterie.Items.AddRange(new object[] { "materia1", "materia2", "materia3", "materia4", "materia5", "materia6", "materia7", "materia8" });
            ClbListaMaterie.Location = new Point(13, 107);
            ClbListaMaterie.Margin = new Padding(3, 4, 3, 4);
            ClbListaMaterie.Name = "ClbListaMaterie";
            ClbListaMaterie.Size = new Size(146, 172);
            ClbListaMaterie.TabIndex = 3;
            ClbListaMaterie.SelectedIndexChanged += ClbListaMaterie_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(231, 61, 61);
            label8.Location = new Point(12, 77);
            label8.Name = "label8";
            label8.Size = new Size(194, 26);
            label8.TabIndex = 4;
            label8.Text = "Seleziona Materie:";
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(231, 61, 61);
            label14.Location = new Point(13, 26);
            label14.Name = "label14";
            label14.Size = new Size(129, 28);
            label14.TabIndex = 6;
            label14.Text = "Inserisci ID aula:";
            // 
            // TxtIDaula
            // 
            TxtIDaula.BackColor = Color.FromArgb(32, 30, 45);
            TxtIDaula.BorderStyle = BorderStyle.FixedSingle;
            TxtIDaula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIDaula.ForeColor = Color.White;
            TxtIDaula.Location = new Point(148, 23);
            TxtIDaula.Margin = new Padding(3, 4, 3, 4);
            TxtIDaula.Name = "TxtIDaula";
            TxtIDaula.Size = new Size(156, 30);
            TxtIDaula.TabIndex = 5;
            TxtIDaula.Text = "Inserisci ID classe";
            TxtIDaula.MouseClick += TxtIDaula_MouseClick;
            TxtIDaula.Leave += TxtIDaula_Leave;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(32, 30, 45);
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.Dock = DockStyle.Top;
            textBox12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.ForeColor = Color.White;
            textBox12.Location = new Point(307, 0);
            textBox12.Margin = new Padding(3, 5, 3, 5);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(392, 27);
            textBox12.TabIndex = 37;
            textBox12.Text = "Voti Studente";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 30, 45);
            panel2.Controls.Add(dataGridView4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(307, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 585);
            panel2.TabIndex = 38;
            // 
            // dataGridView4
            // 
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { ID_aula, Materie, Studenti });
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Margin = new Padding(3, 4, 3, 4);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 24;
            dataGridView4.Size = new Size(392, 585);
            dataGridView4.TabIndex = 15;
            // 
            // ID_aula
            // 
            ID_aula.HeaderText = "ID_aula";
            ID_aula.MinimumWidth = 6;
            ID_aula.Name = "ID_aula";
            // 
            // Materie
            // 
            Materie.HeaderText = "Materie";
            Materie.MinimumWidth = 6;
            Materie.Name = "Materie";
            // 
            // Studenti
            // 
            Studenti.HeaderText = "Studenti";
            Studenti.MinimumWidth = 6;
            Studenti.Name = "Studenti";
            // 
            // Gestione_Aule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(699, 612);
            Controls.Add(panel2);
            Controls.Add(textBox12);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(699, 612);
            Name = "Gestione_Aule";
            Text = "Gestione Aule";
            Load += Gestione_Aule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckedListBox ClbListaMaterie;
        private Label label8;
        private Label label14;
        private TextBox TxtIDaula;
        private Button BtnAddMateria;
        private Button BtnAggiungiMateria;
        private Button BtnClearMateria;
        private Button BtnDeleteMateria;
        private TextBox TxtNuovaMateria;
        private Button button8;
        private Button button4;
        private Button button1;
        private Button button2;
        private TextBox textBox12;
        private Panel panel2;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn ID_aula;
        private DataGridViewTextBoxColumn Materie;
        private DataGridViewTextBoxColumn Studenti;
    }
}