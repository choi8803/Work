using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_Exception
{
    public partial class Form1 : Form
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();

        public Form1()
        {
            InitializeComponent();

            pnlColor.MouseClick += PnlColor_MouseClick;

            tbarAlpha.Scroll += TbarARGB_Scroll;
            tbarR.Scroll += TbarARGB_Scroll;
            tbarG.Scroll += TbarARGB_Scroll;
            tbarB.Scroll += TbarARGB_Scroll;

            lboxColor.SelectedIndexChanged += LboxColor_SelectedIndexChanged;

            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;

            panel2.Click += Panel_Click;
            panel3.Click += Panel_Click;
            panel4.Click += Panel_Click;
            panel5.Click += Panel_Click;
            panel6.Click += Panel_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // 사전에 있는 색상을 제거
                if (lboxColor.SelectedItem != null && dColor.ContainsKey(lboxColor.SelectedItem.ToString()))
                {
                    dColor.Remove(lboxColor.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("삭제 할 항목이 없습니다.");
                }

                LBoxRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pnlColor.BackColor;
                if (dColor.ContainsKey(oColor.ToString()))
                {
                    MessageBox.Show("이미 추가되어 있는 항목입니다.");
                }
                else
                {
                    dColor.Add(oColor.ToString(), oColor);
                    LBoxRefresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 리스트 박스 항목 선택 시 Color저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oSelectColor = dColor[lboxColor.SelectedItem.ToString()];
        }
        /// <summary>
        /// 클릭 시 Panel의 BackColor를 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Panel)
                {
                    Panel panel = sender as Panel;
                    panel.BackColor = oSelectColor;
                }
                else if(sender is TextBox)
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Color Dialog 호출
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PnlColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();

            if (dRet == DialogResult.OK)
            {
                pnlColor.BackColor = cDialogColor.Color;
                tbarAlpha.Value = cDialogColor.Color.A;
                tbarR.Value = cDialogColor.Color.R;
                tbarG.Value = cDialogColor.Color.G;
                tbarB.Value = cDialogColor.Color.B;
            }

            lblColorInfo.Text = pnlColor.BackColor.ToString();
        }

        /// <summary>
        /// Alpha값 변경(투명도 설정)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbarARGB_Scroll(object sender, EventArgs e)
        {
            //pnlColor.BackColor = Color.FromArgb(tbarAlpha.Value, pnlColor.BackColor);
            pnlColor.BackColor = Color.FromArgb(tbarAlpha.Value, tbarR.Value, tbarG.Value, tbarB.Value);
            lblColorInfo.Text = pnlColor.BackColor.ToString();
        }

        /// <summary>
        /// 리스트 박스 새로고침
        /// </summary>
        private void LBoxRefresh()
        {
            try
            {
                lboxColor.Items.Clear();

                foreach (var okey in dColor.Keys)
                {
                    lboxColor.Items.Add(okey);
                }
                lboxColor.SelectedIndex = lboxColor.Items.Count-1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
