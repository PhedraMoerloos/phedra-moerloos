namespace YahtzeeTeerling
{
    partial class YahtzeeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.werpAlleTeerlingen = new System.Windows.Forms.Button();
            this.scoreTextLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // werpAlleTeerlingen
            // 
            this.werpAlleTeerlingen.Location = new System.Drawing.Point(167, 157);
            this.werpAlleTeerlingen.Name = "werpAlleTeerlingen";
            this.werpAlleTeerlingen.Size = new System.Drawing.Size(115, 23);
            this.werpAlleTeerlingen.TabIndex = 0;
            this.werpAlleTeerlingen.Text = "Werp teerlingen";
            this.werpAlleTeerlingen.UseVisualStyleBackColor = true;
            this.werpAlleTeerlingen.Click += new System.EventHandler(this.werpAlleTeerlingen_Click);
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.AutoSize = true;
            this.scoreTextLabel.Location = new System.Drawing.Point(20, 162);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(38, 13);
            this.scoreTextLabel.TabIndex = 1;
            this.scoreTextLabel.Text = "Score:";
            this.scoreTextLabel.Click += new System.EventHandler(this.scoreTextLabel_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(79, 162);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "label1";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreTextLabel);
            this.Controls.Add(this.werpAlleTeerlingen);
            this.Name = "YahtzeeView";
            this.Size = new System.Drawing.Size(458, 192);
            this.Load += new System.EventHandler(this.YahtzeeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button werpAlleTeerlingen;
        private System.Windows.Forms.Label scoreTextLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
