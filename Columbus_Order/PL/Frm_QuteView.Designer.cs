namespace Columbus_Order.PL
{
    partial class Frm_QuteView
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
            this.picQuteImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuteImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picQuteImg
            // 
            this.picQuteImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picQuteImg.Location = new System.Drawing.Point(0, 0);
            this.picQuteImg.Name = "picQuteImg";
            this.picQuteImg.Size = new System.Drawing.Size(579, 803);
            this.picQuteImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuteImg.TabIndex = 0;
            this.picQuteImg.TabStop = false;
            // 
            // Frm_QuteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 803);
            this.Controls.Add(this.picQuteImg);
            this.Name = "Frm_QuteView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض اسعار";
            ((System.ComponentModel.ISupportInitialize)(this.picQuteImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picQuteImg;
    }
}