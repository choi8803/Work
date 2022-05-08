using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_List
{
    public partial class Form1 : Form
    {
        List<string> _strList = new List<string>();
        ArrayList _arryList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pboxDH1.Click += pbox_Click;
            pboxDH2.Click += pbox_Click;
            pboxSJ.Click += pbox_Click;
            pboxIU.Click += pbox_Click;

            //dataGridView1.Columns.Add("Name", "이름");
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pboxDH1":
                    strSelectText = "다현1";
                    break;
                case "pboxDH2":
                    strSelectText = "다현2";
                    break;
                case "pboxSJ":
                    strSelectText = "수지";
                    break;
                case "pboxIU":
                    strSelectText = "아이유";
                    break;
                default:
                    break;
            }

            _strList.Add(strSelectText);
            fUIDisplay();
            fDataGridViewDisplay();
        }

        private void fUIDisplay()
        {
            int icnt1 = 0;
            int icnt2 = 0;
            int icnt3 = 0;
            int icnt4 = 0;

            foreach (string item in _strList)
            {
                switch (item)
                {
                    case "다현1":
                        icnt1++;
                        break;
                    case "다현2":
                        icnt2++;
                        break;
                    case "수지":
                        icnt3++;
                        break;
                    case "아이유":
                        icnt4++;
                        break;
                }
            }
            lblPickDH1.Text = icnt1.ToString();
            lblPickDH2.Text = icnt2.ToString();
            lblPickSJ.Text = icnt3.ToString();
            lblPickIU.Text = icnt4.ToString();

            lblTotalCount.Text = $"Total Count : {(icnt1 + icnt2 + icnt3 + icnt4)}";
        }

        private void fDataGridViewDisplay()
        {
#if false
            dataGridView1.Columns.Add("Name", "이름");        // <-- Form1_Load
            dataGridView1.Rows.Clear();
            foreach (string item in _strList)
            {
                dataGridView1.Rows.Add(item);
            }
#else
            dataGridView1.DataSource = _strList.Select(x => new { 이름 = x }).ToList();
#endif

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.HeaderCell.Value = (row.Index+1).ToString();
            }
            // AutoSizeToAllHeaders : 모든 행 머리글 셀의 내용에 맞게 행 머리글 너비가 조정됩니다.
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
