namespace _30_Lambda
{
    public partial class Form1 : Form
    {
        /*
         * ������ : delInt dInt = (a, b) => a * b;
         * ������ : delInt dInt = (a, b) => { return a * b; };
         * ���� �޼���_Func : Func<int, int, int> dInt = (a, b) => a * b;
         * ���� �޼���_Action : Func<int, int> dInt = (a, b) => { lblNum.Text = (a * b).toString(); }
         */
        enum enumLambdaCase
        {
            ������_���ٽ� = 0,
            ������_���ٽ� = 1,
            ���ϸ�_������_����޼���_Func = 2,
            ���׸�_������_����޼���_Action = 3,
            ���׸�_������_��ȯ_���� = 4
        }

        private int _num = 0;

        delegate int delIntFunc(int a, int b);
        delegate string delStringFunc();

        Action _aStepCheck = null;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // �̺�Ʈ �Լ� ���
            btnColorChange_1.Click += BtnColorChange_1_Click;

            // ���� �޼ҵ� ���
            btnColorChange_2.Click += delegate (object? s, EventArgs e)
            {
                btnColorChange_2.BackColor = Color.Yellow;
            };

            // ���ٽ� ���
            btnColorChange_3.Click += (s, e) =>
            {
                btnColorChange_3.BackColor = Color.Green;
            };

            // ����
            btnNext.Click += BtnNext_Click;

            // Action<string>
            _aStepCheck = () => lblStepCheck.Text = $"- ���� Step�� {_num+1}.{(enumLambdaCase)_num}";
            _aStepCheck();

        }

        private void BtnColorChange_1_Click(object? sender, EventArgs e)
        {
            btnColorChange_1.BackColor = Color.Red;
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            Lambda(_num);
            _num++;
            _aStepCheck();
        }

        private void Lambda(int iCase)
        {
            int iRet;
            string strRet;

            switch (iCase)
            {
                case (int)enumLambdaCase.������_���ٽ�:
                    delStringFunc dString = () => "������ ���ٽ� : 4 * 5 = ";
                    strRet = dString();
                    lboxResult.Items.Add(strRet); 
                    
                    delIntFunc dInt = (a, b) => a * b;
                    iRet = dInt(4, 5);
                    lboxResult.Items.Add(iRet.ToString());
                    break;
                case (int)enumLambdaCase.������_���ٽ�:
                    delStringFunc dString2 = () => 
                    {
                        return "������ ���ٽ� : 4 * 5 = ";
                    };
                    strRet = dString2();
                    lboxResult.Items.Add(strRet);

                    delIntFunc dInt2 = (a, b) =>
                    {
                        return a * b;
                    };
                    iRet = dInt2(4, 5);
                    lboxResult.Items.Add(iRet.ToString());
                    break;
                case (int)enumLambdaCase.���ϸ�_������_����޼���_Func:
                    Func<string> dString3 = () => "���׸� ������ ����޼���(Func) : 4 * 5 = ";
                    strRet= dString3();
                    lboxResult.Items.Add(strRet);

                    Func<int, int, int> dInt3 = (a, b) => a * b;
                    iRet = dInt3(4, 5);
                    lboxResult.Items.Add(iRet.ToString());
                    break;
                case (int)enumLambdaCase.���׸�_������_����޼���_Action:
                    Action<string> dString4 = (a) =>
                    {
                        lboxResult.Items.Add(a);
                    };
                    dString4("���׸� ������ ���� �޼���(Action) : 4 * 5 = ");

                    Action<int, int> dInt4 = (a, b) => 
                    {
                        lboxResult.Items.Add((a*b).ToString());
                    };
                    dInt4(4, 5);
                    break;
                case (int)enumLambdaCase.���׸�_������_��ȯ_����:
                    int[] iGroup = { 1, 3, 5, 7, 9 };
                    int iNumSum = iGroup.Sum();
                    lboxResult.Items.Add("���׸� ������ ��ȯ 1 : " + iNumSum.ToString());

                    string[] strGroup = {"�Ź̳�", "������", "����", "����" };
                    int iLengthSum = strGroup.Sum(x => x.Length);
                    lboxResult.Items.Add("���׸� ������ ��ȯ 2 : " + iLengthSum.ToString());
                    break;
                default:
                    break;

            }
        }
    }
}