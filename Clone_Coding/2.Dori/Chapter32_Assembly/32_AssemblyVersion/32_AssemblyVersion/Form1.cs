using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_AssemblyVersion
{
    public partial class Form1 : Form
    {
        Dictionary<string, Stack<CSize>> _dic = new Dictionary<string, Stack<CSize>>();

        // 1.0.0.0
        // 주 버전
        // 부 버전
        // 빌드 번호
        // 수정 버전

        #region ** Net Core에서 Build DateTime을 가져오는 방법
        /* 
         * Net5.0에서 Build DateTim을 가져오는 방법
         * 1. xxx.csproj파일을 메모장으로 연다.
         * 2. <Version>1.0.0</Version> 태그를 아래와 같이 변경 ->
         *    <AssemblyVersion>1.0.*</AssemblyVersion>
         *    <Deterministic>false</Deterministic>
        */
        #endregion

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnConfirm.Click += BtnConfirm_Click;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ControlSizeRead();
            ControlSizeWrite();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;

            this.Text = $"제목 Ver.{version.Major}.{version.Minor} / Build Time ({GetBuildDateTime(version)}) - 프로그램 상태";
        }
        
        private DateTime GetBuildDateTime(Version version = null)
        {
            // 매개 변수가 존재할 경우
            if (version == null)
                version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            // 세번째 값(Build Number)은 2000년 1월 1일부터
            // Build된 날짜까지의 총 일(Days) 수 이다.
            int iDay = version.Build;
            DateTime dtBuildDate = (new DateTime(2000, 1, 1)).AddDays(iDay);

            // 네번째 값(Revision NUmber)은 자정으로부터 Build된
            // 시간까지의 지나간 초(Second) 값 이다.
            int iSeconds = version.Revision;
            iSeconds = iSeconds * 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);

            // 시차 보정
            DaylightTime dylightTime = TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuildDate.Year);
            if(TimeZone.IsDaylightSavingTime(dtBuildDate, dylightTime))
            {
                dtBuildDate = dtBuildDate.Add(dylightTime.Delta);
            }

            return dtBuildDate;
        }

        private void ControlSizeRead()
        {
            _dic.Clear();

            Stack<CSize> sButton = new Stack<CSize>();
            // Button 등록
            foreach(var item in groupBox1.Controls)
            {
                if(item is Button)
                {
                    Button btn = item as Button;

                    CSize size = new CSize();
                    size.Name = btn.Name;
                    size.Width = btn.Width;
                    size.Heigth = btn.Height;

                    sButton.Push(size);
                }
            }
            _dic.Add("BUTTON", sButton);

            Stack<CSize> sLabel = new Stack<CSize>();
            foreach (var item in groupBox1.Controls)
            {
                if (item is Label)
                {
                    Label btn = item as Label;

                    CSize size = new CSize();
                    size.Name = btn.Name;
                    size.Width = btn.Width;
                    size.Heigth = btn.Height;

                    sLabel.Push(size);
                }
            }
            _dic.Add("LABEL", sLabel);
        }

        private void ControlSizeWrite()
        {
            Stack<CSize> control = _dic["BUTTON"];
            foreach(CSize item in control)
            {
                string strResult = $"Button : {item.Name}, Size ({item.Width}, {item.Heigth})";
                lboxResult.Items.Add(strResult);
            }

            control = _dic["LABEL"];
            foreach (CSize item in control)
            {
                string strResult = $"Label : {item.Name}, Size ({item.Width}, {item.Heigth})";
                lboxResult.Items.Add(strResult);
            }
        }
    }
}
