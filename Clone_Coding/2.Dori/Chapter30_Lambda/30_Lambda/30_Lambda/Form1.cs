namespace _30_Lambda
{
    public partial class Form1 : Form
    {
        /*
         * 식형식 : delInt dInt = (a, b) => a * b;
         * 문형식 : delInt dInt = (a, b) => { return a * b; };
         * 무명 메서드_Func : Func<int, int, int> dInt = (a, b) => a * b;
         * 무명 메서드_Action : Func<int, int> dInt = (a, b) => { lblNum.Text = (a * b).toString(); }
         */
        enum enumLambdaCase
        {
            식형식_람다식 = 0,
            문형식_람다식 = 1,
            제니릭_형태의_무명메서드_Func = 2,
            제네릭_형태의_무명메서드_Action = 3,
            제네릭_형태의_반환_예제 = 4
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
            // 이벤트 함수 사용
            btnColorChange_1.Click += BtnColorChange_1_Click;

            // 무명 메소드 사용
            btnColorChange_2.Click += delegate (object? s, EventArgs e)
            {
                btnColorChange_2.BackColor = Color.Yellow;
            };

            // 람다식 사용
            btnColorChange_3.Click += (s, e) =>
            {
                btnColorChange_3.BackColor = Color.Green;
            };

            // 예제
            btnNext.Click += BtnNext_Click;

            // Action<string>
            _aStepCheck = () => lblStepCheck.Text = $"- 다음 Step은 {_num+1}.{(enumLambdaCase)_num}";
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
                case (int)enumLambdaCase.식형식_람다식:
                    delStringFunc dString = () => "식형식 람다식 : 4 * 5 = ";
                    strRet = dString();
                    lboxResult.Items.Add(strRet); 
                    
                    delIntFunc dInt = (a, b) => a * b;
                    iRet = dInt(4, 5);
                    lboxResult.Items.Add(iRet.ToString());
                    break;
                case (int)enumLambdaCase.문형식_람다식:
                    delStringFunc dString2 = () => 
                    {
                        return "문형식 람다식 : 4 * 5 = ";
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
                case (int)enumLambdaCase.제니릭_형태의_무명메서드_Func:
                    Func<string> dString3 = () => "제네릭 형태의 무명메서드(Func) : 4 * 5 = ";
                    strRet= dString3();
                    lboxResult.Items.Add(strRet);

                    Func<int, int, int> dInt3 = (a, b) => a * b;
                    iRet = dInt3(4, 5);
                    lboxResult.Items.Add(iRet.ToString());
                    break;
                case (int)enumLambdaCase.제네릭_형태의_무명메서드_Action:
                    Action<string> dString4 = (a) =>
                    {
                        lboxResult.Items.Add(a);
                    };
                    dString4("제네릭 형태의 무명 메서드(Action) : 4 * 5 = ");

                    Action<int, int> dInt4 = (a, b) => 
                    {
                        lboxResult.Items.Add((a*b).ToString());
                    };
                    dInt4(4, 5);
                    break;
                case (int)enumLambdaCase.제네릭_형태의_반환_예제:
                    int[] iGroup = { 1, 3, 5, 7, 9 };
                    int iNumSum = iGroup.Sum();
                    lboxResult.Items.Add("제네릭 형태의 반환 1 : " + iNumSum.ToString());

                    string[] strGroup = {"신미나", "최정현", "다현", "수지" };
                    int iLengthSum = strGroup.Sum(x => x.Length);
                    lboxResult.Items.Add("제네릭 형태의 반환 2 : " + iLengthSum.ToString());
                    break;
                default:
                    break;

            }
        }
    }
}