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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.LabelInput = new System.Windows.Forms.Label();
            this.LabelInputHelp = new System.Windows.Forms.Label();
            this.PersonaNameLabel = new System.Windows.Forms.Label();
            this.SteamIDError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SteamIDError)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(315, 183);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(150, 23);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.Tag = "IDInput";
            this.IDTextBox.Text = "\r\n";
            this.IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(355, 212);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Sök";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LabelInput
            // 
            this.LabelInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelInput.AutoSize = true;
            this.LabelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInput.Location = new System.Drawing.Point(265, 140);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(253, 24);
            this.LabelInput.TabIndex = 2;
            this.LabelInput.Text = "Skriv in din 64-bit SteamID";
            // 
            // LabelInputHelp
            // 
            this.LabelInputHelp.AutoSize = true;
            this.LabelInputHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelInputHelp.Location = new System.Drawing.Point(161, 376);
            this.LabelInputHelp.Name = "LabelInputHelp";
            this.LabelInputHelp.Size = new System.Drawing.Size(504, 13);
            this.LabelInputHelp.TabIndex = 3;
            this.LabelInputHelp.Text = "Om du inte vet ditt SteamId64 kan du klicka här och komma in på SteamIDFinder och" +
    " söka upp ditt konto";
            this.LabelInputHelp.Click += new System.EventHandler(this.SteamIDFinder);
            // 
            // PersonaNameLabel
            // 
            this.PersonaNameLabel.AutoSize = true;
            this.PersonaNameLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonaNameLabel.Location = new System.Drawing.Point(286, 20);
            this.PersonaNameLabel.Name = "PersonaNameLabel";
            this.PersonaNameLabel.Size = new System.Drawing.Size(0, 36);
            this.PersonaNameLabel.TabIndex = 4;
            // 
            // SteamIDError
            // 
            this.SteamIDError.ContainerControl = this;
            // 
            // SlutprojektSteamIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PersonaNameLabel);
            this.Controls.Add(this.LabelInputHelp);
            this.Controls.Add(this.LabelInput);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.IDTextBox);
            this.Name = "SlutprojektSteamIDForm";
            this.Text = "SlutprojektSteamIDForm";
            ((System.ComponentModel.ISupportInitialize)(this.SteamIDError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Label LabelInputHelp;
        private System.Windows.Forms.Label PersonaNameLabel;
        private System.Windows.Forms.ErrorProvider SteamIDError;
    }
}

