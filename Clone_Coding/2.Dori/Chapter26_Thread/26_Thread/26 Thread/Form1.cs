using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Thread
{
    public partial class Form1 : Form
    {
        private enum enumPlayer
        {
            신미나,
            최정현,
            아이유,
            다현,
            수지
        }

        int _locationX = 0;
        int _locationY = 0;

        List<Play> playList = new List<Play>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            foreach(Play play in playList)
            {
                play.ThreadAbort();     // 프로그램 종료 시점이라서 강제로 Thread를 해제
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;

            for (int i = 0; i < numPlayerCount.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString());
                pl.Location = new Point(_locationX, _locationY+ pl.Height *i);
                pl.eventDelMessage += Pl_eventDelMessage;
                pl.Show();

                //pl.test();
                pl.fThreadStart();

                playList.Add(pl);   // Form Closing되는 순간 모든 Thread를 종료하기 위해
            }
        }

        // 완료 된 경우 결과 값 리턴
        private int Pl_eventDelMessage(object sender, string strResult)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    Play oPlayerForm = sender as Play;
                    lboxResult.Items.Add($"Player : {oPlayerForm.StrPlayerName}, Text : {strResult}");
                }));
            }

            return 0;
        }
    }
}
