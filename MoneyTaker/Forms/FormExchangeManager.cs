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

        public void ShowFindIdForm()
        {

        }

        public void ShowFindPasswordForm()
        {

        }


    }
}
