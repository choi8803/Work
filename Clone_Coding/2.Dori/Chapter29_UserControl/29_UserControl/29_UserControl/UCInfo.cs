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
    public partial class UCInfo : UserControl
    {
        public delegate void delEvent(object sender, string strText);
        public event delEvent eventDelSender;

        [Category("UserProperty"), Description("Image")]
        public Image UserFace 
        { 
            get 
            { 
                return this.pboxFace.BackgroundImage; 
            } 
            set 
            { 
                this.pboxFace.BackgroundImage = value; 
            } 
        }

        [Category("UserProperty"), Description("No")]
        public string UserNo
        {
            get { return this.lblNo.Text; }
            set { this.lblNo.Text = value; }
        }

        [Category("UserProperty"), Description("현상범의 이름")]
        public string UserName
        {
            get { return this.lblName.Text; }
            set { this.lblName.Text = value; }
        }

        [Category("UserProperty"), Description("현상범의 금액")]
        public string UserAmount
        {
            get { return this.lblAmount.Text; }
            set { this.lblAmount.Text = value; }
        }

        public UCInfo()
        {
            InitializeComponent();

            btnReg.Click += Btn_Click;
            btnIdle.Click += Btn_Click;
            btnCatch.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string strText = string.Empty;

            switch (btn.Name)
            {
                case "btnReg":
                    this.BackColor = Color.Red;
                    strText = $"{lblName.Text}은 금액은 {lblAmount.Text}으로 수배중 입니다.";
                    break;
                case "btnIdle":
                    this.BackColor = Color.Green;
                    strText = $"{lblName.Text}은 수배중지 입니다.";
                    break;
                case "btnCatch":
                    this.BackColor = Color.Yellow;
                    strText = $"{lblName.Text}은 잡혔습니다.";
                    break;
            }
            if (eventDelSender != null)
                eventDelSender(this, strText);
        }
    }
}
