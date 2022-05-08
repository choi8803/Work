
namespace _39_User32
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
            this.components = new System.ComponentModel.Container();
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.CMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrimCMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipboardCMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadCMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllCMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ProgramInfoCMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBar = new System.Windows.Forms.TrackBar();
            this.btnTextAdd = new System.Windows.Forms.Button();
            this.txtTextAdd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboxActivation = new System.Windows.Forms.CheckBox();
            this.lblActivation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FileMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrimMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramInfoMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MStrip = new System.Windows.Forms.MenuStrip();
            this.CMStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.ContextMenuStrip = this.CMStrip;
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.ItemHeight = 15;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 43);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(420, 179);
            this.lboxTextSave.TabIndex = 1;
            // 
            // CMStrip
            // 
            this.CMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrimCMenuStripItem,
            this.ClipboardCMenuStripItem,
            this.RemoveAllCMenuStripItem,
            this.toolStripSeparator2,
            this.ProgramInfoCMenuStripItem});
            this.CMStrip.Name = "contextMenuStrip1";
            this.CMStrip.Size = new System.Drawing.Size(181, 120);
            // 
            // TrimCMenuStripItem
            // 
            this.TrimCMenuStripItem.Name = "TrimCMenuStripItem";
            this.TrimCMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.TrimCMenuStripItem.Text = "공백제거";
            // 
            // ClipboardCMenuStripItem
            // 
            this.ClipboardCMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveCMenuStripItem,
            this.LoadCMenuStripItem});
            this.ClipboardCMenuStripItem.Name = "ClipboardCMenuStripItem";
            this.ClipboardCMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.ClipboardCMenuStripItem.Text = "클립보드";
            // 
            // SaveCMenuStripItem
            // 
            this.SaveCMenuStripItem.Name = "SaveCMenuStripItem";
            this.SaveCMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.SaveCMenuStripItem.Text = "저장하기";
            // 
            // LoadCMenuStripItem
            // 
            this.LoadCMenuStripItem.Name = "LoadCMenuStripItem";
            this.LoadCMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.LoadCMenuStripItem.Text = "불러오기";
            // 
            // RemoveAllCMenuStripItem
            // 
            this.RemoveAllCMenuStripItem.Name = "RemoveAllCMenuStripItem";
            this.RemoveAllCMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveAllCMenuStripItem.Text = "모두삭제";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ProgramInfoCMenuStripItem
            // 
            this.ProgramInfoCMenuStripItem.Name = "ProgramInfoCMenuStripItem";
            this.ProgramInfoCMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.ProgramInfoCMenuStripItem.Text = "프로그램정보";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBar);
            this.panel1.Controls.Add(this.btnTextAdd);
            this.panel1.Controls.Add(this.txtTextAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 34);
            this.panel1.TabIndex = 3;
            // 
            // TBar
            // 
            this.TBar.Location = new System.Drawing.Point(286, 3);
            this.TBar.Minimum = 2;
            this.TBar.Name = "TBar";
            this.TBar.Size = new System.Drawing.Size(126, 45);
            this.TBar.TabIndex = 8;
            this.TBar.Value = 10;
            // 
            // btnTextAdd
            // 
            this.btnTextAdd.Location = new System.Drawing.Point(205, 5);
            this.btnTextAdd.Name = "btnTextAdd";
            this.btnTextAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTextAdd.TabIndex = 7;
            this.btnTextAdd.Text = "등록";
            this.btnTextAdd.UseVisualStyleBackColor = true;
            // 
            // txtTextAdd
            // 
            this.txtTextAdd.Location = new System.Drawing.Point(3, 6);
            this.txtTextAdd.Name = "txtTextAdd";
            this.txtTextAdd.Size = new System.Drawing.Size(196, 23);
            this.txtTextAdd.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboxActivation);
            this.panel2.Controls.Add(this.lblActivation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 34);
            this.panel2.TabIndex = 4;
            // 
            // cboxActivation
            // 
            this.cboxActivation.AutoSize = true;
            this.cboxActivation.Checked = true;
            this.cboxActivation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxActivation.Location = new System.Drawing.Point(14, 9);
            this.cboxActivation.Name = "cboxActivation";
            this.cboxActivation.Size = new System.Drawing.Size(80, 19);
            this.cboxActivation.TabIndex = 4;
            this.cboxActivation.Text = "Activation";
            this.cboxActivation.UseVisualStyleBackColor = true;
            // 
            // lblActivation
            // 
            this.lblActivation.AutoSize = true;
            this.lblActivation.Location = new System.Drawing.Point(243, 10);
            this.lblActivation.Name = "lblActivation";
            this.lblActivation.Size = new System.Drawing.Size(150, 15);
            this.lblActivation.TabIndex = 3;
            this.lblActivation.Text = "활성화 상태(Ctrl + C 가능)";
            this.lblActivation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lboxTextSave, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 265);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FileMenuStripItem
            // 
            this.FileMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuStripItem,
            this.LoadMenuStripItem,
            this.toolStripSeparator1,
            this.CloseMenuStripItem});
            this.FileMenuStripItem.Name = "FileMenuStripItem";
            this.FileMenuStripItem.Size = new System.Drawing.Size(43, 20);
            this.FileMenuStripItem.Text = "파일";
            // 
            // SaveMenuStripItem
            // 
            this.SaveMenuStripItem.Name = "SaveMenuStripItem";
            this.SaveMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuStripItem.Text = "저장하기";
            // 
            // LoadMenuStripItem
            // 
            this.LoadMenuStripItem.Name = "LoadMenuStripItem";
            this.LoadMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.LoadMenuStripItem.Text = "불러오기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // CloseMenuStripItem
            // 
            this.CloseMenuStripItem.Name = "CloseMenuStripItem";
            this.CloseMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.CloseMenuStripItem.Text = "종료";
            // 
            // EditMenuStripItem
            // 
            this.EditMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrimMenuStripItem,
            this.RemoveAllMenuStripItem});
            this.EditMenuStripItem.Name = "EditMenuStripItem";
            this.EditMenuStripItem.Size = new System.Drawing.Size(43, 20);
            this.EditMenuStripItem.Text = "편집";
            // 
            // TrimMenuStripItem
            // 
            this.TrimMenuStripItem.Name = "TrimMenuStripItem";
            this.TrimMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.TrimMenuStripItem.Text = "공백제거";
            // 
            // RemoveAllMenuStripItem
            // 
            this.RemoveAllMenuStripItem.Name = "RemoveAllMenuStripItem";
            this.RemoveAllMenuStripItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveAllMenuStripItem.Text = "모두삭제";
            // 
            // ProgramInfoMenuStripItem
            // 
            this.ProgramInfoMenuStripItem.Name = "ProgramInfoMenuStripItem";
            this.ProgramInfoMenuStripItem.Size = new System.Drawing.Size(95, 20);
            this.ProgramInfoMenuStripItem.Text = "프로그램 정보";
            // 
            // MStrip
            // 
            this.MStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStripItem,
            this.EditMenuStripItem,
            this.ProgramInfoMenuStripItem});
            this.MStrip.Location = new System.Drawing.Point(0, 0);
            this.MStrip.Name = "MStrip";
            this.MStrip.Size = new System.Drawing.Size(426, 24);
            this.MStrip.TabIndex = 6;
            this.MStrip.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 289);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MStrip);
            this.MainMenuStrip = this.MStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.CMStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MStrip.ResumeLayout(false);
            this.MStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxTextSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar TBar;
        private System.Windows.Forms.Button btnTextAdd;
        private System.Windows.Forms.TextBox txtTextAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cboxActivation;
        private System.Windows.Forms.Label lblActivation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip CMStrip;
        private System.Windows.Forms.ToolStripMenuItem TrimCMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem ClipboardCMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllCMenuStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ProgramInfoCMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem SaveCMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem LoadCMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem TrimMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramInfoMenuStripItem;
        private System.Windows.Forms.MenuStrip MStrip;
    }
}

