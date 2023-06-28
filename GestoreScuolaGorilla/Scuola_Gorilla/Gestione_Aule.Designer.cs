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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnModificaMaterieClasse = new Button();
            btnCercaClasse = new Button();
            btnAggiungiClasse = new Button();
            btnEliminaClasse = new Button();
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
            Matricola = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cognome = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(btnModificaMaterieClasse);
            panel1.Controls.Add(btnCercaClasse);
            panel1.Controls.Add(btnAggiungiClasse);
            panel1.Controls.Add(btnEliminaClasse);
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
            // btnModificaMaterieClasse
            // 
            btnModificaMaterieClasse.FlatAppearance.BorderSize = 0;
            btnModificaMaterieClasse.FlatStyle = FlatStyle.Flat;
            btnModificaMaterieClasse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificaMaterieClasse.ForeColor = Color.FromArgb(231, 61, 61);
            btnModificaMaterieClasse.Location = new Point(176, 264);
            btnModificaMaterieClasse.Margin = new Padding(3, 4, 3, 4);
            btnModificaMaterieClasse.Name = "btnModificaMaterieClasse";
            btnModificaMaterieClasse.Size = new Size(66, 33);
            btnModificaMaterieClasse.TabIndex = 22;
            btnModificaMaterieClasse.Text = "Applica";
            btnModificaMaterieClasse.UseVisualStyleBackColor = true;
            btnModificaMaterieClasse.Click += btnModificaMaterieClasse_Click;
            // 
            // btnCercaClasse
            // 
            btnCercaClasse.Dock = DockStyle.Bottom;
            btnCercaClasse.FlatAppearance.BorderSize = 0;
            btnCercaClasse.FlatStyle = FlatStyle.Flat;
            btnCercaClasse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCercaClasse.ForeColor = Color.FromArgb(231, 61, 61);
            btnCercaClasse.Location = new Point(0, 468);
            btnCercaClasse.Margin = new Padding(3, 4, 3, 4);
            btnCercaClasse.Name = "btnCercaClasse";
            btnCercaClasse.Size = new Size(307, 51);
            btnCercaClasse.TabIndex = 21;
            btnCercaClasse.Text = "Cerca";
            btnCercaClasse.UseVisualStyleBackColor = true;
            btnCercaClasse.Click += btnCercaClasse_Click;
            // 
            // btnAggiungiClasse
            // 
            btnAggiungiClasse.Dock = DockStyle.Bottom;
            btnAggiungiClasse.FlatAppearance.BorderSize = 0;
            btnAggiungiClasse.FlatStyle = FlatStyle.Flat;
            btnAggiungiClasse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungiClasse.ForeColor = Color.FromArgb(231, 61, 61);
            btnAggiungiClasse.Location = new Point(0, 519);
            btnAggiungiClasse.Margin = new Padding(3, 4, 3, 4);
            btnAggiungiClasse.Name = "btnAggiungiClasse";
            btnAggiungiClasse.Size = new Size(307, 45);
            btnAggiungiClasse.TabIndex = 19;
            btnAggiungiClasse.Text = "Aggiungi Classe";
            btnAggiungiClasse.UseVisualStyleBackColor = true;
            btnAggiungiClasse.Click += btnAggiungiClasse_Click;
            // 
            // btnEliminaClasse
            // 
            btnEliminaClasse.Dock = DockStyle.Bottom;
            btnEliminaClasse.FlatAppearance.BorderSize = 0;
            btnEliminaClasse.FlatStyle = FlatStyle.Flat;
            btnEliminaClasse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminaClasse.ForeColor = Color.FromArgb(231, 61, 61);
            btnEliminaClasse.Location = new Point(0, 564);
            btnEliminaClasse.Margin = new Padding(3, 4, 3, 4);
            btnEliminaClasse.Name = "btnEliminaClasse";
            btnEliminaClasse.Size = new Size(307, 48);
            btnEliminaClasse.TabIndex = 20;
            btnEliminaClasse.Text = "Elimina Classe";
            btnEliminaClasse.UseVisualStyleBackColor = true;
            btnEliminaClasse.Click += btnEliminaClasse_Click;
            // 
            // BtnDeleteMateria
            // 
            BtnDeleteMateria.Anchor = AnchorStyles.Right;
            BtnDeleteMateria.FlatAppearance.BorderSize = 0;
            BtnDeleteMateria.FlatStyle = FlatStyle.Flat;
            BtnDeleteMateria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDeleteMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnDeleteMateria.Location = new Point(120, 444);
            BtnDeleteMateria.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteMateria.Name = "BtnDeleteMateria";
            BtnDeleteMateria.Size = new Size(67, 35);
            BtnDeleteMateria.TabIndex = 17;
            BtnDeleteMateria.Text = "Rimuovi";
            BtnDeleteMateria.UseVisualStyleBackColor = true;
            BtnDeleteMateria.Click += BtnDeleteMateria_Click;
            // 
            // BtnClearMateria
            // 
            BtnClearMateria.Anchor = AnchorStyles.Right;
            BtnClearMateria.FlatAppearance.BorderSize = 0;
            BtnClearMateria.FlatStyle = FlatStyle.Flat;
            BtnClearMateria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClearMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnClearMateria.Location = new Point(226, 444);
            BtnClearMateria.Margin = new Padding(3, 4, 3, 4);
            BtnClearMateria.Name = "BtnClearMateria";
            BtnClearMateria.Size = new Size(74, 35);
            BtnClearMateria.TabIndex = 16;
            BtnClearMateria.Text = "Cancella";
            BtnClearMateria.UseVisualStyleBackColor = true;
            BtnClearMateria.Click += BtnClearMateria_Click;
            // 
            // BtnAddMateria
            // 
            BtnAddMateria.Anchor = AnchorStyles.Left;
            BtnAddMateria.FlatAppearance.BorderSize = 0;
            BtnAddMateria.FlatStyle = FlatStyle.Flat;
            BtnAddMateria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnAddMateria.Location = new Point(6, 444);
            BtnAddMateria.Margin = new Padding(3, 4, 3, 4);
            BtnAddMateria.Name = "BtnAddMateria";
            BtnAddMateria.Size = new Size(73, 35);
            BtnAddMateria.TabIndex = 15;
            BtnAddMateria.Text = "Aggiungi";
            BtnAddMateria.UseVisualStyleBackColor = true;
            BtnAddMateria.Click += BtnAddMateria_Click;
            // 
            // TxtNuovaMateria
            // 
            TxtNuovaMateria.Anchor = AnchorStyles.Left;
            TxtNuovaMateria.BackColor = Color.FromArgb(32, 30, 45);
            TxtNuovaMateria.BorderStyle = BorderStyle.FixedSingle;
            TxtNuovaMateria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtNuovaMateria.ForeColor = Color.FromArgb(231, 61, 61);
            TxtNuovaMateria.Location = new Point(6, 396);
            TxtNuovaMateria.Margin = new Padding(3, 4, 3, 4);
            TxtNuovaMateria.Name = "TxtNuovaMateria";
            TxtNuovaMateria.Size = new Size(298, 29);
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
            BtnAggiungiMateria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAggiungiMateria.ForeColor = Color.FromArgb(231, 61, 61);
            BtnAggiungiMateria.Location = new Point(6, 348);
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
            ClbListaMaterie.BorderStyle = BorderStyle.FixedSingle;
            ClbListaMaterie.CheckOnClick = true;
            ClbListaMaterie.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ClbListaMaterie.ForeColor = Color.White;
            ClbListaMaterie.FormattingEnabled = true;
            ClbListaMaterie.Location = new Point(14, 145);
            ClbListaMaterie.Margin = new Padding(3, 4, 3, 4);
            ClbListaMaterie.Name = "ClbListaMaterie";
            ClbListaMaterie.Size = new Size(155, 146);
            ClbListaMaterie.TabIndex = 3;
            ClbListaMaterie.SelectedIndexChanged += ClbListaMaterie_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(231, 61, 61);
            label8.Location = new Point(9, 103);
            label8.Name = "label8";
            label8.Size = new Size(175, 27);
            label8.TabIndex = 4;
            label8.Text = "Seleziona Materie";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(231, 61, 61);
            label14.Location = new Point(9, 31);
            label14.Name = "label14";
            label14.Size = new Size(89, 28);
            label14.TabIndex = 6;
            label14.Text = "Classe:";
            // 
            // TxtIDaula
            // 
            TxtIDaula.BackColor = Color.FromArgb(32, 30, 45);
            TxtIDaula.BorderStyle = BorderStyle.FixedSingle;
            TxtIDaula.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtIDaula.ForeColor = Color.White;
            TxtIDaula.Location = new Point(105, 32);
            TxtIDaula.Margin = new Padding(3, 4, 3, 4);
            TxtIDaula.Name = "TxtIDaula";
            TxtIDaula.Size = new Size(169, 29);
            TxtIDaula.TabIndex = 5;
            TxtIDaula.Text = "Inserisci ID classe";
            TxtIDaula.TextAlign = HorizontalAlignment.Center;
            TxtIDaula.MouseClick += TxtIDaula_MouseClick;
            TxtIDaula.TextChanged += TxtIDaula_TextChanged;
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
            textBox12.Text = "Studenti";
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
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Matricola, Nome, Cognome });
            dataGridView4.Cursor = Cursors.Cross;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Margin = new Padding(3, 4, 3, 4);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView4.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView4.RowTemplate.Height = 24;
            dataGridView4.Size = new Size(392, 585);
            dataGridView4.TabIndex = 15;
            // 
            // Matricola
            // 
            Matricola.HeaderText = "Matricola";
            Matricola.MinimumWidth = 6;
            Matricola.Name = "Matricola";
            Matricola.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Cognome
            // 
            Cognome.HeaderText = "Cognome";
            Cognome.MinimumWidth = 6;
            Cognome.Name = "Cognome";
            Cognome.ReadOnly = true;
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
        private Button btnCercaClasse;
        private Button btnAggiungiClasse;
        private Button btnEliminaClasse;
        private TextBox textBox12;
        private Panel panel2;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Matricola;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cognome;
        private Button btnModificaMaterieClasse;
    }
}