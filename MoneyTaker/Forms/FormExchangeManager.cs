using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTaker
{
    /// <summary>
    /// RootForm에 위치한 RootPanel의 내부 Control Form 변경을 위한 클래스 입니다.
    /// Form Thread 가 아니므로 UI 작업에 주의 바랍니다.
    /// delecate 등을 통해 작업이 가능하긴 하지만 작업 전에 팀장에게 통보바랍니다.
    /// 
    /// Since : 2017-12-20
    /// Autor : 서정삼
    /// </summary>
    public class FormExchangeManager
    {
        public bool initialized = false;

        private RootForm rootForm;
        private Panel rootPanel;

        public FormExchangeManager(RootForm rootForm)
        {
            SetRootForm(rootForm);
        }

        /// <summary>
        /// FormExchangeManager에서 사용할 RootForm 을 정의합니다.
        /// </summary>
        public void SetRootForm(RootForm rootForm)
        {
            // 이미 초기화 된 경우라면 무시한다.
            if (initialized) return;

            this.rootForm = rootForm;
            rootPanel = rootForm.GetRootPanel();

            initialized = true;
        }

        /// <summary>
        /// RootForm 이 지정 된 경우 해당 Form 을 반환합니다.
        /// </summary>
        /// <returns></returns>
        public Form GetRootForm()
        {
            if (rootForm != null)
                return rootForm;
            else
                return null;
        }

        /// <summary>
        /// Form 교체를 위한 메서드
        /// </summary>
        /// <param name="item"></param>
        private void AddPanel(Form item)
        {
            rootPanel.Controls.Clear();
            rootPanel.Controls.Add(item);
            item.Show();
        }

        public void ShowLoginIdForm()
        {
            LoginIdForm loginIdForm = new LoginIdForm();
            loginIdForm.SetFormManager(this);
            loginIdForm.TopLevel = false;

            AddPanel(loginIdForm);

        }

        public void ShowLoginPassForm()
        {
            LoginPasswordForm loginPasswordForm = new LoginPasswordForm();
            loginPasswordForm.SetFormManager(this);
            loginPasswordForm.TopLevel = false;

            AddPanel(loginPasswordForm);
        }

        public void ShowRegisterTermsForm()
        {
            RegisterTermsForm registerTermsForm = new RegisterTermsForm();

            registerTermsForm.SetFormManager(this);
            registerTermsForm.TopLevel = false;

            AddPanel(registerTermsForm);
        }

        public void ShowRegisterForm()
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.SetFormManager(this);
            registerForm.TopLevel = false;

            AddPanel(registerForm);
        }

        public void ShowAlert(String name, Form parent, String title, String contents)
        {
            Alert alert = new Alert(name, parent, title, contents);
            alert.SetFormManager(this);
            //rootPanel.Location = rootPanel.

            AddPanel(alert);
        }

        public void ShowInitInformationForm()
        {
            InitInformationForm initInformationForm = new InitInformationForm();
            initInformationForm.SetFormManager(this);
            initInformationForm.TopLevel = false;

            AddPanel(initInformationForm);
        }

        public void ShowTabBasicForm()
        {
            TabBasicForm tabBasicForm = new TabBasicForm();
            tabBasicForm.SetFormManager(this);
            tabBasicForm.TopLevel = false;

            AddPanel(tabBasicForm);
        }

        public void ShowTabSettingForm()
        {
            TabSettingForm tabSettingForm = new TabSettingForm();
            tabSettingForm.SetFormManager(this);
            tabSettingForm.TopLevel = false;

            AddPanel(tabSettingForm);
        }

        public void ShowFindIdForm()
        {

        }

        public void ShowFindPasswordForm()
        {

        }


    }
}
