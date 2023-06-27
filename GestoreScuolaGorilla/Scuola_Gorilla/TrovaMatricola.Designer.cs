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
            btnCerca = new Button();
            txtMatricola = new TextBox();
            label4 = new Label();
            txtClasse = new TextBox();
            label3 = new Label();
            txtCognome = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCerca
            // 
            btnCerca.Anchor = AnchorStyles.Bottom;
            btnCerca.Location = new Point(274, 385);
            btnCerca.Margin = new Padding(3, 4, 3, 4);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(114, 47);
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
            txtMatricola.Location = new Point(274, 329);
            txtMatricola.Margin = new Padding(3, 4, 3, 4);
            txtMatricola.Name = "txtMatricola";
            txtMatricola.ReadOnly = true;
            txtMatricola.Size = new Size(114, 27);
            txtMatricola.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(231, 61, 61);
            label4.Location = new Point(282, 281);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 7;
            label4.Text = "Matricola";
            // 
            // txtClasse
            // 
            txtClasse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtClasse.BackColor = Color.FromArgb(23, 21, 32);
            txtClasse.BorderStyle = BorderStyle.FixedSingle;
            txtClasse.ForeColor = SystemColors.Info;
            txtClasse.Location = new Point(501, 180);
            txtClasse.Margin = new Padding(3, 4, 3, 4);
            txtClasse.Name = "txtClasse";
            txtClasse.Size = new Size(114, 27);
            txtClasse.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(231, 61, 61);
            label3.Location = new Point(518, 132);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Classe";
            // 
            // txtCognome
            // 
            txtCognome.Anchor = AnchorStyles.Top;
            txtCognome.BackColor = Color.FromArgb(23, 21, 32);
            txtCognome.BorderStyle = BorderStyle.FixedSingle;
            txtCognome.ForeColor = SystemColors.Info;
            txtCognome.Location = new Point(274, 180);
            txtCognome.Margin = new Padding(3, 4, 3, 4);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(114, 27);
            txtCognome.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 61, 61);
            label2.Location = new Point(279, 132);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Cognome";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(23, 21, 32);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.ForeColor = SystemColors.Info;
            txtNome.Location = new Point(53, 180);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 61, 61);
            label1.Location = new Point(74, 132);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // TrovaMatricola
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(681, 448);
            Controls.Add(txtMatricola);
            Controls.Add(label4);
            Controls.Add(btnCerca);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Controls.Add(txtClasse);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(697, 484);
            Name = "TrovaMatricola";
            Text = "TrovaMatricola";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerca;
        private TextBox txtMatricola;
        private Label label4;
        private TextBox txtClasse;
        private Label label3;
        private TextBox txtCognome;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
    }
}