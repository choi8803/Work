using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_Layout
{
    /*
     * # 동적 Layout
     * 1. TableLayoutPanel : Table형태의 Layout
     * 2. SplitContainer : 이동이 가능한 Split Panel
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // # Step 3 - Button Click -> Panel.BackColor
            //ucCMenu.eColorSender += UcCMenu_eColorSender;
            ucCMenu.eColorAction += UcCMenu_eColorAction;

            // * Step 4 - Double Click -> Button.BackColor
            ucPanelTop.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter1.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter2.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelRight.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
        }
        // # Step 4 - Button Click -> Panel.BackColor
        private void UcCMenu_eColorAction(Button btn, Color color)
        {
            string strPanelName = string.Empty;

            switch (btn.Name)
            {
                case "btn1":
                    ucPanelTop.BackColor = color;
                    strPanelName = "Panel Top";
                    break;
                case "btn2":
                    ucPanelCenter1.BackColor = color;
                    strPanelName = "Panel Center1";
                    break;
                case "btn3":
                    ucPanelCenter2.BackColor = color;
                    strPanelName = "Panel Center2";
                    break;
                case "btn4":
                    ucPanelRight.BackColor = color;
                    strPanelName = "Panel Right";
                    break;
                default:
                    break;
            }

            string strResult = $"선택 : {btn.Name}, {strPanelName}의 색상은 {color.ToString()}로 변경";
            lboxLog.Items.Add(strResult);
        }
        // * Step 5 - Double Click -> Button.BackColor
        private void UcPanel_eLabelDoubleClickHandler(object sender, EventArgs e)
        {
            string strResult = ucCMenu.ButtonColorChange((ucPanel)sender);
            lboxLog.Items.Add(strResult);
        }

        
    }
}
