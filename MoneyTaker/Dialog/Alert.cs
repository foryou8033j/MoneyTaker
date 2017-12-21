using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTaker
{
    /// <summary>
    /// 사용자 알림, 경고등을 알려주는 Alert 박스 디자인
    /// </summary>
    public partial class Alert : MaterialForm
    {
        public Alert()
        {
            InitializeComponent();
        }

        public Alert(Form parent, Exception e)
        {

            
            InitializeComponent();

            TopLevel = false;
            Parent = parent;

            this.Text = "Error";
            lbnContents.Text = e.Message;
        }

        public Alert(Form parent, String title, String contents)
        {
            
            InitializeComponent();

            TopLevel = false;
            Parent = parent;


            this.Text = title;  // 명시적 this 지칭
            lbnContents.Text = contents;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            //Material Skin Manager 정의
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }
    }
}
