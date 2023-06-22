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
            panel2 = new Panel();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
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
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgwVoti).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(1, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 182);
            panel2.TabIndex = 9;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Location = new Point(0, 93);
            button8.Name = "button8";
            button8.Size = new Size(129, 24);
            button8.TabIndex = 7;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(1, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 24);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(1, 33);
            button2.Name = "button2";
            button2.Size = new Size(129, 24);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(1, 63);
            button3.Name = "button3";
            button3.Size = new Size(129, 24);
            button3.TabIndex = 10;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(CbxMateria);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(LblMatricola);
            panel1.Controls.Add(TxtMatricola);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 241);
            panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 75;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "0", "0.5", "1", "1.5", "2", "2.5", "3", "3.5", "4", "4.5", "5", "5.5", "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10" });
            comboBox1.Location = new Point(83, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 23);
            comboBox1.TabIndex = 34;
            // 
            // CbxMateria
            // 
            CbxMateria.Anchor = AnchorStyles.None;
            CbxMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxMateria.FormattingEnabled = true;
            CbxMateria.Location = new Point(83, 50);
            CbxMateria.Name = "CbxMateria";
            CbxMateria.Size = new Size(126, 23);
            CbxMateria.TabIndex = 33;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(3, 94);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 32;
            label13.Text = "Voto:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(4, 54);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 31;
            label16.Text = "Materia:";
            // 
            // LblMatricola
            // 
            LblMatricola.Anchor = AnchorStyles.None;
            LblMatricola.AutoSize = true;
            LblMatricola.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            LblMatricola.Location = new Point(1, 18);
            LblMatricola.Name = "LblMatricola";
            LblMatricola.Size = new Size(63, 13);
            LblMatricola.TabIndex = 25;
            LblMatricola.Text = "Matricola:";
            // 
            // TxtMatricola
            // 
            TxtMatricola.Anchor = AnchorStyles.None;
            TxtMatricola.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMatricola.Location = new Point(83, 13);
            TxtMatricola.Name = "TxtMatricola";
            TxtMatricola.Size = new Size(126, 19);
            TxtMatricola.TabIndex = 26;
            TxtMatricola.Text = "Inserisci Matricola";
            TxtMatricola.MouseClick += TxtMatricola_MouseClick;
            TxtMatricola.TextChanged += TxtMatricola_TextChanged;
            TxtMatricola.MouseLeave += TxtMatricola_MouseLeave;
            // 
            // textBox12
            // 
            textBox12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(262, 1);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(334, 23);
            textBox12.TabIndex = 36;
            textBox12.Text = "Voti Studente";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // DgwVoti
            // 
            DgwVoti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgwVoti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgwVoti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgwVoti.Columns.AddRange(new DataGridViewColumn[] { Materie, Voti });
            DgwVoti.Location = new Point(262, 26);
            DgwVoti.Name = "DgwVoti";
            DgwVoti.RowHeadersWidth = 51;
            DgwVoti.RowTemplate.Height = 24;
            DgwVoti.Size = new Size(333, 397);
            DgwVoti.TabIndex = 35;
            // 
            // Materie
            // 
            Materie.HeaderText = "Materie";
            Materie.MinimumWidth = 6;
            Materie.Name = "Materie";
            // 
            // Voti
            // 
            Voti.HeaderText = "Voti";
            Voti.MinimumWidth = 6;
            Voti.Name = "Voti";
            // 
            // Gestione_Voti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(598, 432);
            Controls.Add(textBox12);
            Controls.Add(panel2);
            Controls.Add(DgwVoti);
            Controls.Add(panel1);
            MinimumSize = new Size(614, 471);
            Name = "Gestione_Voti";
            Text = " ";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgwVoti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label LblMatricola;
        private TextBox TxtMatricola;
        private ComboBox CbxMateria;
        private Label label13;
        private Label label16;
        private TextBox textBox12;
        private DataGridView DgwVoti;
        private DataGridViewTextBoxColumn Materie;
        private DataGridViewTextBoxColumn Voti;
        private ComboBox comboBox1;
    }
}