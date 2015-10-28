namespace YahtzeeTeerling
{
    partial class TeerlingVieuw
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
            this.teerlingLabel = new System.Windows.Forms.Label();
            this.werpKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teerlingLabel
            // 
            this.teerlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teerlingLabel.Location = new System.Drawing.Point(16, 9);
            this.teerlingLabel.Name = "teerlingLabel";
            this.teerlingLabel.Size = new System.Drawing.Size(122, 99);
            this.teerlingLabel.TabIndex = 0;
            this.teerlingLabel.Text = "label1";
            this.teerlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teerlingLabel.UseMnemonic = false;
            this.teerlingLabel.Click += new System.EventHandler(this.teerlingLabel_Click);
            // 
            // werpKnop
            // 
            this.werpKnop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.werpKnop.Location = new System.Drawing.Point(34, 111);
            this.werpKnop.Name = "werpKnop";
            this.werpKnop.Size = new System.Drawing.Size(75, 23);
            this.werpKnop.TabIndex = 1;
            this.werpKnop.Text = "werp";
            this.werpKnop.UseVisualStyleBackColor = true;
            this.werpKnop.Click += new System.EventHandler(this.werpKnop_Click);
            // 
            // TeerlingVieuw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.werpKnop);
            this.Controls.Add(this.teerlingLabel);
            this.Name = "TeerlingVieuw";
            this.Load += new System.EventHandler(this.TeerlingVieuw_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label teerlingLabel;
        private System.Windows.Forms.Button werpKnop;
    }
}
