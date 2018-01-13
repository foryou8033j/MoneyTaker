using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoneyTaker
{
    public partial class RootForm : MaterialForm
    {

        private FormExchangeManager formManager;
        private DBManager dbManager;
        private Model model;

        public RootForm()
        {
            InitializeComponent();
            formManager = new FormExchangeManager(this);
            dbManager = new DBManager();
            model = new Model();

        }

        /// <summary>
        /// RootForm의 배경 Panel 을 반환합니다.
        /// </summary>
        public Panel GetRootPanel()
        {
            return panelRoot;
        }

        /// <summary>
        /// Form 변경 관리자에 접근합니다.
        /// </summary>
        public FormExchangeManager AccessFormManager()
        {
            return formManager;
        }

        /// <summary>
        /// DB 관리자에 접근합니다.
        /// </summary>
        /// <returns></returns>
        public DBManager AccessDBManager()
        {
            return dbManager;
        }

        public Model AccessModel()
        {
            return model;
        }

        /// <summary>
        /// RootForm 로드 시 정의되는 로직을 작성합니다.
        /// </summary>
        private void RootForm_Load(object sender, EventArgs e)
        {
            //Material Skin Manager 정의
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            AccessFormManager().ShowLoginIdForm();

            

        }

        
    }
}
