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
    public partial class ucColorMenu : UserControl
    {
        // 1. Delegate Event 선언
        public delegate void delColorSender(object sender, Color color);
        public event delColorSender eColorSender;

        // 2. 기본 EventHandler
        public event EventHandler eColorEventHandler;

        // # Step 1 - Button Click -> Panel.BackColor
        // 3. 제네릭 형태의 delegate 사용
        public event Action<Button, Color> eColorAction;

        public ucColorMenu()
        {
            InitializeComponent();

            this.Load += UcColorMenu_Load;
        }

        private void UcColorMenu_Load(object sender, EventArgs e)
        {
            pColor.MouseClick += PColor_MouseClick;

            for(int i =1; i<5; i++)
            {
                Button btn = new Button();
                btn.Name = $"btn{i}";
                btn.Text = $"P{i} 색상 변경";
                btn.BackColor = Color.Gray;
                btn.Size = new Size(100, 30);
                btn.Click += Btn_Click;
                btn.Margin = new Padding(10, 10, 0, 0);

                flpMenu.Controls.Add(btn);
            }
        }

        // # Step 2 - Button Click -> Panel.BackColor
        private void Btn_Click(object sender, EventArgs e)
        {
            //eColorSender(sender, pColor.BackColor);   // 1)
            //eColorEventHandler(sender, e);            // 2)
            eColorAction((Button)sender, pColor.BackColor);     // 3)
        }

        private void PColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDialog.ShowDialog();

            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cDialog.Color;
            }
        }

        // * Step 6 - Double Click -> Button.BackColor
        public string ButtonColorChange(ucPanel panel)
        {
            string strBtnName = string.Empty;
            string strResult = string.Empty;

            switch (panel.Name)
            {
                case "ucPanelTop":
                    strBtnName = "btn1";
                    break;
                case "ucPanelCenter1":
                    strBtnName = "btn2";
                    break;
                case "ucPanelCenter2":
                    strBtnName = "btn3";
                    break;
                case "ucPanelRight":
                    strBtnName = "btn4";
                    break;
                default:
                    break;
            }
            strResult = BtnSearch(strBtnName, panel.Name, panel.BackColor);
            return strResult;
        }

        private string BtnSearch(string strButtonName, string strPanelName, Color color)
        {
            string strResult = string.Empty;

            foreach (var item in flpMenu.Controls)
            {
                if(item is Button)
                {
                    Button btn = item as Button;

                    if (btn.Name.Equals(strButtonName))
                    {
                        btn.BackColor = color;
                        strResult = $"{strPanelName} Panel DoubleClick, {strButtonName}의 색상을 {color}로 변경";
                        return strResult;
                    }
                }
            }
            return null;
        }
    }
}
