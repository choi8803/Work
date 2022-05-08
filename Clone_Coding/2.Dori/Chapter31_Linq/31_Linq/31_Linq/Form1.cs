using System.Data;

namespace _31_Linq
{
    public partial class Form1 : Form
    {
        const string sLevel = "LEVEL";
        const string sName = "NAME";
        const string sAttribute = "ATTRIBUTE";

        DataTable _dt;

        enum EnumName
        {
            슬라임,
            가고일,
            골렘,
            코볼트,
            고블린,
            고스트,
            언데드,
            노움,
            드래곤,
            웜,
            서큐버스,
            데빌,
            만티코어,
            바실리스크
        }

        enum EnumAttribute
        {
            불,
            물,
            바람,
            번개,
            어둠,
            빛,
            땅,
            나무
        }

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            btnLevel.Click += BtnSort_Click;
            btnName.Click += BtnSort_Click;
            btnAttribute.Click += BtnSort_Click;

            btnFilter.Click += BtnFilter_Click;
            btnReset.Click += BtnReset_Click;
        }
        private void Form1_Load(object? sender, EventArgs e)
        {
            DataTableCreate();
            EnemyCreate();
            ComboBoxCreate();
        }

        private void BtnSort_Click(object? sender, EventArgs e)
        {
            Button? oBtn = sender as Button;

            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;
            IEnumerable<DataRow> vSortTable = null;

            switch (oBtn?.Name)
            {
                case "btnLevel":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<int>(sLevel)
                                 select oRow;
                    break;
                case "btnName":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sName)
                                 select oRow;
                    break;
                case "btnAttribute":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sAttribute)
                                 select oRow;
                    break;
            }

            //var vSortTable = from oRow in dtCopy.AsEnumerable()
            //                 orderby oRow.Field<int>(sLevel)
            //                 select oRow;

            dtCopy = vSortTable.CopyToDataTable();
            dgEnemyTable.DataSource = dtCopy;
        }

        private void BtnFilter_Click(object? sender, EventArgs e)
        {
            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;
            IEnumerable<DataRow> vSortTable = from oRow in dtCopy.AsEnumerable()
                                              where oRow.Field<string>(sAttribute) == cboxAttribute.Text &&
                                                oRow.Field<int>(sLevel) >= nLevelMin.Value &&
                                                oRow.Field<int>(sLevel) <= nLevelMax.Value
                                              select oRow;
            if(vSortTable.Count() > 0)
            {
                dtCopy = vSortTable.CopyToDataTable();
                dgEnemyTable.DataSource = dtCopy;
            }
            else
            {
                MessageBox.Show("검색 조건에 맞는 Data가 없습니다.");
            }

        }
        
        private void BtnReset_Click(object? sender, EventArgs e)
        {
            dgEnemyTable.DataSource = _dt;
        }

        private void DataTableCreate()
        {
            _dt = new DataTable("Enemy");

            //DataColumn 생성
            DataColumn colLevel = new DataColumn(sLevel, typeof(int));
            DataColumn colName = new DataColumn(sName, typeof(string));
            DataColumn colAttribute = new DataColumn(sAttribute, typeof(string));

            _dt.Columns.Add(colLevel);
            _dt.Columns.Add(colName);
            _dt.Columns.Add(colAttribute);
        }
        private void EnemyCreate()
        {
            Random rd = new Random();
            foreach(EnumName name in Enum.GetValues(typeof(EnumName)))
            {
                DataRow dr = _dt.NewRow();
                dr[sLevel] = rd.Next(1, 11);    // 1이상~11미만 값이 랜덤하게 생성된다.
                dr[sName] = name.ToString();

                int iEnumLength = Enum.GetValues(typeof(EnumAttribute)).Length;
                int iAttribute = rd.Next(iEnumLength);  // Enum에 등록된 속성 값이 랜덤하게 생성된다.
                dr[sAttribute] = ((EnumAttribute)iAttribute).ToString();
                _dt.Rows.Add(dr);
            }
            dgEnemyTable.DataSource = _dt;
        }
        private void ComboBoxCreate()
        {
            foreach (EnumAttribute item in Enum.GetValues(typeof(EnumAttribute)))
            {
                cboxAttribute.Items.Add(item);
            }
            cboxAttribute.SelectedIndex = 0;
        }
    }
}