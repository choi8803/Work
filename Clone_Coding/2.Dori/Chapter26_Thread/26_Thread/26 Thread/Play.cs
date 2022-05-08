using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_Thread
{
    public partial class Play : Form
    {
        // # Delegate 이벤트 선언
        public delegate int delMessage(object sender, string strResult);    
        public event delMessage eventDelMessage;

        string _strPlayerName = string.Empty;
        public string StrPlayerName { get => _strPlayerName; set => _strPlayerName = value; }

        Thread _thread = null;
        bool _bThreadStop = false;   // Thread Stop을 위한 Flag

        public Play()
        {
            InitializeComponent();
        }

        public Play(string strPlayerName)
        {
            InitializeComponent();

            lblPlayerName.Text = StrPlayerName = strPlayerName;
        }

        public void fThreadStart()
        {
            // # Thread 생성 방법
            //_thread = new Thread(new ThreadStart(Run));       // ThreadStart라는 Delegate 타입 객체를 생성 후 함수를 넘김
            //_thread = new Thread(delegate () { Run(); });     // ThreadStart라는 Delegate 타입 객체를 생성 후 함수를 넘김
            _thread = new Thread(Run);                          // 컴파일러에서 델리게이트 객체를 추론해서 생성 후 함수를 넘김
            _thread.Start();
        }

        private void Run()
        {
            // # UI Control이 자신이 만들어진 Thread가 아닌 다른 Thread에서 접근할 경우 Cross Thread가 발생
#if false
            // Case 1 : CheckForIllegalCrossThreadCalls -> Thread 충돌에 대한 예외 처리를 무시(Corss Thread 무시)
            //          (하나의 자원에 대해서 여러개의 Thread가 동시에 접근 하게되면 자원관리에 문제가 발생 할 수 있음.)
            CheckForIllegalCrossThreadCalls = false;  
#endif
            try
            {

                int ivar = 0;
                Random rd = new Random();

                while (pbarPlayer.Value < 100 && !_bThreadStop)
                {
                    // # Case 2 : Invoke를 사용해서 Main Thread에게 위임
                    if (this.InvokeRequired)    // # 요청 한 Thread가 현재 Main Thread있는 Control을 엑세스 할 수 있는지 확인
                    {
                        this.Invoke(new Action(delegate ()
                        {
                        // 함수값
                        ivar = rd.Next(1, 11);
                            if (pbarPlayer.Value + ivar > 100)
                            {
                                pbarPlayer.Value = 100;
                            }
                            else
                            {
                                pbarPlayer.Value += ivar;
                            }

                            lblProcess.Text = $"진행 상황 표시 : {pbarPlayer.Value}%";
                            this.Refresh();
                        }));
                    }
                    Thread.Sleep(300);
                }

                if (_bThreadStop)
                {
                    eventDelMessage(this, "중도 포기... (Thread Stop)");

                }
                else
                {
                    eventDelMessage(this, "완주!! (Thread Complete)");
                }
            }
            catch (ThreadInterruptedException ex)
            {
                // wait, join, sleep 상태가 되면 발생
                ex.ToString();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        public void test()
        {
            int ivar = 0;

            Random rd = new Random();
            
            while (pbarPlayer.Value < 100)
            {
                ivar = rd.Next(1, 11);
                if(pbarPlayer.Value + ivar > 100)
                {
                    pbarPlayer.Value = 100;
                }
                else
                {
                    pbarPlayer.Value += ivar;
                }

                lblProcess.Text = $"진행 상황 표시 : {pbarPlayer.Value}%";
                this.Refresh();
                Thread.Sleep(300);
            }
        }

        private void btnReRun_Click(object sender, EventArgs e)
        {
            ThreadResume();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            //ThreadAbort();
            //ThreadJoin();
            //ThreadInterrupt();
            ThreadFlag();
            //ThreadSuspend();
        }

        // MainForm에서도 종료하기 위해 생성
        public void ThreadAbort()
        {
            if (_thread.IsAlive)
            {
                _thread.Abort();
                this.Enabled = false;
            }
        }

        // Thread가 종료될때 까지 대기
        public void ThreadJoin()
        {
            if (_thread.IsAlive)
            {
                var bThreadEnd = _thread.Join(3000);    // 3초 대기
            }
        }

        // Thread가 WaitJoinSleep 시점을 찾아서 예외를 발생
        public void ThreadInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
                this.Enabled = false;
            }
        }

        public void ThreadFlag()
        {
            if (_thread.IsAlive)
            {
                _bThreadStop = true;
                this.Enabled = false;
            }
        }

        public void ThreadSuspend()
        {
            if (_thread.IsAlive)
            {
                _thread.Suspend();
            }
        }
        public void ThreadResume()
        {
            if (_thread.ThreadState == ThreadState.Suspended)
            {
                _thread.Resume();
            }
        }

        
    }
}
