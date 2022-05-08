using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42_List
{
    public partial class Form1 : Form
    {
        List<object> oList = new List<object>();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Click += BtnAdd_Click;
            btnRemove.Click += BtnRemove_Click;
            btnChange.Click += BtnChange_Click;
            tboxData.KeyDown += TboxData_KeyDown; ;
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            List<object> ListChange = new List<object>();
            ListChange = oList.ConvertAll<object>(s => s.ToString().Replace(tboxChangeOld.Text, tboxChangeNew.Text));

            lboxChangeList.DataSource = ListChange.ToList();
            ShowChangeListDetail(ListChange);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (numPosition.Value == -1)
            {
                oList.Remove(tboxData.Text);
            }
            else
            {
                oList.RemoveAt((int)numPosition.Value);
            }
            lboxList.DataSource = oList.ToList();
            ListBoxNoCreate();
            ShowListDetail();

            tboxData.Text = string.Empty;
        }

        private void TboxData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tboxData.Text.Length > 0)
                {
                    AddListBoxItem();
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddListBoxItem();
        }

        private void AddListBoxItem()
        {
            if (numPosition.Value == -1)
            {
                oList.Add(tboxData.Text);
            }
            else
            {
                oList.Insert((int)numPosition.Value, tboxData.Text);
            }

            lboxList.DataSource = oList.ToList();   // ToList()를 호출해야 갱신된다.

            ListBoxNoCreate();
            ShowListDetail();

            tboxData.Text = string.Empty;
        }

        private void ListBoxNoCreate()
        {
            List<int> iList = (Enumerable.Repeat(0, oList.Count)).ToList();

            for(int i=0; i<iList.Count; i++)
            {
                iList[i] = i + 1;
            }

            lboxNo.DataSource = iList.ToList();
        }

        private void ShowListDetail()
        {
            tboxList.Text = null;

            int iListCount = oList.Count;
            int iListCapacity = oList.Capacity;
            string strListData = string.Join(", ", oList);

            string strListDetail = 
$@"Capacity : {iListCapacity}
Count : {iListCount}
Data : {strListData}
";
            tboxList.Text = strListDetail;
        }
        private void ShowChangeListDetail(List<object> oChangeList)
        {
            tboxChangeList.Text = null;

            int iListCount = oChangeList.Count;
            int iListCapacity = oChangeList.Capacity;

            oChangeList = oChangeList.GetRange(0, iListCount - 1);

            string strListData = string.Join(", ", oChangeList);


            string strListDetail =
$@"Capacity : {iListCapacity}
Count : {iListCount}
Data : {strListData}
";
            tboxChangeList.Text = strListDetail;
        }
    }
}
