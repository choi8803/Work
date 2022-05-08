
namespace _45_DB
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
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.btnDBLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.tboxQuery = new System.Windows.Forms.TextBox();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.btnExcute = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDBLoad);
            this.groupBox1.Controls.Add(this.tboxPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가져오기";
            // 
            // tboxPath
            // 
            this.tboxPath.Location = new System.Drawing.Point(6, 22);
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.Size = new System.Drawing.Size(551, 21);
            this.tboxPath.TabIndex = 0;
            // 
            // btnDBLoad
            // 
            this.btnDBLoad.Location = new System.Drawing.Point(563, 20);
            this.btnDBLoad.Name = "btnDBLoad";
            this.btnDBLoad.Size = new System.Drawing.Size(75, 23);
            this.btnDBLoad.TabIndex = 1;
            this.btnDBLoad.Text = "DB Load";
            this.btnDBLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEx1);
            this.groupBox2.Controls.Add(this.btnEx2);
            this.groupBox2.Controls.Add(this.btnEx3);
            this.groupBox2.Controls.Add(this.tboxQuery);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조회";
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(563, 20);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(75, 23);
            this.btnEx3.TabIndex = 1;
            this.btnEx3.Text = "예제3";
            this.btnEx3.UseVisualStyleBackColor = true;
            // 
            // tboxQuery
            // 
            this.tboxQuery.Location = new System.Drawing.Point(6, 49);
            this.tboxQuery.Multiline = true;
            this.tboxQuery.Name = "tboxQuery";
            this.tboxQuery.Size = new System.Drawing.Size(632, 109);
            this.tboxQuery.TabIndex = 0;
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(482, 20);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(75, 23);
            this.btnEx2.TabIndex = 2;
            this.btnEx2.Text = "예제2";
            this.btnEx2.UseVisualStyleBackColor = true;
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(401, 20);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(75, 23);
            this.btnEx1.TabIndex = 3;
            this.btnEx1.Text = "예제1";
            this.btnEx1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExcute);
            this.groupBox3.Controls.Add(this.dgData);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 274);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "결과";
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(6, 49);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 23;
            this.dgData.Size = new System.Drawing.Size(632, 195);
            this.dgData.TabIndex = 0;
            // 
            // btnExcute
            // 
            this.btnExcute.Location = new System.Drawing.Point(563, 20);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(75, 23);
            this.btnExcute.TabIndex = 2;
            this.btnExcute.Text = "실행";
            this.btnExcute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDBLoad;
        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.TextBox tboxQuery;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExcute;
        private System.Windows.Forms.DataGridView dgData;
    }
}

