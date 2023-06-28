namespace Scuola_Gorilla
{
    partial class VisualizzaClassi
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            cbxClasse = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            dgwStudenti = new DataGridView();
            Studenti = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            dgwMateria = new DataGridView();
            Materia = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwStudenti).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMateria).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(cbxClasse);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 94);
            panel1.TabIndex = 0;
            // 
            // cbxClasse
            // 
            cbxClasse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbxClasse.BackColor = Color.FromArgb(32, 30, 45);
            cbxClasse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxClasse.FlatStyle = FlatStyle.Flat;
            cbxClasse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbxClasse.ForeColor = SystemColors.Info;
            cbxClasse.FormattingEnabled = true;
            cbxClasse.Location = new Point(83, 28);
            cbxClasse.Margin = new Padding(3, 2, 3, 2);
            cbxClasse.Name = "cbxClasse";
            cbxClasse.Size = new Size(133, 25);
            cbxClasse.TabIndex = 36;
            cbxClasse.SelectedIndexChanged += cbxMateria_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 61, 61);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 35;
            label1.Text = "Classi";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dgwStudenti);
            panel2.Location = new Point(330, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 340);
            panel2.TabIndex = 1;
            // 
            // dgwStudenti
            // 
            dgwStudenti.AllowUserToAddRows = false;
            dgwStudenti.AllowUserToDeleteRows = false;
            dgwStudenti.AllowUserToResizeColumns = false;
            dgwStudenti.AllowUserToResizeRows = false;
            dgwStudenti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgwStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwStudenti.Columns.AddRange(new DataGridViewColumn[] { Studenti });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(38, 54, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(38, 54, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwStudenti.DefaultCellStyle = dataGridViewCellStyle2;
            dgwStudenti.Location = new Point(0, 0);
            dgwStudenti.Margin = new Padding(3, 2, 3, 2);
            dgwStudenti.Name = "dgwStudenti";
            dgwStudenti.ReadOnly = true;
            dgwStudenti.RowHeadersVisible = false;
            dgwStudenti.RowHeadersWidth = 51;
            dgwStudenti.RowTemplate.Height = 29;
            dgwStudenti.Size = new Size(267, 340);
            dgwStudenti.TabIndex = 38;
            // 
            // Studenti
            // 
            Studenti.HeaderText = "Studenti";
            Studenti.MinimumWidth = 6;
            Studenti.Name = "Studenti";
            Studenti.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Controls.Add(dgwMateria);
            panel3.Location = new Point(0, 98);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(298, 242);
            panel3.TabIndex = 0;
            // 
            // dgwMateria
            // 
            dgwMateria.AllowUserToAddRows = false;
            dgwMateria.AllowUserToDeleteRows = false;
            dgwMateria.AllowUserToResizeColumns = false;
            dgwMateria.AllowUserToResizeRows = false;
            dgwMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgwMateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwMateria.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgwMateria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgwMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMateria.Columns.AddRange(new DataGridViewColumn[] { Materia });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(38, 54, 80);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(38, 54, 80);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgwMateria.DefaultCellStyle = dataGridViewCellStyle4;
            dgwMateria.Location = new Point(0, 0);
            dgwMateria.Margin = new Padding(3, 2, 3, 2);
            dgwMateria.Name = "dgwMateria";
            dgwMateria.ReadOnly = true;
            dgwMateria.RowHeadersVisible = false;
            dgwMateria.RowHeadersWidth = 51;
            dgwMateria.RowTemplate.Height = 29;
            dgwMateria.Size = new Size(298, 242);
            dgwMateria.TabIndex = 37;
            dgwMateria.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Materia
            // 
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 6;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // VisualizzaClassi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(597, 340);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VisualizzaClassi";
            Text = "VisualizzaClassi";
            Load += VisualizzaClassi_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwStudenti).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox cbxClasse;
        private Label label1;
        private DataGridView dgwStudenti;
        private DataGridViewTextBoxColumn Studenti;
        private DataGridView dgwMateria;
        private DataGridViewTextBoxColumn Materia;
    }
}