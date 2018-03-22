namespace WalkingMan
{
    partial class frmWalkingMan
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
            this.picMan = new System.Windows.Forms.PictureBox();
            this.btnWalk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.SuspendLayout();
            // 
            // picMan
            // 
            this.picMan.Image = global::WalkingMan.Properties.Resources.walk10;
            this.picMan.Location = new System.Drawing.Point(43, 36);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(182, 185);
            this.picMan.TabIndex = 0;
            this.picMan.TabStop = false;
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(99, 7);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(75, 23);
            this.btnWalk.TabIndex = 1;
            this.btnWalk.Text = "Get it going!";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.picMan);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man";
            this.Load += new System.EventHandler(this.frmWalkingMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMan;
        private System.Windows.Forms.Button btnWalk;
    }
}

