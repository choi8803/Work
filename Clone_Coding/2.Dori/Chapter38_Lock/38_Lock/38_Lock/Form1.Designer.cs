
namespace _38_Lock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lboxRoom1 = new System.Windows.Forms.ListBox();
            this.btnRoom1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboxRoom2 = new System.Windows.Forms.ListBox();
            this.btnRoom2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLockStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboxRoom1);
            this.groupBox1.Controls.Add(this.btnRoom1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "No 1. Room";
            // 
            // lboxRoom1
            // 
            this.lboxRoom1.FormattingEnabled = true;
            this.lboxRoom1.ItemHeight = 15;
            this.lboxRoom1.Location = new System.Drawing.Point(74, 22);
            this.lboxRoom1.Name = "lboxRoom1";
            this.lboxRoom1.Size = new System.Drawing.Size(70, 94);
            this.lboxRoom1.TabIndex = 1;
            // 
            // btnRoom1
            // 
            this.btnRoom1.Location = new System.Drawing.Point(15, 22);
            this.btnRoom1.Name = "btnRoom1";
            this.btnRoom1.Size = new System.Drawing.Size(53, 94);
            this.btnRoom1.TabIndex = 0;
            this.btnRoom1.Text = "예약";
            this.btnRoom1.UseVisualStyleBackColor = true;
            this.btnRoom1.Click += new System.EventHandler(this.btnRoom1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboxRoom2);
            this.groupBox2.Controls.Add(this.btnRoom2);
            this.groupBox2.Location = new System.Drawing.Point(199, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "No 2. Room";
            // 
            // lboxRoom2
            // 
            this.lboxRoom2.FormattingEnabled = true;
            this.lboxRoom2.ItemHeight = 15;
            this.lboxRoom2.Location = new System.Drawing.Point(74, 22);
            this.lboxRoom2.Name = "lboxRoom2";
            this.lboxRoom2.Size = new System.Drawing.Size(70, 94);
            this.lboxRoom2.TabIndex = 1;
            // 
            // btnRoom2
            // 
            this.btnRoom2.Location = new System.Drawing.Point(15, 22);
            this.btnRoom2.Name = "btnRoom2";
            this.btnRoom2.Size = new System.Drawing.Size(53, 94);
            this.btnRoom2.TabIndex = 0;
            this.btnRoom2.Text = "예약";
            this.btnRoom2.UseVisualStyleBackColor = true;
            this.btnRoom2.Click += new System.EventHandler(this.btnRoom2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "사용 현황";
            // 
            // lblLockStatus
            // 
            this.lblLockStatus.BackColor = System.Drawing.Color.White;
            this.lblLockStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLockStatus.Location = new System.Drawing.Point(12, 177);
            this.lblLockStatus.Name = "lblLockStatus";
            this.lblLockStatus.Size = new System.Drawing.Size(349, 38);
            this.lblLockStatus.TabIndex = 3;
            this.lblLockStatus.Text = "None";
            this.lblLockStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "이력";
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 15;
            this.lboxResult.Location = new System.Drawing.Point(12, 267);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(349, 229);
            this.lboxResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 511);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLockStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lboxRoom1;
        private System.Windows.Forms.Button btnRoom1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboxRoom2;
        private System.Windows.Forms.Button btnRoom2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLockStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxResult;
    }
}

