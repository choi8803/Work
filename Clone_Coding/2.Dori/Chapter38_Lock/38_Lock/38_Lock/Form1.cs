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

namespace _38_Lock
{
    public partial class Form1 : Form
    {
        Thread _T1;
        Thread _T2;

        object _RoomLock = new object();    // 1번 Thread가 끝나고 2번 Thread가 실행된다.
        object _RoomLock2 = new object();

        int _iRoom1Count = 1;
        int _iRoom2Count = 1;
        int _iPlayer =1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoom1_Click(object sender, EventArgs e)
        {
            lboxRoom1.Items.Add($"Room 1 : {_iPlayer} 예약");
            _T1 = new Thread(new ParameterizedThreadStart(Run));
            _T1.Start(_iPlayer);

            _iPlayer++;
        }

        private void Run(object obj)
        {
            lock (_RoomLock)
            {
                InvokeFunction(lblLockStatus, $"Room 1 : Player {obj} 사용 중");
                
                for (int i = 1; i <= 3; i++)
                {
                    InvokeFunction(lboxResult, $"Room 1 : Player {obj} 진행 중... {i}");

                    Thread.Sleep(1000);
                }
                InvokeFunction(lblLockStatus, $"Room 1 : Player {obj} 사용 완료");

                Thread.Sleep(1000);
            }
        }

        private void btnRoom2_Click(object sender, EventArgs e)
        {
            lboxRoom2.Items.Add($"Room 2 : {_iPlayer} 예약");
            _T2 = new Thread(new ParameterizedThreadStart(Run2));
            _T2.Start(_iPlayer);

            _iPlayer++;
        }

        private void Run2(object obj)
        {
            lock (_RoomLock)
            {
                InvokeFunction(lblLockStatus, $"Room 2 : Player {obj} 사용 중");

                for (int i = 1; i <= 3; i++)
                {
                    InvokeFunction(lboxResult, $"Room 2 : Player {obj} 진행 중... {i}");

                    Thread.Sleep(1000);
                }
                InvokeFunction(lblLockStatus, $"Room 2 : Player {obj} 사용 완료");

                Thread.Sleep(1000);
            }
        }

        private void InvokeFunction(Control control, string str)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate ()
                {
                    if (control is ListBox)
                    {
                        ListBox lbox = control as ListBox;
                        lbox.Items.Add(str);
                        Refresh();
                    }
                    else if(control is Label)
                    {
                        control.Text = str;
                    }
                }));
            }
        }
    }
}
