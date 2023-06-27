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
            TxtMatricola = new TextBox();
            LblMatricola = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Voti = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            TxtMatricola.Location = new Point(128, 0);
            TxtMatricola.Margin = new Padding(3, 5, 3, 5);
            TxtMatricola.Name = "TxtMatricola";
            TxtMatricola.Size = new Size(152, 29);
            TxtMatricola.TabIndex = 28;
            TxtMatricola.Text = "Inserisci Matricola";
            TxtMatricola.TextAlign = HorizontalAlignment.Center;
            // 
            // LblMatricola
            // 
            LblMatricola.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            LblMatricola.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMatricola.ForeColor = Color.FromArgb(231, 61, 61);
            LblMatricola.Location = new Point(0, 0);
            LblMatricola.Name = "LblMatricola";
            LblMatricola.Size = new Size(109, 42);
            LblMatricola.TabIndex = 27;
            LblMatricola.Text = "Matricola";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.BackColor = Color.FromArgb(32, 30, 45);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(472, 0);
            textBox1.Margin = new Padding(3, 5, 3, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 29);
            textBox1.TabIndex = 31;
            textBox1.Text = "Inserisci Materia";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 61, 61);
            label1.Location = new Point(344, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 42);
            label1.TabIndex = 30;
            label1.Text = "Materia";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(LblMatricola);
            panel1.Controls.Add(TxtMatricola);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 138);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(231, 61, 61);
            button3.Location = new Point(352, 82);
            button3.Name = "button3";
            button3.Size = new Size(172, 50);
            button3.TabIndex = 33;
            button3.Text = "Svuota";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(231, 61, 61);
            button1.Location = new Point(158, 82);
            button1.Name = "button1";
            button1.Size = new Size(172, 50);
            button1.TabIndex = 29;
            button1.Text = "Visualizza";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Voti });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(672, 305);
            dataGridView1.TabIndex = 1;
            // 
            // Voti
            // 
            Voti.HeaderText = "Voti";
            Voti.MinimumWidth = 6;
            Voti.Name = "Voti";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 305);
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
            Padding = new Padding(10, 10, 0, 0);
            Text = "VisualizzaVoti";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox TxtMatricola;
        private Label LblMatricola;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Voti;
        private Panel panel2;
    }
}