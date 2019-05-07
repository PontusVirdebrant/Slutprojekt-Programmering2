namespace SlutprojektAPI
{
    partial class SlutprojektSteamIDForm
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
            this.components = new System.ComponentModel.Container();
            this.SteamIDError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelStart = new System.Windows.Forms.Panel();
            this.LiteSearchButton = new System.Windows.Forms.Button();
            this.LabelInputHelp = new System.Windows.Forms.Label();
            this.LabelInput = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.panelVisaData = new System.Windows.Forms.Panel();
            this.ButtonVänlista = new System.Windows.Forms.Button();
            this.TimeCreated = new System.Windows.Forms.Label();
            this.RealName = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.PrivatKontoLabel = new System.Windows.Forms.Label();
            this.PersonaNameLabel = new System.Windows.Forms.Label();
            this.ProfilePicture184 = new System.Windows.Forms.PictureBox();
            this.FriendsListError = new System.Windows.Forms.ErrorProvider(this.components);
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.ResetButton1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ButtonLocalSave = new System.Windows.Forms.Button();
            this.panelVänlista = new System.Windows.Forms.Panel();
            this.PersonaNameLabel1 = new System.Windows.Forms.Label();
            this.buttonOidLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SteamIDError)).BeginInit();
            this.panelStart.SuspendLayout();
            this.panelVisaData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture184)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsListError)).BeginInit();
            this.panelVänlista.SuspendLayout();
            this.SuspendLayout();
            // 
            // SteamIDError
            // 
            this.SteamIDError.ContainerControl = this;
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.buttonOidLogin);
            this.panelStart.Controls.Add(this.LiteSearchButton);
            this.panelStart.Controls.Add(this.LabelInputHelp);
            this.panelStart.Controls.Add(this.LabelInput);
            this.panelStart.Controls.Add(this.StartButton);
            this.panelStart.Controls.Add(this.IDTextBox);
            this.panelStart.Location = new System.Drawing.Point(0, 0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(800, 450);
            this.panelStart.TabIndex = 0;
            // 
            // LiteSearchButton
            // 
            this.LiteSearchButton.Location = new System.Drawing.Point(386, 183);
            this.LiteSearchButton.Name = "LiteSearchButton";
            this.LiteSearchButton.Size = new System.Drawing.Size(65, 23);
            this.LiteSearchButton.TabIndex = 9;
            this.LiteSearchButton.Text = "SnabbSök";
            this.LiteSearchButton.UseVisualStyleBackColor = true;
            this.LiteSearchButton.Click += new System.EventHandler(this.LiteSearchButton_Click);
            // 
            // LabelInputHelp
            // 
            this.LabelInputHelp.AutoSize = true;
            this.LabelInputHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelInputHelp.Location = new System.Drawing.Point(134, 371);
            this.LabelInputHelp.Name = "LabelInputHelp";
            this.LabelInputHelp.Size = new System.Drawing.Size(504, 13);
            this.LabelInputHelp.TabIndex = 8;
            this.LabelInputHelp.Text = "Om du inte vet ditt SteamId64 kan du klicka här och komma in på SteamIDFinder och" +
    " söka upp ditt konto";
            this.LabelInputHelp.Click += new System.EventHandler(this.LabelInputHelp_Click);
            // 
            // LabelInput
            // 
            this.LabelInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelInput.AutoSize = true;
            this.LabelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInput.Location = new System.Drawing.Point(252, 97);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(253, 24);
            this.LabelInput.TabIndex = 7;
            this.LabelInput.Text = "Skriv in din 64-bit SteamID";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(271, 183);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "StandardSökning";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(271, 154);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(180, 23);
            this.IDTextBox.TabIndex = 5;
            this.IDTextBox.Tag = "IDInput";
            this.IDTextBox.Text = "\r\n";
            this.IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelVisaData
            // 
            this.panelVisaData.Controls.Add(this.ButtonVänlista);
            this.panelVisaData.Controls.Add(this.TimeCreated);
            this.panelVisaData.Controls.Add(this.RealName);
            this.panelVisaData.Controls.Add(this.ResetButton);
            this.panelVisaData.Controls.Add(this.PrivatKontoLabel);
            this.panelVisaData.Controls.Add(this.PersonaNameLabel);
            this.panelVisaData.Controls.Add(this.ProfilePicture184);
            this.panelVisaData.Location = new System.Drawing.Point(0, 0);
            this.panelVisaData.Name = "panelVisaData";
            this.panelVisaData.Size = new System.Drawing.Size(800, 450);
            this.panelVisaData.TabIndex = 1;
            this.panelVisaData.Visible = false;
            // 
            // ButtonVänlista
            // 
            this.ButtonVänlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVänlista.Location = new System.Drawing.Point(663, 178);
            this.ButtonVänlista.Name = "ButtonVänlista";
            this.ButtonVänlista.Size = new System.Drawing.Size(110, 52);
            this.ButtonVänlista.TabIndex = 16;
            this.ButtonVänlista.Text = "Vänlista";
            this.ButtonVänlista.UseVisualStyleBackColor = true;
            this.ButtonVänlista.Click += new System.EventHandler(this.ButtonVänlista_Click);
            // 
            // TimeCreated
            // 
            this.TimeCreated.AutoSize = true;
            this.TimeCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCreated.Location = new System.Drawing.Point(30, 178);
            this.TimeCreated.Name = "TimeCreated";
            this.TimeCreated.Size = new System.Drawing.Size(0, 25);
            this.TimeCreated.TabIndex = 15;
            // 
            // RealName
            // 
            this.RealName.AutoSize = true;
            this.RealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealName.Location = new System.Drawing.Point(25, 97);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(0, 25);
            this.RealName.TabIndex = 14;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(663, 332);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 52);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Tillbaka";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PrivatKontoLabel
            // 
            this.PrivatKontoLabel.AutoSize = true;
            this.PrivatKontoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivatKontoLabel.Location = new System.Drawing.Point(30, 90);
            this.PrivatKontoLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.PrivatKontoLabel.Name = "PrivatKontoLabel";
            this.PrivatKontoLabel.Size = new System.Drawing.Size(0, 29);
            this.PrivatKontoLabel.TabIndex = 11;
            // 
            // PersonaNameLabel
            // 
            this.PersonaNameLabel.AutoSize = true;
            this.PersonaNameLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonaNameLabel.Location = new System.Drawing.Point(30, 30);
            this.PersonaNameLabel.Name = "PersonaNameLabel";
            this.PersonaNameLabel.Size = new System.Drawing.Size(0, 36);
            this.PersonaNameLabel.TabIndex = 10;
            // 
            // ProfilePicture184
            // 
            this.ProfilePicture184.Location = new System.Drawing.Point(30, 214);
            this.ProfilePicture184.Name = "ProfilePicture184";
            this.ProfilePicture184.Size = new System.Drawing.Size(184, 184);
            this.ProfilePicture184.TabIndex = 12;
            this.ProfilePicture184.TabStop = false;
            this.ProfilePicture184.Visible = false;
            // 
            // FriendsListError
            // 
            this.FriendsListError.ContainerControl = this;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.Location = new System.Drawing.Point(30, 69);
            this.FriendsListBox.MultiColumn = true;
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(627, 329);
            this.FriendsListBox.TabIndex = 15;
            this.FriendsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FriendsListBox_MouseDoubleClick);
            // 
            // ResetButton1
            // 
            this.ResetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton1.Location = new System.Drawing.Point(663, 332);
            this.ResetButton1.Name = "ResetButton1";
            this.ResetButton1.Size = new System.Drawing.Size(110, 52);
            this.ResetButton1.TabIndex = 14;
            this.ResetButton1.Text = "Tillbaka";
            this.ResetButton1.UseVisualStyleBackColor = true;
            this.ResetButton1.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(663, 178);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 52);
            this.BackButton.TabIndex = 17;
            this.BackButton.Text = "Personlig";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ButtonLocalSave
            // 
            this.ButtonLocalSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLocalSave.Location = new System.Drawing.Point(663, 42);
            this.ButtonLocalSave.Name = "ButtonLocalSave";
            this.ButtonLocalSave.Size = new System.Drawing.Size(110, 52);
            this.ButtonLocalSave.TabIndex = 18;
            this.ButtonLocalSave.Text = "SparaList";
            this.ButtonLocalSave.UseVisualStyleBackColor = true;
            this.ButtonLocalSave.Click += new System.EventHandler(this.ButtonLocalSave_Click);
            // 
            // panelVänlista
            // 
            this.panelVänlista.Controls.Add(this.PersonaNameLabel1);
            this.panelVänlista.Controls.Add(this.ButtonLocalSave);
            this.panelVänlista.Controls.Add(this.BackButton);
            this.panelVänlista.Controls.Add(this.ResetButton1);
            this.panelVänlista.Controls.Add(this.FriendsListBox);
            this.panelVänlista.Location = new System.Drawing.Point(0, 0);
            this.panelVänlista.Name = "panelVänlista";
            this.panelVänlista.Size = new System.Drawing.Size(800, 450);
            this.panelVänlista.TabIndex = 17;
            this.panelVänlista.Visible = false;
            // 
            // PersonaNameLabel1
            // 
            this.PersonaNameLabel1.AutoSize = true;
            this.PersonaNameLabel1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonaNameLabel1.Location = new System.Drawing.Point(30, 30);
            this.PersonaNameLabel1.Name = "PersonaNameLabel1";
            this.PersonaNameLabel1.Size = new System.Drawing.Size(0, 36);
            this.PersonaNameLabel1.TabIndex = 19;
            // 
            // buttonOidLogin
            // 
            this.buttonOidLogin.Image = global::SlutprojektAPI.Properties.Resources.SteamLogin;
            this.buttonOidLogin.Location = new System.Drawing.Point(664, 12);
            this.buttonOidLogin.Name = "buttonOidLogin";
            this.buttonOidLogin.Size = new System.Drawing.Size(109, 66);
            this.buttonOidLogin.TabIndex = 10;
            this.buttonOidLogin.UseVisualStyleBackColor = true;
            this.buttonOidLogin.Click += new System.EventHandler(this.buttonOidLogin_Click);
            // 
            // SlutprojektSteamIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panelVänlista);
            this.Controls.Add(this.panelVisaData);
            this.Name = "SlutprojektSteamIDForm";
            this.Text = "SlutprojektSteamIDForm";
            ((System.ComponentModel.ISupportInitialize)(this.SteamIDError)).EndInit();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelVisaData.ResumeLayout(false);
            this.panelVisaData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture184)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsListError)).EndInit();
            this.panelVänlista.ResumeLayout(false);
            this.panelVänlista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider SteamIDError;
        private System.Windows.Forms.Label LabelInputHelp;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Panel panelVisaData;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Label PersonaNameLabel;
        private System.Windows.Forms.Label PrivatKontoLabel;
        private System.Windows.Forms.PictureBox ProfilePicture184;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label RealName;
        private System.Windows.Forms.Label TimeCreated;
        private System.Windows.Forms.Button ButtonVänlista;
        private System.Windows.Forms.Button LiteSearchButton;
        private System.Windows.Forms.ErrorProvider FriendsListError;
        private System.Windows.Forms.Panel panelVänlista;
        private System.Windows.Forms.Button ButtonLocalSave;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ResetButton1;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Label PersonaNameLabel1;
        private System.Windows.Forms.Button buttonOidLogin;
    }
}

