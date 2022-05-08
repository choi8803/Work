using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 문자열보간
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;
            btn6.Click += Btn6_Click;
            btn7.Click += Btn7_Click;
        }

        // ex) $@ : 문자열보간 : 보관된 문자열로 식별함.
        private void Btn7_Click(object sender, EventArgs e)
        {
            int id = 3;
            string query = $@"
Select 
    *
From T_OIMMAIN T1
    Left join T_OIHMAIN T2 on T1.F_ID = T2.F_OIMBLId
Where F_ID = {id}
                            ";
            tbox7Value.Text = query;
        }

        // ex) 이스케이프 시퀀스 변환
        private void Btn6_Click(object sender, EventArgs e)
        {
            /*
             * Escape Sequance
             *  줄바꿈 : \n
             *  캐리지 리턴 : \r
             *  가로탭 : \t
             *  세로탭 : \v
             *  작은따옴표 : \'
             *  큰 따옴표 : \"
             *  백슬러시 : \\
             */
            
            string strValue = "일반 String -->\r\n C:\\Users\\User\\문자열보간";

            // @ : Escape Sequance 문자를 무시함.
            string strValue2 = @"@ String --> 
C:\Users\User\문자열보간";

            tbox6Value.Text = strValue + Environment.NewLine + Environment.NewLine  + strValue2;
        }

        // ex) 대문자 변환
        private void Btn5_Click(object sender, EventArgs e)
        {
            string strValue = tbox5Value.Text;

            lboxStringFormat.Items.Add(string.Format("대문자 변환 : {0}", strValue.ToUpper()));
            lboxStringInterpolation.Items.Add(string.Format($"대문자 변환 : {strValue.ToUpper()}"));
        }

        // ex) {{{0}}} / {{{ value }}} 보간문자를 사용하고 싶을 경우
        private void Btn4_Click(object sender, EventArgs e)
        {
            string strValue = "Value";

            lboxStringFormat.Items.Add(string.Format("{{{0}}}", strValue));
            lboxStringInterpolation.Items.Add($"{{{strValue}}}");
        }

        // ex) 1, 2 중 큰 수는 2입니다.
        private void Btn3_Click(object sender, EventArgs e)
        {
            int i1 = (int)num1.Value;
            int i2 = (int)num2.Value;

            lboxStringFormat.Items.Add(string.Format("{0}, {1} 중 큰 수는 {2}입니다.", i1, i2, i1 > i2 ? i1 : i2));
            lboxStringInterpolation.Items.Add($"{i1}, {i2} 중 큰 수는 {(i1 > i2 ? i1 : i2)}입니다.");
        }

        // ex) 오늘은 2022-02-12일 입니다.
        private void Btn2_Click(object sender, EventArgs e)
        {
            DateTime dt = dtPicker.Value;
            lboxStringFormat.Items.Add(string.Format("오늘은 {0:yyyy-MM-dd}일 입니다.", dt));
            lboxStringInterpolation.Items.Add($"오늘은 {dt:yyy-MM-dd}일 입니다.");
        }

        // ex) He is Teacher
        private void Btn1_Click(object sender, EventArgs e)
        {
            string s1 = tbox1Value1.Text;
            string s2 = tbox1Value2.Text;

            // 1.string.Format
            string strValue = string.Format("{0} is {1}", s1, s2);
            lboxStringFormat.Items.Add(strValue);

            // 2.stringInterpolation
            strValue = $"{s1} is {s2}";
            lboxStringInterpolation.Items.Add(strValue);
        }
    }
}
