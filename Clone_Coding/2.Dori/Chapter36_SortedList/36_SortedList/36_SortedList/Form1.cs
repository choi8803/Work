using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_SortedList
{
    public partial class Form1 : Form
    {
        SortedList<DateTime, string> slScheduler = new SortedList<DateTime, string>();
        Dictionary<DateTime, string> dScheduler = new Dictionary<DateTime, string>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnScheduler.Click += BtnScheduler_Click;
            lboxScheduler.SelectedIndexChanged += LboxScheduler_SelectedIndexChanged;
        }

        private void LboxScheduler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strResult = lboxScheduler.SelectedItem.ToString();
            string[] strArray = strResult.Split(":");
            string sTemp = string.Empty;

            mcScheduler.SelectionStart = Convert.ToDateTime(strArray[0].Trim());
            foreach(string str in strArray)
            {
                if (str != strArray[0])
                    sTemp += str;
            }
            tboxScheduler.Text = sTemp.TrimStart();
        }

        private void BtnScheduler_Click(object sender, EventArgs e)
        {

#if false
            // # LinkedList : 값을 끼워 넣는 예제
            LinkedList<string> sLinkedList = new LinkedList<string>();

            for(int i=0; i<10; i++)
            {
                sLinkedList.AddLast(i.ToString());
            }

            var findNode = sLinkedList.Find("5");   // Node를 찾아서 찾은 Node다음에 값을 추가 할 수 있다.
            sLinkedList.AddAfter(findNode, "5-1");
#endif
            DateTime dSetDate = mcScheduler.SelectionStart;

            if (!slScheduler.ContainsKey(dSetDate))
            {
                slScheduler.Add(dSetDate, tboxScheduler.Text);
            }
            else
            {
                slScheduler.Remove(dSetDate);
                slScheduler.Add(dSetDate, tboxScheduler.Text);
            }
            mcScheduler.AddBoldedDate(dSetDate);
            mcScheduler.UpdateBoldedDates();

            lboxScheduler.Items.Clear();
            foreach(KeyValuePair<DateTime, string> item in slScheduler)
            {
                lboxScheduler.Items.Add($"{item.Key.ToString("yyyy-MM-dd")} : {item.Value}");
            }
        }
    }
}
