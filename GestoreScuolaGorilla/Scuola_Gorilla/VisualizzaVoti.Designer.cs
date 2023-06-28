namespace Scuola_Gorilla
{
    partial class VisualizzaVoti
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
            TxtMatricola = new TextBox();
            LblMatricola = new Label();
            label1 = new Label();
            panel1 = new Panel();
            cbxMateria = new ComboBox();
            btnClearRows = new Button();
            btnVisualizza = new Button();
            dgwVoti = new DataGridView();
            Voti = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwVoti).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TxtMatricola
            // 
            TxtMatricola.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TxtMatricola.BackColor = Color.FromArgb(32, 30, 45);
            TxtMatricola.BorderStyle = BorderStyle.FixedSingle;
            TxtMatricola.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtMatricola.ForeColor = Color.White;
            TxtMatricola.Location = new Point(135, 27);
            TxtMatricola.Margin = new Padding(3, 5, 3, 5);
            TxtMatricola.Name = "TxtMatricola";
            TxtMatricola.Size = new Size(152, 29);
            TxtMatricola.TabIndex = 28;
            TxtMatricola.Text = "Inserisci Matricola";
            TxtMatricola.TextAlign = HorizontalAlignment.Center;
            TxtMatricola.MouseClick += TxtMatricola_MouseClick;
            TxtMatricola.TextChanged += TxtMatricola_TextChanged;
            TxtMatricola.Leave += TxtMatricola_Leave;
            // 
            // LblMatricola
            // 
            LblMatricola.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LblMatricola.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMatricola.ForeColor = Color.FromArgb(231, 61, 61);
            LblMatricola.Location = new Point(19, 29);
            LblMatricola.Name = "LblMatricola";
            LblMatricola.Size = new Size(109, 31);
            LblMatricola.TabIndex = 27;
            LblMatricola.Text = "Matricola";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 61, 61);
            label1.Location = new Point(357, 29);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 30;
            label1.Text = "Materia";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(cbxMateria);
            panel1.Controls.Add(btnClearRows);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVisualizza);
            panel1.Controls.Add(LblMatricola);
            panel1.Controls.Add(TxtMatricola);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 139);
            panel1.TabIndex = 0;
            // 
            // cbxMateria
            // 
            cbxMateria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbxMateria.BackColor = Color.FromArgb(32, 30, 45);
            cbxMateria.FlatStyle = FlatStyle.Flat;
            cbxMateria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbxMateria.ForeColor = SystemColors.Info;
            cbxMateria.FormattingEnabled = true;
            cbxMateria.Location = new Point(459, 25);
            cbxMateria.Name = "cbxMateria";
            cbxMateria.Size = new Size(151, 29);
            cbxMateria.TabIndex = 34;
            // 
            // btnClearRows
            // 
            btnClearRows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnClearRows.FlatAppearance.BorderSize = 0;
            btnClearRows.FlatStyle = FlatStyle.Flat;
            btnClearRows.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearRows.ForeColor = Color.FromArgb(231, 61, 61);
            btnClearRows.Location = new Point(357, 83);
            btnClearRows.Name = "btnClearRows";
            btnClearRows.Size = new Size(171, 51);
            btnClearRows.TabIndex = 33;
            btnClearRows.Text = "Svuota";
            btnClearRows.UseVisualStyleBackColor = true;
            btnClearRows.Click += btnClearRows_Click;
            btnClearRows.MouseEnter += btnClearRows_MouseEnter;
            btnClearRows.MouseLeave += btnClearRows_MouseLeave;
            // 
            // btnVisualizza
            // 
            btnVisualizza.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnVisualizza.FlatAppearance.BorderSize = 0;
            btnVisualizza.FlatStyle = FlatStyle.Flat;
            btnVisualizza.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizza.ForeColor = Color.FromArgb(231, 61, 61);
            btnVisualizza.Location = new Point(163, 83);
            btnVisualizza.Name = "btnVisualizza";
            btnVisualizza.Size = new Size(171, 51);
            btnVisualizza.TabIndex = 29;
            btnVisualizza.Text = "Visualizza";
            btnVisualizza.UseVisualStyleBackColor = true;
            btnVisualizza.Click += btnVisualizza_Click;
            btnVisualizza.MouseEnter += btnVisualizza_MouseEnter;
            btnVisualizza.MouseLeave += btnVisualizza_MouseLeave;
            // 
            // dgwVoti
            // 
            dgwVoti.AllowUserToAddRows = false;
            dgwVoti.AllowUserToDeleteRows = false;
            dgwVoti.AllowUserToResizeColumns = false;
            dgwVoti.AllowUserToResizeRows = false;
            dgwVoti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwVoti.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwVoti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwVoti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwVoti.Columns.AddRange(new DataGridViewColumn[] { Voti });
            dgwVoti.Dock = DockStyle.Fill;
            dgwVoti.Location = new Point(0, 0);
            dgwVoti.Name = "dgwVoti";
            dgwVoti.ReadOnly = true;
            dgwVoti.RowHeadersVisible = false;
            dgwVoti.RowHeadersWidth = 51;
            dgwVoti.RowTemplate.Height = 29;
            dgwVoti.Size = new Size(682, 314);
            dgwVoti.TabIndex = 1;
            // 
            // Voti
            // 
            Voti.HeaderText = "Voti";
            Voti.MinimumWidth = 6;
            Voti.Name = "Voti";
            Voti.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgwVoti);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 314);
            panel2.TabIndex = 2;
            // 
            // VisualizzaVoti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VisualizzaVoti";
            Text = "VisualizzaVoti";
            Load += VisualizzaVoti_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwVoti).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtMatricola;
        private Label LblMatricola;
        private Label label1;
        private Panel panel1;
        private Button btnClearRows;
        private Button btnVisualizza;
        private DataGridView dgwVoti;
        private Panel panel2;
        private ComboBox cbxMateria;
        private DataGridViewTextBoxColumn Voti;
    }
}