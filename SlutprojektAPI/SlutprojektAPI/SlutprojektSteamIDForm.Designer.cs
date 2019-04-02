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
            this.ProfilePicture64 = new System.Windows.Forms.PictureBox();
            this.panelVänlista = new System.Windows.Forms.Panel();
            this.ResetButton1 = new System.Windows.Forms.Button();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.SteamIDError)).BeginInit();
            this.panelStart.SuspendLayout();
            this.panelVisaData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture64)).BeginInit();
            this.panelVänlista.SuspendLayout();
            this.SuspendLayout();
            // 
            // SteamIDError
            // 
            this.SteamIDError.ContainerControl = this;
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.LabelInputHelp);
            this.panelStart.Controls.Add(this.LabelInput);
            this.panelStart.Controls.Add(this.StartButton);
            this.panelStart.Controls.Add(this.IDTextBox);
            this.panelStart.Location = new System.Drawing.Point(13, 12);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(775, 425);
            this.panelStart.TabIndex = 0;
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
            this.LabelInput.Location = new System.Drawing.Point(239, 97);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(253, 24);
            this.LabelInput.TabIndex = 7;
            this.LabelInput.Text = "Skriv in din 64-bit SteamID";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(328, 207);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Sök";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(288, 178);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(150, 23);
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
            this.panelVisaData.Controls.Add(this.ProfilePicture64);
            this.panelVisaData.Location = new System.Drawing.Point(12, 12);
            this.panelVisaData.Name = "panelVisaData";
            this.panelVisaData.Size = new System.Drawing.Size(776, 426);
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
            this.TimeCreated.Location = new System.Drawing.Point(30, 207);
            this.TimeCreated.Name = "TimeCreated";
            this.TimeCreated.Size = new System.Drawing.Size(0, 25);
            this.TimeCreated.TabIndex = 15;
            // 
            // RealName
            // 
            this.RealName.AutoSize = true;
            this.RealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealName.Location = new System.Drawing.Point(30, 161);
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
            // ProfilePicture64
            // 
            this.ProfilePicture64.Location = new System.Drawing.Point(30, 90);
            this.ProfilePicture64.Name = "ProfilePicture64";
            this.ProfilePicture64.Size = new System.Drawing.Size(64, 64);
            this.ProfilePicture64.TabIndex = 12;
            this.ProfilePicture64.TabStop = false;
            this.ProfilePicture64.Visible = false;
            // 
            // panelVänlista
            // 
            this.panelVänlista.Controls.Add(this.ResetButton1);
            this.panelVänlista.Controls.Add(this.FriendsListBox);
            this.panelVänlista.Location = new System.Drawing.Point(12, 12);
            this.panelVänlista.Name = "panelVänlista";
            this.panelVänlista.Size = new System.Drawing.Size(776, 426);
            this.panelVänlista.TabIndex = 17;
            this.panelVänlista.Visible = false;
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
            // FriendsListBox
            // 
            this.FriendsListBox.Location = new System.Drawing.Point(30, 30);
            this.FriendsListBox.MultiColumn = true;
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(627, 368);
            this.FriendsListBox.TabIndex = 15;
            // 
            // SlutprojektSteamIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelVänlista);
            this.Controls.Add(this.panelVisaData);
            this.Controls.Add(this.panelStart);
            this.Name = "SlutprojektSteamIDForm";
            this.Text = "SlutprojektSteamIDForm";
            ((System.ComponentModel.ISupportInitialize)(this.SteamIDError)).EndInit();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelVisaData.ResumeLayout(false);
            this.panelVisaData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture64)).EndInit();
            this.panelVänlista.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox ProfilePicture64;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label RealName;
        private System.Windows.Forms.Label TimeCreated;
        private System.Windows.Forms.Button ButtonVänlista;
        private System.Windows.Forms.Panel panelVänlista;
        private System.Windows.Forms.Button ResetButton1;
        private System.Windows.Forms.ListBox FriendsListBox;
    }
}

