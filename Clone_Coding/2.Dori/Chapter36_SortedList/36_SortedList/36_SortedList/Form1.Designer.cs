
namespace _36_SortedList
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
            this.btnScheduler = new System.Windows.Forms.Button();
            this.lboxScheduler = new System.Windows.Forms.ListBox();
            this.tboxScheduler = new System.Windows.Forms.TextBox();
            this.mcScheduler = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnScheduler
            // 
            this.btnScheduler.Location = new System.Drawing.Point(12, 345);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(220, 23);
            this.btnScheduler.TabIndex = 0;
            this.btnScheduler.Text = "일정 등록하기";
            this.btnScheduler.UseVisualStyleBackColor = true;
            // 
            // lboxScheduler
            // 
            this.lboxScheduler.FormattingEnabled = true;
            this.lboxScheduler.ItemHeight = 15;
            this.lboxScheduler.Location = new System.Drawing.Point(244, 18);
            this.lboxScheduler.Name = "lboxScheduler";
            this.lboxScheduler.Size = new System.Drawing.Size(257, 349);
            this.lboxScheduler.TabIndex = 1;
            // 
            // tboxScheduler
            // 
            this.tboxScheduler.Location = new System.Drawing.Point(12, 192);
            this.tboxScheduler.Multiline = true;
            this.tboxScheduler.Name = "tboxScheduler";
            this.tboxScheduler.Size = new System.Drawing.Size(220, 147);
            this.tboxScheduler.TabIndex = 2;
            // 
            // mcScheduler
            // 
            this.mcScheduler.Location = new System.Drawing.Point(12, 18);
            this.mcScheduler.MaxSelectionCount = 1;
            this.mcScheduler.Name = "mcScheduler";
            this.mcScheduler.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 380);
            this.Controls.Add(this.mcScheduler);
            this.Controls.Add(this.tboxScheduler);
            this.Controls.Add(this.lboxScheduler);
            this.Controls.Add(this.btnScheduler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.ListBox lboxScheduler;
        private System.Windows.Forms.TextBox tboxScheduler;
        private System.Windows.Forms.MonthCalendar mcScheduler;
    }
}

