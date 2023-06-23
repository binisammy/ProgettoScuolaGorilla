namespace Scuola_Gorilla
{
    partial class TrovaMatricola
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtClasse = new TextBox();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            btnCerca = new Button();
            txtMatricola = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 61, 61);
            label1.Location = new Point(65, 99);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 61, 61);
            label2.Location = new Point(244, 99);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Cognome";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(231, 61, 61);
            label3.Location = new Point(453, 99);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Classe";
            // 
            // txtClasse
            // 
            txtClasse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtClasse.BackColor = Color.FromArgb(23, 21, 32);
            txtClasse.BorderStyle = BorderStyle.FixedSingle;
            txtClasse.ForeColor = SystemColors.Info;
            txtClasse.Location = new Point(438, 135);
            txtClasse.Name = "txtClasse";
            txtClasse.Size = new Size(100, 23);
            txtClasse.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(23, 21, 32);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.ForeColor = SystemColors.Info;
            txtNome.Location = new Point(46, 135);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCognome
            // 
            txtCognome.Anchor = AnchorStyles.Top;
            txtCognome.BackColor = Color.FromArgb(23, 21, 32);
            txtCognome.BorderStyle = BorderStyle.FixedSingle;
            txtCognome.ForeColor = SystemColors.Info;
            txtCognome.Location = new Point(240, 135);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(100, 23);
            txtCognome.TabIndex = 5;
            // 
            // btnCerca
            // 
            btnCerca.Anchor = AnchorStyles.Bottom;
            btnCerca.Location = new Point(240, 289);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(100, 35);
            btnCerca.TabIndex = 6;
            btnCerca.Text = "Cerca";
            btnCerca.UseVisualStyleBackColor = true;
            btnCerca.Click += btnCerca_Click;
            // 
            // txtMatricola
            // 
            txtMatricola.Anchor = AnchorStyles.Bottom;
            txtMatricola.BackColor = Color.FromArgb(23, 21, 32);
            txtMatricola.BorderStyle = BorderStyle.FixedSingle;
            txtMatricola.ForeColor = SystemColors.Info;
            txtMatricola.Location = new Point(240, 247);
            txtMatricola.Name = "txtMatricola";
            txtMatricola.ReadOnly = true;
            txtMatricola.Size = new Size(100, 23);
            txtMatricola.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(231, 61, 61);
            label4.Location = new Point(247, 211);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Matricola";
            // 
            // TrovaMatricola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(596, 336);
            Controls.Add(txtMatricola);
            Controls.Add(label4);
            Controls.Add(btnCerca);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Controls.Add(txtClasse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(612, 375);
            Name = "TrovaMatricola";
            Text = "TrovaMatricola";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtClasse;
        private TextBox txtNome;
        private TextBox txtCognome;
        private Button btnCerca;
        private TextBox txtMatricola;
        private Label label4;
    }
}