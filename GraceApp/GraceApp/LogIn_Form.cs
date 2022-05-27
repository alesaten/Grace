using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraceApp
{
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();

            Password_textBox.UseSystemPasswordChar = true;
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            string Login = Login_textBox.Text;
            string Password = Password_textBox.Text;

            if ((Password == "_12345678_") && (Login == "Admin"))
            {
                AdministratorForm Administatror = new AdministratorForm();

                Administatror.Show();
                Hide();
            }
            else if ((Password == "0000") && (Login == "Seller"))
            {
                SellerForm Seller = new SellerForm();

                Seller.Show();
                Hide();
            }
            else if ((Password == "1234") && (Login == "ChiefOfficer"))
            {
                ChiefOfficerForm ChiefOfficer = new ChiefOfficerForm();

                ChiefOfficer.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Пароль введён неверно.");
            }
        }

        private void Login_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Login_textBox.Text))
            {
                errorProvider.SetError(Login_textBox, "Не указан логин");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void Password_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Password_textBox.Text))
            {
                errorProvider.SetError(Password_textBox, "Не указан пароль");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideShowPassword_label_Click(object sender, EventArgs e)
        {
            Password_textBox.UseSystemPasswordChar = false;
        }

        private void HideShowPassword_button_Click(object sender, EventArgs e)
        {
            if (Password_textBox.UseSystemPasswordChar == true)
            {
                Password_textBox.UseSystemPasswordChar = false;
            }
            else if (Password_textBox.UseSystemPasswordChar == false)
            {
                Password_textBox.UseSystemPasswordChar = true;
            }
        }
    }
}
