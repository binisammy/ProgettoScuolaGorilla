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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAddStudente = new Button();
            btnDelete = new Button();
            cbClassi = new ComboBox();
            LblClasse = new Label();
            LblMatricola = new Label();
            TxtMatricola = new TextBox();
            LblCognome = new Label();
            TxtCognome = new TextBox();
            LblNome = new Label();
            TxtNome = new TextBox();
            textBox11 = new TextBox();
            panel2 = new Panel();
            dgwStudenti = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwStudenti).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(btnAddStudente);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cbClassi);
            panel1.Controls.Add(LblClasse);
            panel1.Controls.Add(LblMatricola);
            panel1.Controls.Add(TxtMatricola);
            panel1.Controls.Add(LblCognome);
            panel1.Controls.Add(TxtCognome);
            panel1.Controls.Add(LblNome);
            panel1.Controls.Add(TxtNome);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 375);
            panel1.TabIndex = 1;
            // 
            // btnAddStudente
            // 
            btnAddStudente.Dock = DockStyle.Bottom;
            btnAddStudente.FlatAppearance.BorderSize = 0;
            btnAddStudente.FlatStyle = FlatStyle.Flat;
            btnAddStudente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudente.ForeColor = Color.FromArgb(231, 61, 61);
            btnAddStudente.Location = new Point(0, 307);
            btnAddStudente.Name = "btnAddStudente";
            btnAddStudente.Size = new Size(269, 34);
            btnAddStudente.TabIndex = 29;
            btnAddStudente.Text = "Aggiungi";
            btnAddStudente.UseVisualStyleBackColor = true;
            btnAddStudente.Click += btnAddStudente_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(231, 61, 61);
            btnDelete.Location = new Point(0, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(269, 34);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Rimuovi";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbClassi
            // 
            cbClassi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbClassi.BackColor = Color.FromArgb(32, 30, 45);
            cbClassi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClassi.FlatStyle = FlatStyle.Flat;
            cbClassi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbClassi.ForeColor = Color.White;
            cbClassi.FormattingEnabled = true;
            cbClassi.Items.AddRange(new object[] { "" });
            cbClassi.Location = new Point(128, 180);
            cbClassi.Name = "cbClassi";
            cbClassi.Size = new Size(116, 23);
            cbClassi.TabIndex = 28;
            // 
            // LblClasse
            // 
            LblClasse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LblClasse.AutoSize = true;
            LblClasse.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblClasse.ForeColor = Color.FromArgb(231, 61, 61);
            LblClasse.Location = new Point(10, 181);
            LblClasse.Name = "LblClasse";
            LblClasse.Size = new Size(59, 21);
            LblClasse.TabIndex = 23;
            LblClasse.Text = "Classe";
            // 
            // LblMatricola
            // 
            LblMatricola.AutoSize = true;
            LblMatricola.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMatricola.ForeColor = Color.FromArgb(231, 61, 61);
            LblMatricola.Location = new Point(10, 128);
            LblMatricola.Name = "LblMatricola";
            LblMatricola.Size = new Size(86, 21);
            LblMatricola.TabIndex = 19;
            LblMatricola.Text = "Matricola";
            // 
            // TxtMatricola
            // 
            TxtMatricola.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtMatricola.BackColor = Color.FromArgb(32, 30, 45);
            TxtMatricola.BorderStyle = BorderStyle.FixedSingle;
            TxtMatricola.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtMatricola.ForeColor = Color.White;
            TxtMatricola.Location = new Point(128, 129);
            TxtMatricola.Name = "TxtMatricola";
            TxtMatricola.Size = new Size(116, 25);
            TxtMatricola.TabIndex = 20;
            TxtMatricola.Text = "Inserisci Matricola";
            TxtMatricola.TextAlign = HorizontalAlignment.Center;
            TxtMatricola.MouseClick += TxtMatricola_MouseClick;
            TxtMatricola.Leave += TxtMatricola_Leave;
            // 
            // LblCognome
            // 
            LblCognome.AutoSize = true;
            LblCognome.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblCognome.ForeColor = Color.FromArgb(231, 61, 61);
            LblCognome.Location = new Point(11, 71);
            LblCognome.Name = "LblCognome";
            LblCognome.Size = new Size(84, 21);
            LblCognome.TabIndex = 17;
            LblCognome.Text = "Cognome";
            // 
            // TxtCognome
            // 
            TxtCognome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtCognome.BackColor = Color.FromArgb(32, 30, 45);
            TxtCognome.BorderStyle = BorderStyle.FixedSingle;
            TxtCognome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtCognome.ForeColor = Color.White;
            TxtCognome.Location = new Point(128, 72);
            TxtCognome.Name = "TxtCognome";
            TxtCognome.Size = new Size(116, 25);
            TxtCognome.TabIndex = 18;
            TxtCognome.Text = "Inserisci Cognome";
            TxtCognome.TextAlign = HorizontalAlignment.Center;
            TxtCognome.MouseClick += TxtCognome_MouseClick;
            TxtCognome.Leave += TxtCognome_Leave;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblNome.ForeColor = Color.FromArgb(231, 61, 61);
            LblNome.Location = new Point(10, 20);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(57, 21);
            LblNome.TabIndex = 15;
            LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TxtNome.BackColor = Color.FromArgb(32, 30, 45);
            TxtNome.BorderStyle = BorderStyle.FixedSingle;
            TxtNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtNome.ForeColor = Color.White;
            TxtNome.Location = new Point(128, 24);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(116, 25);
            TxtNome.TabIndex = 16;
            TxtNome.Text = "Inserisci Nome";
            TxtNome.TextAlign = HorizontalAlignment.Center;
            TxtNome.MouseClick += TxtNome_MouseClick;
            TxtNome.Leave += TxtNome_Leave;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(32, 30, 45);
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Dock = DockStyle.Top;
            textBox11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(269, 0);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(343, 23);
            textBox11.TabIndex = 4;
            textBox11.Text = "Lista Studenti";
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgwStudenti);
            panel2.Location = new Point(269, 24);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 351);
            panel2.TabIndex = 5;
            // 
            // dgwStudenti
            // 
            dgwStudenti.AllowUserToAddRows = false;
            dgwStudenti.AllowUserToDeleteRows = false;
            dgwStudenti.AllowUserToResizeColumns = false;
            dgwStudenti.AllowUserToResizeRows = false;
            dgwStudenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwStudenti.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwStudenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwStudenti.ColumnHeadersHeight = 29;
            dgwStudenti.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 54, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(38, 54, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwStudenti.DefaultCellStyle = dataGridViewCellStyle2;
            dgwStudenti.Dock = DockStyle.Fill;
            dgwStudenti.Location = new Point(0, 0);
            dgwStudenti.Name = "dgwStudenti";
            dgwStudenti.ReadOnly = true;
            dgwStudenti.RowHeadersVisible = false;
            dgwStudenti.RowHeadersWidth = 51;
            dgwStudenti.RowTemplate.Height = 24;
            dgwStudenti.Size = new Size(343, 351);
            dgwStudenti.TabIndex = 3;
            dgwStudenti.CellContentClick += dataGridView3_CellContentClick;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Matricola";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cognome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Classe";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Gestione_Studenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(612, 375);
            Controls.Add(panel2);
            Controls.Add(textBox11);
            Controls.Add(panel1);
            MinimumSize = new Size(614, 385);
            Name = "Gestione_Studenti";
            Text = "Gestione Studenti";
            Load += Gestione_Studenti_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cbClassi;
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
        private Button btnAddStudente;
        private Button btnDelete;
        private Panel panel2;
        private DataGridView dgwStudenti;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}