using _22_Dictionary.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _22_Dictionary
{
    public partial class Form1 : Form
    {
        enum enEntertainerName
        {
            다현,
            지아,
            수지,
            아이유
        }
        enum enClassName
        {
            정현,
            미나,
            미송,
            은희,
            길자,
            창선,
            은지,
            은비,
            채연,
            민주,
            원영,
            지민,
            정국,
            성민,
            성준,
            진홍,
            삼무,
            철종,
            한샘,
            민섭,
        }

        Hashtable _ht = new Hashtable();
        Dictionary<string, string> _dic = new Dictionary<string, string>();

        int iPlayerCount = 0;
        bool bflag = false;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pboxDH.Image = Resources.다현;
            pboxDH.Tag = "다현";
            pboxJA.Image = Resources.프리지아1;
            pboxJA.Tag = "프리지아1";
            pboxSJ.Image = Resources.수지1;
            pboxSJ.Tag = "수지1";
            pboxIU.Image = Resources.아이유3;
            pboxIU.Tag = "아이유3";

            pboxDH.Click += pbox_Click;
            pboxJA.Click += pbox_Click;
            pboxSJ.Click += pbox_Click;
            pboxIU.Click += pbox_Click;
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;

            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pboxDH":
                    strSelectText = enEntertainerName.다현.ToString();
                    if ((string)pboxDH.Tag == "다현")
                    {
                        pboxDH.Image = Resources.다현3;
                        pboxDH.Tag = "다현3";
                    }
                    else
                    {
                        pboxDH.Image = Resources.다현;
                        pboxDH.Tag = "다현";
                    }
                    break;
                case "pboxJA":
                    strSelectText = enEntertainerName.지아.ToString();
                    if ((string)pboxJA.Tag == "프리지아1")
                    {
                        pboxJA.Image = Resources.프리지아2;
                        pboxJA.Tag = "프리지아2";
                    }
                    else
                    {
                        pboxJA.Image = Resources.프리지아1;
                        pboxJA.Tag = "프리지아1";
                    }
                    break;
                case "pboxSJ":
                    strSelectText = enEntertainerName.수지.ToString();
                    if ((string)pboxSJ.Tag == "수지1")
                    {
                        pboxSJ.Image = Resources.수지2;
                        pboxSJ.Tag = "수지2";
                    }
                    else
                    {
                        pboxSJ.Image = Resources.수지1;
                        pboxSJ.Tag = "수지1";
                    }
                    break;
                case "pboxIU":
                    strSelectText = enEntertainerName.아이유.ToString();
                    if ((string)pboxIU.Tag == "아이유3")
                    {
                        pboxIU.Image = Resources.아이유4;
                        pboxIU.Tag = "아이유4";
                    }
                    else
                    {
                        pboxIU.Image = Resources.아이유3;
                        pboxIU.Tag = "아이유3";
                    }
                    break;
                default:
                    break;
            }

            int iTotalCount = Enum.GetValues(typeof(enClassName)).Length;
            if (iTotalCount > iPlayerCount)
            {
                enClassName enName = (enClassName)iPlayerCount;
                _dic.Add(enName.ToString(), strSelectText);

                fUIDisplay(iTotalCount, enName.ToString());
                fDataGridViewDisplay();

                iPlayerCount++;
            }
            else
            {
                lblPlayerName.Text = "투표를 완료 하였습니다.";
            }
        }

        private void fUIDisplay(int iTotalCount, string strPlayerName)
        {
            int iDH = 0;
            int iJA = 0;
            int iSJ = 0;
            int iIU = 0;

            foreach (string item in _dic.Values)
            {
                switch (item)
                {
                    case "다현":
                        iDH++;
                        break;
                    case "지아":
                        iJA++;
                        break;
                    case "수지":
                        iSJ++;
                        break;
                    case "아이유":
                        iIU++;
                        break;
                }
            }

            lblPickDH.Text = iDH.ToString();
            lblPickJA.Text = iJA.ToString();
            lblPickSJ.Text = iSJ.ToString();
            lblPickIU.Text = iIU.ToString();

            lblPlayerName.Text = strPlayerName;
            lblTotalCount.Text = $"{iPlayerCount + 1} / {iTotalCount}";
        }

        private void fDataGridViewDisplay()
        {
            gvDicList.DataSource = _dic.Select(x => new { 투표자 = x.Key, 연예인 = x.Value }).ToList();

            foreach (DataGridViewRow row in gvDicList.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            // AutoSizeToAllHeaders : 모든 행 머리글 셀의 내용에 맞게 행 머리글 너비가 조정됩니다.
            gvDicList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
