using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load 이벤트에서 이벤트 설정
            //ucInfo1.eventDelSender += UcInfo_eventDelSender;
            //ucInfo2.eventDelSender += UcInfo_eventDelSender;
            //ucInfo3.eventDelSender += UcInfo_eventDelSender;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var control in pMain.Controls)
            {
                if(control is UCInfo)
                {
                    UCInfo ucInfo = control as UCInfo;
                    ucInfo.eventDelSender += UcInfo_eventDelSender;
                }
            }
        }

        private void UcInfo_eventDelSender(object sender, string strText)
        {
            UCInfo ucInfo = sender as UCInfo;
            lboxList.Items.Add($"{ucInfo.UserNo}) {strText}");
        }
    }
}
