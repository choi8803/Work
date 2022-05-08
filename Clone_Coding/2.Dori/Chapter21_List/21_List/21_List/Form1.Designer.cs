
namespace _21_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPickIU = new System.Windows.Forms.Label();
            this.lblPickSJ = new System.Windows.Forms.Label();
            this.lblPickDH2 = new System.Windows.Forms.Label();
            this.pboxIU = new System.Windows.Forms.PictureBox();
            this.pboxSJ = new System.Windows.Forms.PictureBox();
            this.pboxDH2 = new System.Windows.Forms.PictureBox();
            this.pboxDH1 = new System.Windows.Forms.PictureBox();
            this.lblPickDH1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "※ 인기 투표 예제";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(69, 224);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(88, 15);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "Total Count : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "※ 선택한 항목을 리스트에 표시";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPickIU, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPickSJ, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPickDH2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pboxIU, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pboxSJ, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pboxDH2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pboxDH1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPickDH1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 163);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblPickIU
            // 
            this.lblPickIU.AutoSize = true;
            this.lblPickIU.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPickIU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPickIU.ForeColor = System.Drawing.Color.White;
            this.lblPickIU.Location = new System.Drawing.Point(447, 143);
            this.lblPickIU.Name = "lblPickIU";
            this.lblPickIU.Size = new System.Drawing.Size(144, 20);
            this.lblPickIU.TabIndex = 7;
            this.lblPickIU.Text = "0";
            this.lblPickIU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPickSJ
            // 
            this.lblPickSJ.AutoSize = true;
            this.lblPickSJ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPickSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPickSJ.ForeColor = System.Drawing.Color.White;
            this.lblPickSJ.Location = new System.Drawing.Point(299, 143);
            this.lblPickSJ.Name = "lblPickSJ";
            this.lblPickSJ.Size = new System.Drawing.Size(142, 20);
            this.lblPickSJ.TabIndex = 6;
            this.lblPickSJ.Text = "0";
            this.lblPickSJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPickDH2
            // 
            this.lblPickDH2.AutoSize = true;
            this.lblPickDH2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPickDH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPickDH2.ForeColor = System.Drawing.Color.White;
            this.lblPickDH2.Location = new System.Drawing.Point(151, 143);
            this.lblPickDH2.Name = "lblPickDH2";
            this.lblPickDH2.Size = new System.Drawing.Size(142, 20);
            this.lblPickDH2.TabIndex = 5;
            this.lblPickDH2.Text = "0";
            this.lblPickDH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxIU
            // 
            this.pboxIU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxIU.Image = ((System.Drawing.Image)(resources.GetObject("pboxIU.Image")));
            this.pboxIU.Location = new System.Drawing.Point(447, 3);
            this.pboxIU.Name = "pboxIU";
            this.pboxIU.Size = new System.Drawing.Size(144, 137);
            this.pboxIU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxIU.TabIndex = 3;
            this.pboxIU.TabStop = false;
            // 
            // pboxSJ
            // 
            this.pboxSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxSJ.Image = ((System.Drawing.Image)(resources.GetObject("pboxSJ.Image")));
            this.pboxSJ.Location = new System.Drawing.Point(299, 3);
            this.pboxSJ.Name = "pboxSJ";
            this.pboxSJ.Size = new System.Drawing.Size(142, 137);
            this.pboxSJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSJ.TabIndex = 2;
            this.pboxSJ.TabStop = false;
            // 
            // pboxDH2
            // 
            this.pboxDH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxDH2.Image = ((System.Drawing.Image)(resources.GetObject("pboxDH2.Image")));
            this.pboxDH2.Location = new System.Drawing.Point(151, 3);
            this.pboxDH2.Name = "pboxDH2";
            this.pboxDH2.Size = new System.Drawing.Size(142, 137);
            this.pboxDH2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDH2.TabIndex = 1;
            this.pboxDH2.TabStop = false;
            // 
            // pboxDH1
            // 
            this.pboxDH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxDH1.Image = ((System.Drawing.Image)(resources.GetObject("pboxDH1.Image")));
            this.pboxDH1.Location = new System.Drawing.Point(3, 3);
            this.pboxDH1.Name = "pboxDH1";
            this.pboxDH1.Size = new System.Drawing.Size(142, 137);
            this.pboxDH1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDH1.TabIndex = 0;
            this.pboxDH1.TabStop = false;
            // 
            // lblPickDH1
            // 
            this.lblPickDH1.AutoSize = true;
            this.lblPickDH1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPickDH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPickDH1.ForeColor = System.Drawing.Color.White;
            this.lblPickDH1.Location = new System.Drawing.Point(3, 143);
            this.lblPickDH1.Name = "lblPickDH1";
            this.lblPickDH1.Size = new System.Drawing.Size(142, 20);
            this.lblPickDH1.TabIndex = 4;
            this.lblPickDH1.Text = "0";
            this.lblPickDH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(292, 167);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 381);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pboxIU;
        private System.Windows.Forms.PictureBox pboxSJ;
        private System.Windows.Forms.PictureBox pboxDH2;
        private System.Windows.Forms.PictureBox pboxDH1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPickIU;
        private System.Windows.Forms.Label lblPickSJ;
        private System.Windows.Forms.Label lblPickDH2;
        private System.Windows.Forms.Label lblPickDH1;
    }
}

