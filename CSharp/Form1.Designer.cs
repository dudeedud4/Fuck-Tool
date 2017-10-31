namespace CSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reaperLabel1 = new ReaperTheme.Controls.ReaperLabel();
            this.reaperButton1 = new ReaperTheme.Controls.ReaperButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.reaperLabel2 = new ReaperTheme.Controls.ReaperLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reaperLabel1
            // 
            this.reaperLabel1.AutoSize = true;
            this.reaperLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reaperLabel1.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reaperLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reaperLabel1.Location = new System.Drawing.Point(178, 170);
            this.reaperLabel1.Name = "reaperLabel1";
            this.reaperLabel1.OverrideColorBarColor = false;
            this.reaperLabel1.ShowSeperator = false;
            this.reaperLabel1.Size = new System.Drawing.Size(112, 14);
            this.reaperLabel1.TabIndex = 4;
            this.reaperLabel1.Text = "HackAndModz.Net";
            this.reaperLabel1.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.reaperLabel1.Click += new System.EventHandler(this.reaperLabel1_Click);
            // 
            // reaperButton1
            // 
            this.reaperButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reaperButton1.ButtonState = ReaperTheme.ReaperEnums.ReaperButtonState.Normal;
            this.reaperButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.reaperButton1.HoverColor = System.Drawing.Color.DarkOrchid;
            this.reaperButton1.Location = new System.Drawing.Point(114, 108);
            this.reaperButton1.Name = "reaperButton1";
            this.reaperButton1.OverrideBackColor = true;
            this.reaperButton1.OverrideHoverColor = false;
            this.reaperButton1.Size = new System.Drawing.Size(236, 47);
            this.reaperButton1.TabIndex = 5;
            this.reaperButton1.Text = "Fuck !";
            this.reaperButton1.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.reaperButton1.UseVisualStyleBackColor = false;
            this.reaperButton1.Click += new System.EventHandler(this.reaperButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(422, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // reaperLabel2
            // 
            this.reaperLabel2.AutoSize = true;
            this.reaperLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reaperLabel2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.reaperLabel2.Location = new System.Drawing.Point(5, 170);
            this.reaperLabel2.Name = "reaperLabel2";
            this.reaperLabel2.OverrideColorBarColor = false;
            this.reaperLabel2.ShowSeperator = false;
            this.reaperLabel2.Size = new System.Drawing.Size(77, 14);
            this.reaperLabel2.TabIndex = 7;
            this.reaperLabel2.Text = "Fucked : ?";
            this.reaperLabel2.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 198);
            this.ColorBarColor = System.Drawing.Color.DarkOrchid;
            this.Controls.Add(this.reaperLabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.reaperButton1);
            this.Controls.Add(this.reaperLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 26, 2, 2);
            this.Text = "Fuck Tool By HackAndModz.Net - RaStA_ToXiC_91";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaperTheme.Controls.ReaperLabel reaperLabel1;
        private ReaperTheme.Controls.ReaperButton reaperButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaperTheme.Controls.ReaperLabel reaperLabel2;
    }
}

