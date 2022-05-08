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
    public partial class ucPanel : UserControl
    {
        // * Step 1 - Double Click -> Button.BackColor
        public event EventHandler eLabelDoubleClickHandler;

        public ucPanel()
        {
            InitializeComponent();
            this.Load += UcPanel_Load;
            this.SizeChanged += UcPanel_SizeChanged;        // Form Load Event에서 호출하면 Label에 사이즈 값이 표시되지 않는다.

            // * Step 2 - Double Click -> Button.BackColor
            lblPanel.DoubleClick += UcPanel_DoubleClick;
        }

        // * Step 3 - Double Click -> Button.BackColor
        private void UcPanel_DoubleClick(object sender, EventArgs e)
        {
            eLabelDoubleClickHandler(this, e);
        }

        private void UcPanel_Load(object sender, EventArgs e)
        {

        }

        private void UcPanel_SizeChanged(object sender, EventArgs e)
        {
            lblPanel.Text = $"({lblPanel.Width},{lblPanel.Height})";
        }
    }
}
