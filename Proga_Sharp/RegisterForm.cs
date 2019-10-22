using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proga_Sharp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введіть ім’я";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введіть фамілію";
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Введіть логін";
            loginField.ForeColor = Color.Gray;

            passwordField.UseSystemPasswordChar = false;
            passwordField.Text = "Введіть пароль";
            passwordField.ForeColor = Color.Gray;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

        }

        // Кнопка закриття вікна
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка закриття вікна змінює колір на червоний при наведені
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        // Кнопка закриття вікна змінює колір на білий, якщо курсор не наведений
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastpoint;
        // Рух вікна
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        // Зафіксувати координати при натиснені на вікно
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        // Підказка в полі імені
        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text == "Введіть ім’я")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введіть ім’я";
                userNameField.ForeColor = Color.Gray;
            }
        }

        // Підказка в полі фамілії
        private void UserSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введіть фамілію")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void UserSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введіть фамілію";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        // Підказка в полі логін
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введіть логін")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введіть логін";
                loginField.ForeColor = Color.Gray;
            }
        }

        // Підказка в полі пароль
        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введіть пароль")
            {
                passwordField.Text = "";
                passwordField.UseSystemPasswordChar = true;
                passwordField.ForeColor = Color.Black;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.UseSystemPasswordChar = false;
                passwordField.Text = "Введіть пароль";
                passwordField.ForeColor = Color.Gray;
            }
        }
    }
}
