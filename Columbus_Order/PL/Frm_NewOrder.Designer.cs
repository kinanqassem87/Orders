namespace Columbus_Order.PL
{
    partial class Frm_NewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCreater = new System.Windows.Forms.DateTimePicker();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtFollower = new System.Windows.Forms.TextBox();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.btnChooseImg = new System.Windows.Forms.Button();
            this.lbNumIMG = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbState = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUndoQute = new System.Windows.Forms.Button();
            this.lbNumQuteImg = new System.Windows.Forms.Label();
            this.btnChoosQutemg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاريخ انشاء الطلبية : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الزبون : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "وصف الطلبية : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "متابع الطلبية : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاريخ تسليم الطلبية : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "اضافة صور المستندات : ";
            // 
            // dtpCreater
            // 
            this.dtpCreater.Location = new System.Drawing.Point(6, 19);
            this.dtpCreater.Name = "dtpCreater";
            this.dtpCreater.Size = new System.Drawing.Size(319, 20);
            this.dtpCreater.TabIndex = 0;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(6, 45);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(319, 20);
            this.txtClientName.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(6, 71);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(319, 141);
            this.txtDesc.TabIndex = 2;
            // 
            // txtFollower
            // 
            this.txtFollower.Location = new System.Drawing.Point(6, 218);
            this.txtFollower.Name = "txtFollower";
            this.txtFollower.Size = new System.Drawing.Size(319, 20);
            this.txtFollower.TabIndex = 3;
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.Location = new System.Drawing.Point(6, 244);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(319, 20);
            this.dtpDeadLine.TabIndex = 4;
            // 
            // btnChooseImg
            // 
            this.btnChooseImg.Location = new System.Drawing.Point(206, 31);
            this.btnChooseImg.Name = "btnChooseImg";
            this.btnChooseImg.Size = new System.Drawing.Size(90, 23);
            this.btnChooseImg.TabIndex = 6;
            this.btnChooseImg.Text = " الطلبية";
            this.btnChooseImg.UseVisualStyleBackColor = true;
            this.btnChooseImg.Click += new System.EventHandler(this.btnChooseImg_Click);
            // 
            // lbNumIMG
            // 
            this.lbNumIMG.AutoSize = true;
            this.lbNumIMG.Location = new System.Drawing.Point(163, 36);
            this.lbNumIMG.Name = "lbNumIMG";
            this.lbNumIMG.Size = new System.Drawing.Size(12, 13);
            this.lbNumIMG.TabIndex = 12;
            this.lbNumIMG.Text = "؟";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(6, 31);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(117, 23);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "التراجع عن الاختيارات";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "إلغاء";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpCreater);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.txtFollower);
            this.groupBox1.Controls.Add(this.dtpDeadLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(448, 287);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUndoQute);
            this.groupBox2.Controls.Add(this.lbNumQuteImg);
            this.groupBox2.Controls.Add(this.btnChoosQutemg);
            this.groupBox2.Controls.Add(this.btnUndo);
            this.groupBox2.Controls.Add(this.lbNumIMG);
            this.groupBox2.Controls.Add(this.btnChooseImg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 113);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 51);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbState);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 38);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // chbState
            // 
            this.chbState.AutoSize = true;
            this.chbState.Location = new System.Drawing.Point(63, 14);
            this.chbState.Name = "chbState";
            this.chbState.Size = new System.Drawing.Size(43, 17);
            this.chbState.TabIndex = 5;
            this.chbState.Text = "نعم";
            this.chbState.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "هل الطلبية مستعجلة رغم أنها تحتاج اكثر من اسبوع للتسليم ؟ ";
            // 
            // btnUndoQute
            // 
            this.btnUndoQute.Location = new System.Drawing.Point(6, 69);
            this.btnUndoQute.Name = "btnUndoQute";
            this.btnUndoQute.Size = new System.Drawing.Size(117, 23);
            this.btnUndoQute.TabIndex = 14;
            this.btnUndoQute.Text = "التراجع عن الاختيارات";
            this.btnUndoQute.UseVisualStyleBackColor = true;
            this.btnUndoQute.Click += new System.EventHandler(this.btnUndoQute_Click);
            // 
            // lbNumQuteImg
            // 
            this.lbNumQuteImg.AutoSize = true;
            this.lbNumQuteImg.Location = new System.Drawing.Point(163, 74);
            this.lbNumQuteImg.Name = "lbNumQuteImg";
            this.lbNumQuteImg.Size = new System.Drawing.Size(12, 13);
            this.lbNumQuteImg.TabIndex = 15;
            this.lbNumQuteImg.Text = "؟";
            // 
            // btnChoosQutemg
            // 
            this.btnChoosQutemg.Location = new System.Drawing.Point(206, 69);
            this.btnChoosQutemg.Name = "btnChoosQutemg";
            this.btnChoosQutemg.Size = new System.Drawing.Size(90, 23);
            this.btnChoosQutemg.TabIndex = 13;
            this.btnChoosQutemg.Text = "عرض الاسعار";
            this.btnChoosQutemg.UseVisualStyleBackColor = true;
            this.btnChoosQutemg.Click += new System.EventHandler(this.btnChoosQutemg_Click);
            // 
            // Frm_NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 530);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_NewOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ادخال طلبية جديدة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCreater;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtFollower;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.Button btnChooseImg;
        private System.Windows.Forms.Label lbNumIMG;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chbState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUndoQute;
        private System.Windows.Forms.Label lbNumQuteImg;
        private System.Windows.Forms.Button btnChoosQutemg;
    }
}