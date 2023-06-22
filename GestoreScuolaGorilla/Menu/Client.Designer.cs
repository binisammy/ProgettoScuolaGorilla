namespace Menu
{
    partial class Client
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            panelSidemenu = new Panel();
            btnCerca = new Button();
            panelVisuaizza = new Panel();
            button5 = new Button();
            Buttn6 = new Button();
            btnVisualizza = new Button();
            button1 = new Button();
            panelAggiungiMenu = new Panel();
            btnStudente = new Button();
            btnMateria = new Button();
            btnClasse = new Button();
            btnAggiungi = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panelPlayer = new Panel();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panelSidemenu.SuspendLayout();
            panelVisuaizza.SuspendLayout();
            panelAggiungiMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSidemenu
            // 
            panelSidemenu.AutoScroll = true;
            panelSidemenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSidemenu.Controls.Add(btnCerca);
            panelSidemenu.Controls.Add(panelVisuaizza);
            panelSidemenu.Controls.Add(btnVisualizza);
            panelSidemenu.Controls.Add(button1);
            panelSidemenu.Controls.Add(panelAggiungiMenu);
            panelSidemenu.Controls.Add(btnAggiungi);
            panelSidemenu.Controls.Add(btnHome);
            panelSidemenu.Controls.Add(panelLogo);
            panelSidemenu.Dock = DockStyle.Left;
            panelSidemenu.ForeColor = Color.White;
            panelSidemenu.Location = new Point(0, 0);
            panelSidemenu.Name = "panelSidemenu";
            panelSidemenu.Size = new Size(250, 608);
            panelSidemenu.TabIndex = 0;
            // 
            // btnCerca
            // 
            btnCerca.Dock = DockStyle.Top;
            btnCerca.FlatAppearance.BorderSize = 0;
            btnCerca.FlatStyle = FlatStyle.Flat;
            btnCerca.ForeColor = Color.White;
            btnCerca.Image = (Image)resources.GetObject("btnCerca.Image");
            btnCerca.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerca.Location = new Point(0, 450);
            btnCerca.Name = "btnCerca";
            btnCerca.Padding = new Padding(10, 0, 0, 0);
            btnCerca.Size = new Size(250, 40);
            btnCerca.TabIndex = 8;
            btnCerca.Text = "Cerca";
            btnCerca.TextAlign = ContentAlignment.MiddleLeft;
            btnCerca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerca.UseVisualStyleBackColor = true;
            // 
            // panelVisuaizza
            // 
            panelVisuaizza.BackColor = Color.FromArgb(35, 32, 39);
            panelVisuaizza.Controls.Add(button5);
            panelVisuaizza.Controls.Add(Buttn6);
            panelVisuaizza.Dock = DockStyle.Top;
            panelVisuaizza.Location = new Point(0, 367);
            panelVisuaizza.Name = "panelVisuaizza";
            panelVisuaizza.Size = new Size(250, 83);
            panelVisuaizza.TabIndex = 7;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 40);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(250, 40);
            button5.TabIndex = 5;
            button5.Text = "Voto";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // Buttn6
            // 
            Buttn6.Dock = DockStyle.Top;
            Buttn6.FlatAppearance.BorderSize = 0;
            Buttn6.FlatStyle = FlatStyle.Flat;
            Buttn6.ForeColor = Color.White;
            Buttn6.Image = Properties.Resources.Line;
            Buttn6.ImageAlign = ContentAlignment.MiddleLeft;
            Buttn6.Location = new Point(0, 0);
            Buttn6.Name = "Buttn6";
            Buttn6.Padding = new Padding(35, 0, 0, 0);
            Buttn6.Size = new Size(250, 40);
            Buttn6.TabIndex = 4;
            Buttn6.Text = "Classe e Materie";
            Buttn6.TextAlign = ContentAlignment.MiddleLeft;
            Buttn6.TextImageRelation = TextImageRelation.ImageBeforeText;
            Buttn6.UseVisualStyleBackColor = true;
            // 
            // btnVisualizza
            // 
            btnVisualizza.Dock = DockStyle.Top;
            btnVisualizza.FlatAppearance.BorderSize = 0;
            btnVisualizza.FlatStyle = FlatStyle.Flat;
            btnVisualizza.ForeColor = Color.White;
            btnVisualizza.Image = (Image)resources.GetObject("btnVisualizza.Image");
            btnVisualizza.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisualizza.Location = new Point(0, 327);
            btnVisualizza.Name = "btnVisualizza";
            btnVisualizza.Padding = new Padding(10, 0, 0, 0);
            btnVisualizza.Size = new Size(250, 40);
            btnVisualizza.TabIndex = 6;
            btnVisualizza.Text = "Visualizza";
            btnVisualizza.TextAlign = ContentAlignment.MiddleLeft;
            btnVisualizza.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizza.UseVisualStyleBackColor = true;
            btnVisualizza.Click += btnVisualizza_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 568);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(250, 40);
            button1.TabIndex = 5;
            button1.Text = "Esci";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelAggiungiMenu
            // 
            panelAggiungiMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelAggiungiMenu.Controls.Add(btnStudente);
            panelAggiungiMenu.Controls.Add(btnMateria);
            panelAggiungiMenu.Controls.Add(btnClasse);
            panelAggiungiMenu.Dock = DockStyle.Top;
            panelAggiungiMenu.Location = new Point(0, 205);
            panelAggiungiMenu.Name = "panelAggiungiMenu";
            panelAggiungiMenu.Size = new Size(250, 122);
            panelAggiungiMenu.TabIndex = 4;
            // 
            // btnStudente
            // 
            btnStudente.Dock = DockStyle.Top;
            btnStudente.FlatAppearance.BorderSize = 0;
            btnStudente.FlatStyle = FlatStyle.Flat;
            btnStudente.ForeColor = Color.White;
            btnStudente.Image = (Image)resources.GetObject("btnStudente.Image");
            btnStudente.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudente.Location = new Point(0, 80);
            btnStudente.Name = "btnStudente";
            btnStudente.Padding = new Padding(35, 0, 0, 0);
            btnStudente.Size = new Size(250, 40);
            btnStudente.TabIndex = 6;
            btnStudente.Text = "Studente";
            btnStudente.TextAlign = ContentAlignment.MiddleLeft;
            btnStudente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudente.UseVisualStyleBackColor = true;
            btnStudente.Click += btnStudente_Click;
            // 
            // btnMateria
            // 
            btnMateria.Dock = DockStyle.Top;
            btnMateria.FlatAppearance.BorderSize = 0;
            btnMateria.FlatStyle = FlatStyle.Flat;
            btnMateria.ForeColor = Color.White;
            btnMateria.Image = (Image)resources.GetObject("btnMateria.Image");
            btnMateria.ImageAlign = ContentAlignment.MiddleLeft;
            btnMateria.Location = new Point(0, 40);
            btnMateria.Name = "btnMateria";
            btnMateria.Padding = new Padding(35, 0, 0, 0);
            btnMateria.Size = new Size(250, 40);
            btnMateria.TabIndex = 5;
            btnMateria.Text = "Voto";
            btnMateria.TextAlign = ContentAlignment.MiddleLeft;
            btnMateria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMateria.UseVisualStyleBackColor = true;
            btnMateria.Click += btnMateria_Click;
            // 
            // btnClasse
            // 
            btnClasse.Dock = DockStyle.Top;
            btnClasse.FlatAppearance.BorderSize = 0;
            btnClasse.FlatStyle = FlatStyle.Flat;
            btnClasse.ForeColor = Color.White;
            btnClasse.Image = Properties.Resources.Line;
            btnClasse.ImageAlign = ContentAlignment.MiddleLeft;
            btnClasse.Location = new Point(0, 0);
            btnClasse.Name = "btnClasse";
            btnClasse.Padding = new Padding(35, 0, 0, 0);
            btnClasse.Size = new Size(250, 40);
            btnClasse.TabIndex = 4;
            btnClasse.Text = "Classe e Materie";
            btnClasse.TextAlign = ContentAlignment.MiddleLeft;
            btnClasse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClasse.UseVisualStyleBackColor = true;
            btnClasse.Click += btnClasse_Click;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Dock = DockStyle.Top;
            btnAggiungi.FlatAppearance.BorderSize = 0;
            btnAggiungi.FlatStyle = FlatStyle.Flat;
            btnAggiungi.ForeColor = Color.White;
            btnAggiungi.Image = (Image)resources.GetObject("btnAggiungi.Image");
            btnAggiungi.ImageAlign = ContentAlignment.MiddleLeft;
            btnAggiungi.Location = new Point(0, 165);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Padding = new Padding(10, 0, 0, 0);
            btnAggiungi.Size = new Size(250, 40);
            btnAggiungi.TabIndex = 3;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.TextAlign = ContentAlignment.MiddleLeft;
            btnAggiungi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnHome
            // 
            btnHome.AutoSize = true;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 125);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(250, 40);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label2);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 125);
            panelLogo.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 90);
            label2.Name = "label2";
            label2.Size = new Size(207, 45);
            label2.TabIndex = 2;
            label2.Text = "Scuola Gorilla";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(23, 21, 32);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(250, 508);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(702, 100);
            panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.AutoSize = true;
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.BackgroundImageLayout = ImageLayout.Center;
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(702, 508);
            panelChildForm.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(212, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 608);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSidemenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(968, 647);
            Name = "Client";
            Text = "Scuola Gorilla";
            panelSidemenu.ResumeLayout(false);
            panelSidemenu.PerformLayout();
            panelVisuaizza.ResumeLayout(false);
            panelAggiungiMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidemenu;
        private Panel panelAggiungiMenu;
        private Button btnStudente;
        private Button btnMateria;
        private Button btnClasse;
        private Button btnAggiungi;
        private Button btnHome;
        private Panel panelLogo;
        private Panel panelPlayer;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label2;
        private Panel panelVisuaizza;
        private Button button5;
        private Button Buttn6;
        private Button btnVisualizza;
        private Button btnCerca;
    }
}

