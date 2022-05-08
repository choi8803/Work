namespace _29_UserControl
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pMain = new System.Windows.Forms.Panel();
            this.ucInfo3 = new _29_UserControl.UCInfo();
            this.ucInfo2 = new _29_UserControl.UCInfo();
            this.ucInfo1 = new _29_UserControl.UCInfo();
            this.lboxList = new System.Windows.Forms.ListBox();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.Peru;
            this.pMain.Controls.Add(this.ucInfo3);
            this.pMain.Controls.Add(this.ucInfo2);
            this.pMain.Controls.Add(this.ucInfo1);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(710, 264);
            this.pMain.TabIndex = 0;
            // 
            // ucInfo3
            // 
            this.ucInfo3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucInfo3.Location = new System.Drawing.Point(472, 15);
            this.ucInfo3.Name = "ucInfo3";
            this.ucInfo3.Size = new System.Drawing.Size(224, 235);
            this.ucInfo3.TabIndex = 4;
            this.ucInfo3.UserAmount = "3천 500만원";
            this.ucInfo3.UserFace = ((System.Drawing.Image)(resources.GetObject("ucInfo3.UserFace")));
            this.ucInfo3.UserName = "아이유";
            this.ucInfo3.UserNo = "3";
            // 
            // ucInfo2
            // 
            this.ucInfo2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucInfo2.Location = new System.Drawing.Point(242, 15);
            this.ucInfo2.Name = "ucInfo2";
            this.ucInfo2.Size = new System.Drawing.Size(224, 235);
            this.ucInfo2.TabIndex = 3;
            this.ucInfo2.UserAmount = "3천만원";
            this.ucInfo2.UserFace = ((System.Drawing.Image)(resources.GetObject("ucInfo2.UserFace")));
            this.ucInfo2.UserName = "수지";
            this.ucInfo2.UserNo = "2";
            // 
            // ucInfo1
            // 
            this.ucInfo1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucInfo1.Location = new System.Drawing.Point(12, 15);
            this.ucInfo1.Name = "ucInfo1";
            this.ucInfo1.Size = new System.Drawing.Size(224, 235);
            this.ucInfo1.TabIndex = 2;
            this.ucInfo1.UserAmount = "2천만원";
            this.ucInfo1.UserFace = ((System.Drawing.Image)(resources.GetObject("ucInfo1.UserFace")));
            this.ucInfo1.UserName = "다현";
            this.ucInfo1.UserNo = "1";
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.ItemHeight = 12;
            this.lboxList.Location = new System.Drawing.Point(12, 282);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(710, 196);
            this.lboxList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 490);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private UCInfo ucInfo3;
        private UCInfo ucInfo2;
        private UCInfo ucInfo1;
        private System.Windows.Forms.ListBox lboxList;
    }
}

