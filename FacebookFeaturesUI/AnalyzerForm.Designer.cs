namespace FacebookFeaturesUI
{
    public partial class AnalyzerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzerForm));
            this.buttonAnalyzer = new System.Windows.Forms.Button();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.labelActiveUser = new System.Windows.Forms.Label();
            this.labelNonActiveUser = new System.Windows.Forms.Label();
            this.listBoxActive = new System.Windows.Forms.ListBox();
            this.listBoxNotActive = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelImages = new System.Windows.Forms.Label();
            this.buttonLikeImage = new System.Windows.Forms.Button();
            this.buttonLikePost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnalyzer
            // 
            this.buttonAnalyzer.AutoSize = true;
            this.buttonAnalyzer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAnalyzer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalyzer.Location = new System.Drawing.Point(22, 8);
            this.buttonAnalyzer.Name = "buttonAnalyzer";
            this.buttonAnalyzer.Size = new System.Drawing.Size(194, 34);
            this.buttonAnalyzer.TabIndex = 0;
            this.buttonAnalyzer.Text = "Analyze My Profile";
            this.buttonAnalyzer.UseVisualStyleBackColor = false;
            this.buttonAnalyzer.Click += new System.EventHandler(this.buttonAnalyzer_Click);
            // 
            // listViewImages
            // 
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(378, 81);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(424, 252);
            this.listViewImages.TabIndex = 2;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            // 
            // labelActiveUser
            // 
            this.labelActiveUser.AutoSize = true;
            this.labelActiveUser.BackColor = System.Drawing.Color.Transparent;
            this.labelActiveUser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveUser.Location = new System.Drawing.Point(18, 351);
            this.labelActiveUser.Name = "labelActiveUser";
            this.labelActiveUser.Size = new System.Drawing.Size(152, 24);
            this.labelActiveUser.TabIndex = 10;
            this.labelActiveUser.Text = "Active Friends:";
            // 
            // labelNonActiveUser
            // 
            this.labelNonActiveUser.AutoSize = true;
            this.labelNonActiveUser.BackColor = System.Drawing.Color.Transparent;
            this.labelNonActiveUser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNonActiveUser.Location = new System.Drawing.Point(18, 54);
            this.labelNonActiveUser.Name = "labelNonActiveUser";
            this.labelNonActiveUser.Size = new System.Drawing.Size(195, 24);
            this.labelNonActiveUser.TabIndex = 9;
            this.labelNonActiveUser.Text = "Non Active Friends:";
            // 
            // listBoxActive
            // 
            this.listBoxActive.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxActive.FormattingEnabled = true;
            this.listBoxActive.ItemHeight = 24;
            this.listBoxActive.Location = new System.Drawing.Point(13, 380);
            this.listBoxActive.Name = "listBoxActive";
            this.listBoxActive.Size = new System.Drawing.Size(359, 292);
            this.listBoxActive.TabIndex = 8;
            this.listBoxActive.SelectedIndexChanged += new System.EventHandler(this.listBoxActive_SelectedIndexChanged);
            // 
            // listBoxNotActive
            // 
            this.listBoxNotActive.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotActive.FormattingEnabled = true;
            this.listBoxNotActive.ItemHeight = 24;
            this.listBoxNotActive.Location = new System.Drawing.Point(13, 81);
            this.listBoxNotActive.Name = "listBoxNotActive";
            this.listBoxNotActive.Size = new System.Drawing.Size(359, 268);
            this.listBoxNotActive.TabIndex = 7;
            this.listBoxNotActive.SelectedIndexChanged += new System.EventHandler(this.listBoxNotActive_SelectedIndexChanged);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(378, 380);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(424, 292);
            this.listBoxPosts.TabIndex = 11;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.BackColor = System.Drawing.Color.Transparent;
            this.labelPosts.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.Location = new System.Drawing.Point(379, 352);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(71, 24);
            this.labelPosts.TabIndex = 12;
            this.labelPosts.Text = "Posts:";
            // 
            // labelImages
            // 
            this.labelImages.AutoSize = true;
            this.labelImages.BackColor = System.Drawing.Color.Transparent;
            this.labelImages.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImages.Location = new System.Drawing.Point(379, 54);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(84, 24);
            this.labelImages.TabIndex = 13;
            this.labelImages.Text = "Images:";
            // 
            // buttonLikeImage
            // 
            this.buttonLikeImage.BackgroundImage = global::FacebookFeaturesUI.Properties.Resources.Like;
            this.buttonLikeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLikeImage.Location = new System.Drawing.Point(808, 81);
            this.buttonLikeImage.Name = "buttonLikeImage";
            this.buttonLikeImage.Size = new System.Drawing.Size(50, 50);
            this.buttonLikeImage.TabIndex = 14;
            this.buttonLikeImage.UseVisualStyleBackColor = true;
            this.buttonLikeImage.Click += new System.EventHandler(this.performLike);
            // 
            // buttonLikePost
            // 
            this.buttonLikePost.BackgroundImage = global::FacebookFeaturesUI.Properties.Resources.Like;
            this.buttonLikePost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLikePost.Location = new System.Drawing.Point(808, 380);
            this.buttonLikePost.Name = "buttonLikePost";
            this.buttonLikePost.Size = new System.Drawing.Size(50, 50);
            this.buttonLikePost.TabIndex = 15;
            this.buttonLikePost.UseVisualStyleBackColor = true;
            this.buttonLikePost.Click += new System.EventHandler(this.performLike);
            // 
            // AnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(861, 677);
            this.Controls.Add(this.buttonLikePost);
            this.Controls.Add(this.buttonLikeImage);
            this.Controls.Add(this.labelImages);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.labelActiveUser);
            this.Controls.Add(this.labelNonActiveUser);
            this.Controls.Add(this.listBoxActive);
            this.Controls.Add(this.listBoxNotActive);
            this.Controls.Add(this.listViewImages);
            this.Controls.Add(this.buttonAnalyzer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnalyzerForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyzer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalyzerForm_FormClosed);
            this.Load += new System.EventHandler(this.AnalyzerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnalyzer;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.Label labelActiveUser;
        private System.Windows.Forms.Label labelNonActiveUser;
        private System.Windows.Forms.ListBox listBoxActive;
        private System.Windows.Forms.ListBox listBoxNotActive;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.Button buttonLikeImage;
        private System.Windows.Forms.Button buttonLikePost;
    }
}