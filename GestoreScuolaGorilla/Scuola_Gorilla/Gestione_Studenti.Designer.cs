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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblClasse = new System.Windows.Forms.Label();
            this.LblMatricola = new System.Windows.Forms.Label();
            this.TxtMatricola = new System.Windows.Forms.TextBox();
            this.LblCognome = new System.Windows.Forms.Label();
            this.TxtCognome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.LblClasse);
            this.panel1.Controls.Add(this.LblMatricola);
            this.panel1.Controls.Add(this.TxtMatricola);
            this.panel1.Controls.Add(this.LblCognome);
            this.panel1.Controls.Add(this.TxtCognome);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 233);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B",
            "5A",
            "5B"});
            this.comboBox1.Location = new System.Drawing.Point(92, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // LblClasse
            // 
            this.LblClasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblClasse.AutoSize = true;
            this.LblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClasse.Location = new System.Drawing.Point(3, 135);
            this.LblClasse.Name = "LblClasse";
            this.LblClasse.Size = new System.Drawing.Size(59, 16);
            this.LblClasse.TabIndex = 23;
            this.LblClasse.Text = "Classe:";
            // 
            // LblMatricola
            // 
            this.LblMatricola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMatricola.AutoSize = true;
            this.LblMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatricola.Location = new System.Drawing.Point(1, 89);
            this.LblMatricola.Name = "LblMatricola";
            this.LblMatricola.Size = new System.Drawing.Size(75, 16);
            this.LblMatricola.TabIndex = 19;
            this.LblMatricola.Text = "Matricola:";
            // 
            // TxtMatricola
            // 
            this.TxtMatricola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricola.Location = new System.Drawing.Point(92, 86);
            this.TxtMatricola.Name = "TxtMatricola";
            this.TxtMatricola.Size = new System.Drawing.Size(133, 22);
            this.TxtMatricola.TabIndex = 20;
            this.TxtMatricola.Text = "Inserisci Matricola";
            this.TxtMatricola.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtMatricola_MouseClick);
            this.TxtMatricola.MouseLeave += new System.EventHandler(this.TxtMatricola_MouseLeave);
            // 
            // LblCognome
            // 
            this.LblCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCognome.AutoSize = true;
            this.LblCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCognome.Location = new System.Drawing.Point(1, 43);
            this.LblCognome.Name = "LblCognome";
            this.LblCognome.Size = new System.Drawing.Size(77, 16);
            this.LblCognome.TabIndex = 17;
            this.LblCognome.Text = "Cognome:";
            // 
            // TxtCognome
            // 
            this.TxtCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCognome.Location = new System.Drawing.Point(92, 40);
            this.TxtCognome.Name = "TxtCognome";
            this.TxtCognome.Size = new System.Drawing.Size(133, 22);
            this.TxtCognome.TabIndex = 18;
            this.TxtCognome.Text = "Inserisci Cognome";
            this.TxtCognome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCognome_MouseClick);
            this.TxtCognome.MouseLeave += new System.EventHandler(this.TxtCognome_MouseLeave);
            // 
            // LblNome
            // 
            this.LblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(1, 13);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(52, 16);
            this.LblNome.TabIndex = 15;
            this.LblNome.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(92, 7);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(133, 22);
            this.TxtNome.TabIndex = 16;
            this.TxtNome.Text = "Inserisci Nome";
            this.TxtNome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtNome_MouseClick);
            this.TxtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtNome.MouseLeave += new System.EventHandler(this.TxtNome_MouseLeave);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView3.Location = new System.Drawing.Point(304, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(378, 428);
            this.dataGridView3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 220);
            this.panel2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(4, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(4, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(4, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(4, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(304, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(378, 27);
            this.textBox11.TabIndex = 4;
            this.textBox11.Text = "Lista Studenti";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Matricola";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cognome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(4, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 26);
            this.button5.TabIndex = 12;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Gestione_Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Gestione_Studenti";
            this.Text = "Gestione Studenti";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblClasse;
        private System.Windows.Forms.Label LblMatricola;
        private System.Windows.Forms.TextBox TxtMatricola;
        private System.Windows.Forms.Label LblCognome;
        private System.Windows.Forms.TextBox TxtCognome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button5;
    }
}