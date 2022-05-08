using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Queue_Stack
{
    public partial class Form1 : Form
    {
        Queue<int> _Queue = new Queue<int>();
        Stack<int> _Stack = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDataIn.Click += BtnDataIn_Click;
        }

        private void BtnDataIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iDate = rd.Next(1, 101);

            // Queue에 데이터 입력
            if (_Queue.Count < 6)
            {
                _Queue.Enqueue(iDate);
                fQueueDataDisplay();
            }

            if (_Stack.Count < 6)
            {
                _Stack.Push(iDate);
                fStackDataDisplay();
            }
        }

        private void fQueueDataDisplay()
        {
            int[] iArray = _Queue.ToArray();

            Array.Resize(ref iArray, 6);

            lblQueue2.Text = (iArray[0] == 0 ? "" : iArray[0].ToString());
            lblQueue1.Text = (iArray[1] == 0 ? "" : iArray[1].ToString());
            lblQueue3.Text = (iArray[2] == 0 ? "" : iArray[2].ToString());
            lblQueue4.Text = (iArray[3] == 0 ? "" : iArray[3].ToString());
            lblQueue5.Text = (iArray[4] == 0 ? "" : iArray[4].ToString());
            lblQueue6.Text = (iArray[5] == 0 ? "" : iArray[5].ToString());
        }

        private void fStackDataDisplay()
        {
            int[] iArray = _Stack.ToArray();

            Array.Resize(ref iArray, 6);

            lblStack1.Text = (iArray[0] == 0 ? "" : iArray[0].ToString());
            lblStack2.Text = (iArray[1] == 0 ? "" : iArray[1].ToString());
            lblStack3.Text = (iArray[2] == 0 ? "" : iArray[2].ToString());
            lblStack4.Text = (iArray[3] == 0 ? "" : iArray[3].ToString());
            lblStack5.Text = (iArray[4] == 0 ? "" : iArray[4].ToString());
            lblStack6.Text = (iArray[5] == 0 ? "" : iArray[5].ToString());
        }
    }
}
