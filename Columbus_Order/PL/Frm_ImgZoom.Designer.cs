namespace Columbus_Order.PL
{
    partial class Frm_ImgZoom
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
            this.PicZoom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // PicZoom
            // 
            this.PicZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicZoom.Location = new System.Drawing.Point(0, 0);
            this.PicZoom.Name = "PicZoom";
            this.PicZoom.Size = new System.Drawing.Size(579, 803);
            this.PicZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicZoom.TabIndex = 0;
            this.PicZoom.TabStop = false;
            // 
            // Frm_ImgZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 803);
            this.Controls.Add(this.PicZoom);
            this.Name = "Frm_ImgZoom";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تكبير الصورة";
            ((System.ComponentModel.ISupportInitialize)(this.PicZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicZoom;
    }
}