using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            Log(DateTime.Now, LogLevel.Info, "프로그램을 시작합니다.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTreeLoad.Click += BtnTreeLoad_Click;
            btnExtend.Click += BtnExtend_Click;
            btnCollapse.Click += BtnCollapse_Click;
            btnCopy.Click += BtnCopy_Click;
            gboxLocation.Paint += GboxLocation_Paint;

            tviewLocation.DoubleClick += TviewLocation_DoubleClick;

            lboxCommand.Click += LboxCommand_Click;
            lboxCommand.DoubleClick += LboxCommand_DoubleClick;

            initControl();
        }

        #region Event

        /// <summary>
        /// 항목을 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LboxCommand_DoubleClick(object sender, EventArgs e)
        {
            if (lboxCommand.SelectedIndex == -1) return;

            lboxCommand.Items.RemoveAt(lboxCommand.SelectedIndex);
        }

        /// <summary>
        /// 현재 경로의 파일을 보여준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LboxCommand_Click(object sender, EventArgs e)
        {
            if (lboxCommand.SelectedIndex == -1) return;

            string dirPath = SourcePath();

            StringBuilder sb = new StringBuilder();
            if (Directory.Exists(dirPath))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
                
                foreach(var dir in dirInfo.GetDirectories())
                {
                    sb.Append($"[Folder] {dir}{Environment.NewLine}");
                }

                foreach(var file in dirInfo.GetFiles())
                {
                    sb.Append($"  {file.Name}{Environment.NewLine}");
                }
            }
            tboxFile.Text = sb.ToString();
        }

        /// <summary>
        /// 화살표 그리기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GboxLocation_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 6);
            pen.StartCap = LineCap.Flat;
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, 281, 100, 296, 100);

            Pen pen2 = new Pen(Color.FromArgb(255, 0, 0, 255), 6);
            pen.StartCap = LineCap.Flat;
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, 445, 150, 445, 165);
        }

        /// <summary>
        /// 파일 경로를 Command List에 추가한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TviewLocation_DoubleClick(object sender, EventArgs e)
        {
            string strSelectedNode = tviewLocation.SelectedNode.FullPath;

            if (lboxCommand.Items.Contains(strSelectedNode))
                return;

            lboxCommand.Items.Add(strSelectedNode);
        }

        /// <summary>
        /// 지정한 경로를 기준으로 TreeView를 설정함.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTreeLoad_Click(object sender, EventArgs e)
        {
            tviewLocation.Nodes.Clear();
            TreeViewLoadByPath(tviewLocation, tboxSource.Text);
        }

        /// <summary>
        /// 노드 확장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExtend_Click(object sender, EventArgs e)
        {
            if (tviewLocation.SelectedNode != null)
            {
                tviewLocation.SelectedNode.ExpandAll();
            }
        }

        /// <summary>
        /// 노드 축소
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCollapse_Click(object sender, EventArgs e)
        {
            tviewLocation.CollapseAll();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxDestination.Text) || !Directory.Exists(tboxDestination.Text))
            {
                Log(DateTime.Now, LogLevel.Error, "Copy 경로가 존재하지 않습니다.");
                return;
            }

            string sourcePath = SourcePath();
            string destPath = $@"{tboxDestination.Text}\{DateTime.Now:yyyyMMdd_hhss}";

            Log(DateTime.Now, LogLevel.Info, $"Source Path : {sourcePath}");
            Log(DateTime.Now, LogLevel.Info, $"Destination Path : {destPath}");

            FileSystem.CopyDirectory(sourcePath, destPath, UIOption.AllDialogs);

            Log(DateTime.Now, LogLevel.Info, "경로에 파일이 복사되었습니다.");
        }

        #endregion

        #region Function

        /// <summary>
        /// 경로를 기준으로 TreeView를 읽어옴.
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="path"></param>
        private void TreeViewLoadByPath(TreeView treeView, string path)
        {
            if (string.IsNullOrEmpty(tboxSource.Text) || !Directory.Exists(tboxSource.Text))
            {
                Log(DateTime.Now, LogLevel.Error, "Source 경로가 존재하지 않습니다.");
                return;
            }

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(path);

            // ** 재귀 함수를 통해 Node경로를 가져온다.
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            TreeNode directoryNode = new TreeNode(directoryInfo.Name);

            foreach(var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach(var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
        }

        private void initControl()
        {
            tboxSource.Text = Application.StartupPath;
            tboxDestination.Text = "D:\\Backup";
        }

        private string SourcePath()
        {
            string path = tboxSource.Text;  // 최상단 경로
            string lastPath = Path.GetDirectoryName(path);  // 한단계 앞 경로
            string strPath = lboxCommand.SelectedItem.ToString();
            string dirPath = $@"{lastPath}\{strPath}";

            return dirPath;
        }

        enum LogLevel
        {
            Info,       // 알림
            warning,    // 경고
            Error       // 오류
        }

        private void Log(DateTime dTime, LogLevel level, string logDesc)
        {
            string logInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{level.ToString()}] {logDesc}";
            
            //lboxLog.Items.Add(logInfo);
            lboxLog.Items.Insert(0, logInfo);
        }

        #endregion
    }
}
