
namespace _44_TreeView
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
            this.tboxDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTreeLoad = new System.Windows.Forms.Button();
            this.tboxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxLocation = new System.Windows.Forms.GroupBox();
            this.lboxCommand = new System.Windows.Forms.ListBox();
            this.tboxFile = new System.Windows.Forms.TextBox();
            this.tviewLocation = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gboxLocation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTreeLoad);
            this.groupBox1.Controls.Add(this.tboxSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // tboxDestination
            // 
            this.tboxDestination.Location = new System.Drawing.Point(393, 18);
            this.tboxDestination.Name = "tboxDestination";
            this.tboxDestination.Size = new System.Drawing.Size(197, 21);
            this.tboxDestination.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // btnTreeLoad
            // 
            this.btnTreeLoad.Location = new System.Drawing.Point(280, 18);
            this.btnTreeLoad.Name = "btnTreeLoad";
            this.btnTreeLoad.Size = new System.Drawing.Size(26, 21);
            this.btnTreeLoad.TabIndex = 2;
            this.btnTreeLoad.Text = "T";
            this.btnTreeLoad.UseVisualStyleBackColor = true;
            // 
            // tboxSource
            // 
            this.tboxSource.Location = new System.Drawing.Point(63, 18);
            this.tboxSource.Name = "tboxSource";
            this.tboxSource.Size = new System.Drawing.Size(215, 21);
            this.tboxSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // gboxLocation
            // 
            this.gboxLocation.Controls.Add(this.lboxCommand);
            this.gboxLocation.Controls.Add(this.tboxFile);
            this.gboxLocation.Controls.Add(this.tviewLocation);
            this.gboxLocation.Controls.Add(this.label4);
            this.gboxLocation.Controls.Add(this.btnCollapse);
            this.gboxLocation.Controls.Add(this.btnExtend);
            this.gboxLocation.Controls.Add(this.label3);
            this.gboxLocation.ForeColor = System.Drawing.Color.Black;
            this.gboxLocation.Location = new System.Drawing.Point(12, 68);
            this.gboxLocation.Name = "gboxLocation";
            this.gboxLocation.Size = new System.Drawing.Size(600, 284);
            this.gboxLocation.TabIndex = 8;
            this.gboxLocation.TabStop = false;
            this.gboxLocation.Text = "Location";
            // 
            // lboxCommand
            // 
            this.lboxCommand.FormattingEnabled = true;
            this.lboxCommand.ItemHeight = 12;
            this.lboxCommand.Location = new System.Drawing.Point(296, 48);
            this.lboxCommand.Name = "lboxCommand";
            this.lboxCommand.Size = new System.Drawing.Size(294, 100);
            this.lboxCommand.TabIndex = 14;
            // 
            // tboxFile
            // 
            this.tboxFile.Location = new System.Drawing.Point(296, 167);
            this.tboxFile.Multiline = true;
            this.tboxFile.Name = "tboxFile";
            this.tboxFile.Size = new System.Drawing.Size(294, 100);
            this.tboxFile.TabIndex = 13;
            // 
            // tviewLocation
            // 
            this.tviewLocation.Location = new System.Drawing.Point(9, 48);
            this.tviewLocation.Name = "tviewLocation";
            this.tviewLocation.Size = new System.Drawing.Size(269, 219);
            this.tviewLocation.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Command";
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(203, 19);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(75, 23);
            this.btnCollapse.TabIndex = 10;
            this.btnCollapse.Text = "Collapse";
            this.btnCollapse.UseVisualStyleBackColor = true;
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(122, 19);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(75, 23);
            this.btnExtend.TabIndex = 9;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "TreeNode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lboxLog);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 137);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 12;
            this.lboxLog.Location = new System.Drawing.Point(9, 17);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(581, 112);
            this.lboxLog.TabIndex = 15;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(527, 358);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 536);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gboxLocation);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxLocation.ResumeLayout(false);
            this.gboxLocation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTreeLoad;
        private System.Windows.Forms.TextBox tboxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxLocation;
        private System.Windows.Forms.ListBox lboxCommand;
        private System.Windows.Forms.TextBox tboxFile;
        private System.Windows.Forms.TreeView tviewLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.Button btnCopy;
    }
}

