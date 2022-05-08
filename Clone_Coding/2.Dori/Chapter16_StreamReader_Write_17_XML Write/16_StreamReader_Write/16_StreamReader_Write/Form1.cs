using System.Text;

namespace _16_StreamReader_Write
{
    public partial class Form1 : Form
    {
        CXMLControl _XML = new CXMLControl();
        Dictionary<string, string> _dData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            btnConfigRead.Click += BtnConfigRead_Click;
            btnConfigSet.Click += BtnConfigSet_Click;
            btnLoad.Click += BtnLoad_Click;
            btnSave.Click += BtnSave_Click;
        }

        // Config 읽어오기 :
        private void BtnConfigRead_Click(object? sender, EventArgs e)
        {
#if false
            string[] strConfig = tBoxConfigData.Text.Split(Environment.NewLine);
            tboxData.Text = strConfig[0];
            cboxData.Checked = bool.Parse(strConfig[1]);
            numData.Value = int.Parse(strConfig[2]);
#else
            tboxData.Text = _dData[CXMLControl._TEXT_DATA];
            cboxData.Checked = bool.Parse(_dData[CXMLControl._CBOX_DATA]);
            numData.Value = int.Parse(_dData[CXMLControl._NUMBER_DATA]);
#endif
        }

        // Config 설정하기 : 입력한 데이터를 Multi TextBox에 표시
        private void BtnConfigSet_Click(object? sender, EventArgs e)
        {
            string strText = tboxData.Text;
            bool bChecked = cboxData.Checked;
            int iNumber = (int)numData.Value;

            StringBuilder sb = new StringBuilder();
            sb.Append(strText + Environment.NewLine);
            sb.Append(bChecked.ToString() + Environment.NewLine);
            sb.Append(iNumber.ToString() + Environment.NewLine);

            tBoxConfigData.Text = sb.ToString();

            _dData.Clear();
            _dData.Add(CXMLControl._TEXT_DATA, strText);
            _dData.Add(CXMLControl._CBOX_DATA, bChecked.ToString());
            _dData.Add(CXMLControl._NUMBER_DATA, iNumber.ToString());
        }

        // Text 읽어오기 :
        private void BtnLoad_Click(object? sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;    // 프로그램 실행 파일 위치
#if false
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
#else
            OFDialog.FileName = "*.xml";
            OFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
#endif

            StringBuilder sb = new StringBuilder();
            if(OFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = OFDialog.FileName;

                // System.IO > StreamReader
#if false
                StreamReader srOFDialog = new StreamReader(strFilePath, Encoding.UTF8, true);
                while (srOFDialog.EndOfStream == false) // 마지막 줄이 아니면 반복
                {
                    sb.Append(srOFDialog.ReadLine());
                    sb.Append(Environment.NewLine);
                }
#endif
                // System.IO > File
                sb.Append(File.ReadAllText(strFilePath, Encoding.UTF8));

                tBoxConfigData.Text = sb.ToString()?.TrimEnd();

                _dData.Clear();
                _dData = _XML.fXML_Reader(strFilePath);
            }
        }

        // Text 저장하기 : 입력 정보를 파일로 저장
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;        // 프로그램 실행 파일 위치
#if false
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
#else
            SFDialog.FileName = "*.xml";
            SFDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
#endif
            if (SFDialog.ShowDialog() == DialogResult.OK)
            {
                strFilePath = SFDialog.FileName;
                // System.IO > StreamWriter
#if false
                StreamWriter swSFDialog = new StreamWriter(strFilePath);
                swSFDialog.WriteLine(tBoxConfigData.Text);
                swSFDialog.Close();
#endif
#if false
                // System.IO > File
                File.WriteAllText(strFilePath, tBoxConfigData.Text);
#endif
                // XML형태
                _XML.fXML_Writer(strFilePath, _dData);
;            }
        }
    }
}