using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_User32
{
    public partial class Form1 : Form
    {
        GlobalKeyboardHook _keyboardHook = new GlobalKeyboardHook();
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Title
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            this.Text = $"Copy&Paste Ver.{version.Major}.{version.Minor} / Build Time({GetBuildDateTime(version)})";

            #region Event

            _keyboardHook.Hook();
            _keyboardHook.KeyDown += _keyboardHook_KeyDown;

            lboxTextSave.SelectedIndexChanged += LboxTestSave_SelectedIndexChanged;
            lboxTextSave.KeyDown += LboxTextSave_KeyDown;

            // 타이핑 등록
            btnTextAdd.Click += BtnTextAdd_Click;

            // 투명도 
            TBar.Scroll += TBar_Scroll;

            txtTextAdd.KeyDown += TxtTextAdd_KeyDown;
            cboxActivation.CheckedChanged += CboxActivation_CheckedChanged;

            SaveMenuStripItem.Click += SaveMenuItem_Click;
            SaveCMenuStripItem.Click += SaveMenuItem_Click;
            LoadMenuStripItem.Click += LoadMenuItem_Click;
            LoadCMenuStripItem.Click += LoadMenuItem_Click;
            TrimMenuStripItem.Click += TrimMenuItem_Click;
            TrimCMenuStripItem.Click += TrimMenuItem_Click;
            RemoveAllMenuStripItem.Click += RemoveAllMenuItem_Click;
            RemoveAllCMenuStripItem.Click += RemoveAllMenuItem_Click;
            ProgramInfoMenuStripItem.Click += ProgramInfoMenuItem_Click;
            ProgramInfoCMenuStripItem.Click += ProgramInfoMenuItem_Click;

            #endregion
        }

        private void LboxTextSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lboxTextSave.SelectedItems.Count > 0)
                    lboxTextSave.Items.RemoveAt(lboxTextSave.SelectedIndex);
            }
        }

        /// <summary>
        /// 폼 컨트롤 활성화 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboxActivation_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxActivation.Checked)
            {
                lblActivation.Text = "활성화 상태(Ctrl + C 가능)";
                lblActivation.Enabled = true;

                txtTextAdd.Enabled = true;
                btnTextAdd.Enabled = true;
            }
            else
            {
                lblActivation.Text = "비활성화 상태(붙여넣기만 가능)";
                lblActivation.Enabled = false;

                txtTextAdd.Enabled = false;
                btnTextAdd.Enabled = false;
            }
        }

        /// <summary>
        /// 폼 투명도 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TBar_Scroll(object sender, EventArgs e)
        {
            this.Opacity = TBar.Value / 10.0;
        }

        /// <summary>
        /// 버튼을 통한 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTextAdd_Click(object sender, EventArgs e)
        {
            AddInputText();
        }

        /// <summary>
        /// 키보드 이벤트(EnterKey) 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtTextAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddInputText();
            }
        }

        /// <summary>
        /// Clipboard에 항목 저장
        /// </summary>
        private void AddInputText()
        {
            string strText = txtTextAdd.Text;
            if (!string.IsNullOrEmpty(strText) && !lboxTextSave.Items.Contains(strText))
            {
                lboxTextSave.Items.Add(strText);
                txtTextAdd.Text = string.Empty;
            }
        }

        /// <summary>
        /// 복사 : Ctrl + C
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _keyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && cboxActivation.Checked)
            {
                Thread.Sleep(400);
                lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
            }
        }

        /// <summary>
        /// 붙여넣기 : Ctrl + V
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LboxTestSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxTextSave.SelectedIndex != -1)
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTextSave.SelectedItem.ToString());
        }

        /// <summary>
        /// Build Time을 가져오는 함수
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
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
            if (TimeZone.IsDaylightSavingTime(dtBuildDate, dylightTime))
            {
                dtBuildDate = dtBuildDate.Add(dylightTime.Delta);
            }

            return dtBuildDate;
        }

        #region MenuStrip

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            FileSave();
        }
        private void LoadMenuItem_Click(object sender, EventArgs e)
        {
            FileLoad();
        }
        private void TrimMenuItem_Click(object sender, EventArgs e)
        {
            EmptyDelete();
        }
        private void RemoveAllMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }
        private void ProgramInfoMenuItem_Click(object sender, EventArgs e)
        {
            ProgramInfo();
        }

        #endregion

        #region Event Function

        /// <summary>
        /// 저장하기
        /// </summary>
        private void FileSave()
        {
            SaveFileDialog sfDialog = new SaveFileDialog();

            int lboxCount = lboxTextSave.Items.Count;
            string filePath = string.Empty;

            sfDialog.InitialDirectory = Application.StartupPath;
            sfDialog.FileName = "*.txt";
            sfDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = sfDialog.FileName;
                    StreamWriter sw = new StreamWriter(filePath);

                    for (int i = 0; i < lboxCount; i++)
                    {
                        sw.WriteLine(lboxTextSave.Items[i].ToString());
                    }
                    sw.Close();
                    MessageBox.Show("저장이 완료 되었습니다.","항목 저장");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error(FileSave) : " + ex.Message);
            }
        }

        /// <summary>
        /// 불러오기
        /// </summary>
        private void FileLoad()
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            string filePath = string.Empty;

            ofDialog.InitialDirectory = Application.StartupPath;
            ofDialog.FileName = "*.txt";
            ofDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            try
            {
                if (ofDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofDialog.FileName;
                    StreamReader sr = new StreamReader(filePath, Encoding.UTF8, true);

                    while (sr.EndOfStream == false)
                    {
                        lboxTextSave.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error(FileLoad) : " + ex.Message);
            }
        }

        /// <summary>
        /// 공백 제거 
        /// </summary>
        private void EmptyDelete()
        {
            for (int i = 0; i < lboxTextSave.Items.Count; i++)
            {
                lboxTextSave.Items[i] = lboxTextSave.Items[i].ToString().Trim();
            }
        }

        /// <summary>
        /// 모두 삭제
        /// </summary>
        private void DeleteAll()
        {
            if(MessageBox.Show("등록되어 있는 데이터를 초기화 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lboxTextSave.Items.Clear();
            }
        }

        /// <summary>
        /// 프로그램 정보
        /// </summary>
        private void ProgramInfo()
        {
            string sInfo = "반복 작업을 도와주는 프로그램";
            MessageBox.Show(sInfo, "프로그램 정보");
        }

        #endregion
    }
}
