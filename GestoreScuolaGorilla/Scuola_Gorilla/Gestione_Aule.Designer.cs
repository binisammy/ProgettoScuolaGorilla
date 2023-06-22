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
            BtnDeleteMateria = new Button();
            BtnClearMateria = new Button();
            BtnAddMateria = new Button();
            TxtNuovaMateria = new TextBox();
            BtnAggiungiMateria = new Button();
            ClbListaMaterie = new CheckedListBox();
            label8 = new Label();
            label14 = new Label();
            TxtIDaula = new TextBox();
            panel2 = new Panel();
            button8 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridView4 = new DataGridView();
            ID_aula = new DataGridViewTextBoxColumn();
            Materie = new DataGridViewTextBoxColumn();
            Studenti = new DataGridViewTextBoxColumn();
            textBox12 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(BtnDeleteMateria);
            panel1.Controls.Add(BtnClearMateria);
            panel1.Controls.Add(BtnAddMateria);
            panel1.Controls.Add(TxtNuovaMateria);
            panel1.Controls.Add(BtnAggiungiMateria);
            panel1.Controls.Add(ClbListaMaterie);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(TxtIDaula);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 297);
            panel1.TabIndex = 2;
            // 
            // BtnDeleteMateria
            // 
            BtnDeleteMateria.Anchor = AnchorStyles.None;
            BtnDeleteMateria.Location = new Point(103, 265);
            BtnDeleteMateria.Name = "BtnDeleteMateria";
            BtnDeleteMateria.Size = new Size(59, 24);
            BtnDeleteMateria.TabIndex = 17;
            BtnDeleteMateria.Text = "Delete";
            BtnDeleteMateria.UseVisualStyleBackColor = true;
            BtnDeleteMateria.Click += BtnDeleteMateria_Click;
            // 
            // BtnClearMateria
            // 
            BtnClearMateria.Anchor = AnchorStyles.None;
            BtnClearMateria.Location = new Point(204, 265);
            BtnClearMateria.Name = "BtnClearMateria";
            BtnClearMateria.Size = new Size(52, 24);
            BtnClearMateria.TabIndex = 16;
            BtnClearMateria.Text = "Clear";
            BtnClearMateria.UseVisualStyleBackColor = true;
            BtnClearMateria.Click += BtnClearMateria_Click;
            // 
            // BtnAddMateria
            // 
            BtnAddMateria.Anchor = AnchorStyles.None;
            BtnAddMateria.Location = new Point(2, 265);
            BtnAddMateria.Name = "BtnAddMateria";
            BtnAddMateria.Size = new Size(52, 24);
            BtnAddMateria.TabIndex = 15;
            BtnAddMateria.Text = "Add";
            BtnAddMateria.UseVisualStyleBackColor = true;
            BtnAddMateria.Click += BtnAddMateria_Click;
            // 
            // TxtNuovaMateria
            // 
            TxtNuovaMateria.Location = new Point(66, 237);
            TxtNuovaMateria.Name = "TxtNuovaMateria";
            TxtNuovaMateria.Size = new Size(134, 23);
            TxtNuovaMateria.TabIndex = 14;
            TxtNuovaMateria.Text = "Inserisci nuova Materia";
            TxtNuovaMateria.MouseClick += TxtNuovaMateria_MouseClick;
            TxtNuovaMateria.TextChanged += TxtNuovaMateria_TextChanged;
            TxtNuovaMateria.MouseLeave += TxtNuovaMateria_MouseLeave;
            // 
            // BtnAggiungiMateria
            // 
            BtnAggiungiMateria.Anchor = AnchorStyles.None;
            BtnAggiungiMateria.Location = new Point(0, 196);
            BtnAggiungiMateria.Name = "BtnAggiungiMateria";
            BtnAggiungiMateria.Size = new Size(129, 24);
            BtnAggiungiMateria.TabIndex = 9;
            BtnAggiungiMateria.Text = "Aggiungi Materia";
            BtnAggiungiMateria.UseVisualStyleBackColor = true;
            BtnAggiungiMateria.Click += button5_Click;
            // 
            // ClbListaMaterie
            // 
            ClbListaMaterie.Anchor = AnchorStyles.None;
            ClbListaMaterie.CheckOnClick = true;
            ClbListaMaterie.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            ClbListaMaterie.FormattingEnabled = true;
            ClbListaMaterie.Items.AddRange(new object[] { "materia1", "materia2", "materia3", "materia4", "materia5", "materia6", "materia7", "materia8" });
            ClbListaMaterie.Location = new Point(3, 46);
            ClbListaMaterie.Name = "ClbListaMaterie";
            ClbListaMaterie.Size = new Size(120, 130);
            ClbListaMaterie.TabIndex = 3;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 27);
            label8.Name = "label8";
            label8.Size = new Size(145, 19);
            label8.TabIndex = 4;
            label8.Text = "Seleziona Materie:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(0, 7);
            label14.Name = "label14";
            label14.Size = new Size(113, 18);
            label14.TabIndex = 6;
            label14.Text = "Inserisci ID aula:";
            // 
            // TxtIDaula
            // 
            TxtIDaula.Anchor = AnchorStyles.None;
            TxtIDaula.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIDaula.Location = new Point(118, 4);
            TxtIDaula.Name = "TxtIDaula";
            TxtIDaula.Size = new Size(106, 19);
            TxtIDaula.TabIndex = 5;
            TxtIDaula.Text = "Inserisci ID classe";
            TxtIDaula.MouseClick += TxtIDaula_MouseClick;
            TxtIDaula.MouseLeave += TxtIDaula_MouseLeave;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(2, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 128);
            panel2.TabIndex = 7;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Location = new Point(3, 98);
            button8.Name = "button8";
            button8.Size = new Size(129, 24);
            button8.TabIndex = 7;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(3, 68);
            button4.Name = "button4";
            button4.Size = new Size(129, 24);
            button4.TabIndex = 11;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(3, 8);
            button1.Name = "button1";
            button1.Size = new Size(129, 24);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(3, 38);
            button2.Name = "button2";
            button2.Size = new Size(129, 24);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { ID_aula, Materie, Studenti });
            dataGridView4.Location = new Point(263, 25);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 24;
            dataGridView4.Size = new Size(333, 401);
            dataGridView4.TabIndex = 12;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
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
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(263, 2);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(334, 23);
            textBox12.TabIndex = 13;
            textBox12.Text = "Lista Aule";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // Gestione_Aule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(598, 432);
            Controls.Add(textBox12);
            Controls.Add(dataGridView4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(614, 471);
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
        private Panel panel2;
        private Button button8;
        private Button button4;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn ID_aula;
        private DataGridViewTextBoxColumn Materie;
        private DataGridViewTextBoxColumn Studenti;
        private TextBox textBox12;
        private Button BtnAddMateria;
        private TextBox TxtNuovaMateria;
        private Button BtnAggiungiMateria;
        private Button BtnClearMateria;
        private Button BtnDeleteMateria;
    }
}