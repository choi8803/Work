using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45_DB
{
    public partial class Form1 : Form
    {
        OleDbConnection _conn;
        string _connStr;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDBLoad.Click += BtnDBLoad_Click;
            btnExcute.Click += BtnExcute_Click;
            btnEx1.Click += BtnEx_Click;
            btnEx2.Click += BtnEx_Click;
            btnEx3.Click += BtnEx_Click;
        }

        private void BtnDBLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OpenFileDialog OFDialog = new OpenFileDialog();
            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.accdb";
            OFDialog.Filter = "db files (*.accdb)|*.accdb|All files (*.*)|*.*";

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                tboxPath.Text = OFDialog.FileName;
                //DBConnection(OFDialog.FileName);
                DBConnection_MSSQL(OFDialog.FileName);
            }
        }

        private void DBConnection(string strDbPath)
        {
            string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={strDbPath}";
            _conn = new OleDbConnection(connStr);

            string query = $@"
Select
    *
From project";
            QueryExcute(query);
        }

        private void DBConnection_MSSQL(string strDbPath)
        {
            _connStr = $@"Server = testdb01.ssikor.co.kr; Database = iFMS3TEST_ACT; User Id = sa; Password = voTmdnjem1700";

            string query = $@"Select * From T_INVOHD";

            QueryExcute_MSSQL(query);

            
        }

        private void QueryExcute(string query)
        {
            if (_conn == null) 
            {
                MessageBox.Show("db가 연결되어 있지 않습니다.", "DB Connection");
                return;
            }
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(query, _conn);
            adp.Fill(ds);

            dgData.DataSource = ds.Tables[0];
        }

        private void QueryExcute_MSSQL(string query)
        {
            using (SqlDataAdapter adp = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["iFMS3"].ConnectionString))
            {
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dgData.DataSource = ds.Tables[0];
            }
        }

        private void BtnExcute_Click(object sender, EventArgs e)
        {
            QueryExcute(tboxQuery.Text);
        }

        private void BtnEx_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;
            string query = string.Empty;

            switch (obtn.Name)
            {
                case "btnEx1":
                    query = $@"Select 
    * 
From Project";
                    break;
                case "btnEx2":
                    query = $@"Select 
    * 
From Project 
Where Word like '%FMS%'";
                    break;
                case "btnEx3":
                    query = $@"Select 
* 
From Project 
Where Grade In (1,2,3)";
                    break;
            }
            tboxQuery.Text = query;
        }
    }
}
