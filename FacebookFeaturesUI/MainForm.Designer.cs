using System.Drawing;

namespace FacebookFeaturesUI
{
    public partial class MainForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.panelAlbumDetails = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.tabPageFeatures = new System.Windows.Forms.TabPage();
            this.buttonAnalyzer = new FacebookFeaturesUI.AutoSizeSpecialButton();
            this.btnRecognizer = new FacebookFeaturesUI.BlinkingSpecialButton(Color.LightBlue, Color.AliceBlue);
            this.lblOption = new System.Windows.Forms.Label();
            this.buttonFetchData = new FacebookFeaturesUI.BlinkingSpecialButton(Color.Silver, Color.Snow);
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelAlbumDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.tabPageFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            createdTimeLabel.Location = new System.Drawing.Point(7, 39);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(117, 24);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            updateTimeLabel.Location = new System.Drawing.Point(7, 85);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(112, 24);
            updateTimeLabel.TabIndex = 7;
            updateTimeLabel.Text = "Update Time:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            countLabel.Location = new System.Drawing.Point(7, 125);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(62, 24);
            countLabel.TabIndex = 9;
            countLabel.Text = "Count:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            nameLabel.Location = new System.Drawing.Point(7, 3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(59, 24);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Name:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.Location = new System.Drawing.Point(6, 2);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(80, 24);
            this.birthdayLabel.TabIndex = 3;
            this.birthdayLabel.Text = "Birthday:";
            this.birthdayLabel.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(6, 34);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 24);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Visible = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Location = new System.Drawing.Point(9, 37);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(217, 269);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(9, 312);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(217, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseClick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(8, 5);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(131, 29);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Please login.";
            // 
            // buttonLogout
            // 
            this.buttonLogout.AutoSize = true;
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(9, 388);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(217, 36);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Controls.Add(this.tabPageFeatures);
            this.tabControl.Location = new System.Drawing.Point(239, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 669);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.AutoScroll = true;
            this.tabPageAbout.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageAbout.Controls.Add(this.birthdayLabel);
            this.tabPageAbout.Controls.Add(this.birthdayTextBox);
            this.tabPageAbout.Controls.Add(this.emailLabel);
            this.tabPageAbout.Controls.Add(this.emailTextBox);
            this.tabPageAbout.Controls.Add(this.panelAlbumDetails);
            this.tabPageAbout.Controls.Add(this.listViewImages);
            this.tabPageAbout.Controls.Add(this.listBoxAlbums);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 29);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(790, 636);
            this.tabPageAbout.TabIndex = 0;
            this.tabPageAbout.Text = "About";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(99, 7);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(227, 19);
            this.birthdayTextBox.TabIndex = 4;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(99, 39);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(227, 19);
            this.emailTextBox.TabIndex = 6;
            // 
            // panelAlbumDetails
            // 
            this.panelAlbumDetails.BackColor = System.Drawing.SystemColors.Control;
            this.panelAlbumDetails.Controls.Add(nameLabel);
            this.panelAlbumDetails.Controls.Add(this.nameTextBox);
            this.panelAlbumDetails.Controls.Add(countLabel);
            this.panelAlbumDetails.Controls.Add(this.countTextBox);
            this.panelAlbumDetails.Controls.Add(updateTimeLabel);
            this.panelAlbumDetails.Controls.Add(this.updateTimeDateTimePicker);
            this.panelAlbumDetails.Controls.Add(createdTimeLabel);
            this.panelAlbumDetails.Controls.Add(this.createdTimeDateTimePicker);
            this.panelAlbumDetails.Location = new System.Drawing.Point(318, 389);
            this.panelAlbumDetails.Name = "panelAlbumDetails";
            this.panelAlbumDetails.Size = new System.Drawing.Size(467, 238);
            this.panelAlbumDetails.TabIndex = 3;
            this.panelAlbumDetails.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(134, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(293, 26);
            this.nameTextBox.TabIndex = 12;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // countTextBox
            // 
            this.countTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(134, 125);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(293, 19);
            this.countTextBox.TabIndex = 10;
            // 
            // updateTimeDateTimePicker
            // 
            this.updateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "UpdateTime", true));
            this.updateTimeDateTimePicker.Enabled = false;
            this.updateTimeDateTimePicker.Location = new System.Drawing.Point(134, 80);
            this.updateTimeDateTimePicker.Name = "updateTimeDateTimePicker";
            this.updateTimeDateTimePicker.Size = new System.Drawing.Size(293, 26);
            this.updateTimeDateTimePicker.TabIndex = 8;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Enabled = false;
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(134, 38);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(293, 26);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // listViewImages
            // 
            this.listViewImages.BackColor = System.Drawing.SystemColors.Control;
            this.listViewImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewImages.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(318, 7);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(467, 376);
            this.listViewImages.TabIndex = 1;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxAlbums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 24;
            this.listBoxAlbums.Location = new System.Drawing.Point(6, 125);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(309, 504);
            this.listBoxAlbums.TabIndex = 0;
            // 
            // tabPageFeatures
            // 
            this.tabPageFeatures.BackgroundImage = global::FacebookFeaturesUI.Properties.Resources.facebook_livereactions;
            this.tabPageFeatures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageFeatures.Controls.Add(this.buttonAnalyzer);
            this.tabPageFeatures.Controls.Add(this.btnRecognizer);
            this.tabPageFeatures.Controls.Add(this.lblOption);
            this.tabPageFeatures.Location = new System.Drawing.Point(4, 29);
            this.tabPageFeatures.Name = "tabPageFeatures";
            this.tabPageFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFeatures.Size = new System.Drawing.Size(790, 636);
            this.tabPageFeatures.TabIndex = 1;
            this.tabPageFeatures.Text = "Features";
            this.tabPageFeatures.UseVisualStyleBackColor = true;
            // 
            // buttonAnalyzer
            // 
            this.buttonAnalyzer.AutoSize = true;
            this.buttonAnalyzer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalyzer.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAnalyzer.Location = new System.Drawing.Point(50, 234);
            this.buttonAnalyzer.Name = "buttonAnalyzer";
            this.buttonAnalyzer.Size = new System.Drawing.Size(331, 73);
            this.buttonAnalyzer.TabIndex = 8;
            this.buttonAnalyzer.Text = "Profile Analyzer";
            this.buttonAnalyzer.UseVisualStyleBackColor = false;
            this.buttonAnalyzer.Click += new System.EventHandler(this.buttonAnalyzer_Click);
            // 
            // btnRecognizer
            // 
            this.btnRecognizer.AutoSize = true;
            this.btnRecognizer.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecognizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecognizer.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecognizer.Location = new System.Drawing.Point(50, 108);
            this.btnRecognizer.Name = "btnRecognizer";
            this.btnRecognizer.Size = new System.Drawing.Size(331, 72);
            this.btnRecognizer.TabIndex = 7;
            this.btnRecognizer.Text = "Recognizer";
            this.btnRecognizer.UseVisualStyleBackColor = false;
            this.btnRecognizer.Click += new System.EventHandler(this.btnRecognizer_Click);
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.BackColor = System.Drawing.Color.Transparent;
            this.lblOption.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblOption.Location = new System.Drawing.Point(6, 38);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(412, 56);
            this.lblOption.TabIndex = 6;
            this.lblOption.Text = "Choose a feature:";
            // 
            // buttonFetchData
            // 
            this.buttonFetchData.AutoSize = true;
            this.buttonFetchData.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchData.Location = new System.Drawing.Point(9, 430);
            this.buttonFetchData.Name = "buttonFetchData";
            this.buttonFetchData.Size = new System.Drawing.Size(217, 34);
            this.buttonFetchData.TabIndex = 8;
            this.buttonFetchData.Text = "Fetch User Data";
            this.buttonFetchData.UseVisualStyleBackColor = true;
            this.buttonFetchData.Click += new System.EventHandler(this.buttonFetchData_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(13, 354);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(171, 28);
            this.checkBoxRememberMe.TabIndex = 9;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::FacebookFeaturesUI.Properties.Resources.facebook_social_network_design_logo_57578_1280x960;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 714);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonFetchData);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBoxProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Features";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelAlbumDetails.ResumeLayout(false);
            this.panelAlbumDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.tabPageFeatures.ResumeLayout(false);
            this.tabPageFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.TabPage tabPageFeatures;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private SpecialButton buttonFetchData;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Panel panelAlbumDetails;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.DateTimePicker updateTimeDateTimePicker;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label emailLabel;
        private SpecialButton buttonAnalyzer;
        private SpecialButton btnRecognizer;
    }
}
