
namespace _28_Exception
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.tbarAlpha = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.lboxColor = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pBack = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cDialogColor = new System.Windows.Forms.ColorDialog();
            this.tbarR = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbarG = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tbarB = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).BeginInit();
            this.pBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbarB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbarG);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbarR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblColorInfo);
            this.groupBox1.Controls.Add(this.tbarAlpha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pnlColor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Select";
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Location = new System.Drawing.Point(61, 205);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(11, 12);
            this.lblColorInfo.TabIndex = 9;
            this.lblColorInfo.Text = "-";
            // 
            // tbarAlpha
            // 
            this.tbarAlpha.Location = new System.Drawing.Point(61, 52);
            this.tbarAlpha.Maximum = 255;
            this.tbarAlpha.Name = "tbarAlpha";
            this.tbarAlpha.Size = new System.Drawing.Size(104, 45);
            this.tbarAlpha.TabIndex = 8;
            this.tbarAlpha.Value = 255;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alpha :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Color :";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.SystemColors.Window;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(61, 19);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(20, 20);
            this.pnlColor.TabIndex = 4;
            // 
            // lboxColor
            // 
            this.lboxColor.FormattingEnabled = true;
            this.lboxColor.ItemHeight = 12;
            this.lboxColor.Location = new System.Drawing.Point(12, 277);
            this.lboxColor.Name = "lboxColor";
            this.lboxColor.Size = new System.Drawing.Size(286, 172);
            this.lboxColor.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(142, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // pBack
            // 
            this.pBack.BackColor = System.Drawing.Color.Transparent;
            this.pBack.BackgroundImage = global::_28_Exception.Properties.Resources.다현;
            this.pBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBack.Controls.Add(this.panel6);
            this.pBack.Controls.Add(this.panel5);
            this.pBack.Controls.Add(this.panel3);
            this.pBack.Controls.Add(this.panel2);
            this.pBack.Controls.Add(this.panel4);
            this.pBack.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pBack.Location = new System.Drawing.Point(304, 21);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(326, 428);
            this.pBack.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(130, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(147, 83);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(99, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 58);
            this.panel5.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(21, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 48);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(40, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 155);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(117, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(88, 222);
            this.panel4.TabIndex = 8;
            // 
            // tbarR
            // 
            this.tbarR.Location = new System.Drawing.Point(61, 87);
            this.tbarR.Maximum = 255;
            this.tbarR.Name = "tbarR";
            this.tbarR.Size = new System.Drawing.Size(104, 45);
            this.tbarR.TabIndex = 11;
            this.tbarR.Value = 255;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "R :";
            // 
            // tbarG
            // 
            this.tbarG.Location = new System.Drawing.Point(61, 122);
            this.tbarG.Maximum = 255;
            this.tbarG.Name = "tbarG";
            this.tbarG.Size = new System.Drawing.Size(104, 45);
            this.tbarG.TabIndex = 13;
            this.tbarG.Value = 255;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "G :";
            // 
            // tbarB
            // 
            this.tbarB.Location = new System.Drawing.Point(61, 157);
            this.tbarB.Maximum = 255;
            this.tbarB.Name = "tbarB";
            this.tbarB.Size = new System.Drawing.Size(104, 45);
            this.tbarB.TabIndex = 15;
            this.tbarB.Value = 255;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "B :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 460);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lboxColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).EndInit();
            this.pBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbarAlpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Label lblColorInfo;
        private System.Windows.Forms.ListBox lboxColor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColorDialog cDialogColor;
        private System.Windows.Forms.TrackBar tbarG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbarR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbarB;
        private System.Windows.Forms.Label label6;
    }
}

