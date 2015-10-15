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
            this.SuspendLayout();
            // 
            // werpAlleTeerlingen
            // 
            this.werpAlleTeerlingen.Location = new System.Drawing.Point(14, 109);
            this.werpAlleTeerlingen.Name = "werpAlleTeerlingen";
            this.werpAlleTeerlingen.Size = new System.Drawing.Size(115, 23);
            this.werpAlleTeerlingen.TabIndex = 0;
            this.werpAlleTeerlingen.Text = "Werp teerlingen";
            this.werpAlleTeerlingen.UseVisualStyleBackColor = true;
            this.werpAlleTeerlingen.Click += new System.EventHandler(this.werpAlleTeerlingen_Click);
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.werpAlleTeerlingen);
            this.Name = "YahtzeeView";
            this.Load += new System.EventHandler(this.YahtzeeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button werpAlleTeerlingen;
    }
}
