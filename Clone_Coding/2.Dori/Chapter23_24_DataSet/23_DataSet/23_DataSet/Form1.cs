using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_DataSet
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();     // 학급들에 대한 정보

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReg.Click += BtnReg_Click;
            btnViewDataDel.Click += BtnViewDataDel_Click;
            btnModify.Click += BtnModify_Click;
            cboxViewClass.SelectedIndexChanged += CboxViewClass_SelectedIndexChanged;

            SetComboItems();

        }

        #region Event

        private void BtnReg_Click(object sender, EventArgs e)
        {
            bool bCheckIsTable = false;

            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckIsTable = true;
            }

            DataTable dt = null;

            // Table 생성
            if (!bCheckIsTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                // Column 등록
                DataColumn colName = new DataColumn("이름", typeof(string));
                DataColumn colSex = new DataColumn("성별", typeof(string));
                DataColumn colRef = new DataColumn("특이사항", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }

            // Row 등록
            DataRow row = dt.NewRow();
            row["이름"] = tboxRegName.Text;
            if (rdoRegSexMale.Checked)
                row["성별"] = "남자";
            else if (rdoRegSexFemale.Checked)
                row["성별"] = "남자";
            row["특이사항"] = tboxRegRef.Text;

            // DataSet 등록
            if (!bCheckIsTable)
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }
            else
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }

            // grid view 갱신
            ViewRefresh();
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxRegName.Text))
            {
                foreach(DataRow row in ds.Tables[cboxViewClass.Text].Rows)
                {
                    if (row["이름"].Equals(tboxRegName.Text))
                    {
                        if (rdoRegSexFemale.Checked)
                        {
                            row["성별"] = "여자";
                        }
                        else if (rdoRegSexMale.Checked)
                        {
                            row["성별"] = "남자";
                        }

                        row["특이사항"] = tboxRegRef.Text;
                    }
                }
                ViewRefresh();
            }   
        }
        private void BtnViewDataDel_Click(object sender, EventArgs e)
        {
            //int iSelectRow = gvInfo.SelectedRows[0].Index;
            //ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);

            foreach (DataGridViewRow row in gvInfo.SelectedRows)
            {
                ds.Tables[cboxViewClass.Text].Rows.RemoveAt(row.Index);
            }
            ViewRefresh();
        }
        private void CboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRefresh();
        }

        #endregion

        #region Function

        private void ViewRefresh()
        {
            gvInfo.DataSource = ds.Tables[cboxViewClass.Text];

            foreach (DataGridViewRow row in gvInfo.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            gvInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
        private void SetComboItems()
        {
            cboxRegClass.Items.AddRange(new string[] { "1반", "2반", "3반" });
            cboxRegClass.SelectedItem = "1반";
            cboxRegClass.DropDownStyle = ComboBoxStyle.DropDownList;

            // Designer에서 처리
            //cboxViewClass.Items.AddRange(new string[] { "1반", "2반", "3반" });
            //cboxViewClass.SelectedItem = "1반";
        }

        #endregion
    }
}
