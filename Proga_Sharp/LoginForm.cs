using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //this.passwordField.AutoSize = false;
            //this.passwordField.Size = new Size(this.passwordField.Size.Width, height: 54);
            
            // Підказки для полів логін та пароль
            loginField.Text = "Введіть логін";
            loginField.ForeColor = Color.Gray;

            passwordField.UseSystemPasswordChar = false;
            passwordField.Text = "Введіть пароль";
            passwordField.ForeColor = Color.Gray;

        }

     
        // Закриття вікна при натиснені на кнопку
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Змінюємо колір кнопки при наведені курсора
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        // Повертаємо колір кнопки назад, коли курсор покидає кнопку
        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastpoint;
        // Рух вікна
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

       // Фіксуємо точку натиснення поля
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        // Залогінитися юзером
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passwordField.Text;

            if(loginUser == "admin" && passUser == "admin")
            {
                Hide();
                AdminInfo ai = new AdminInfo();
                ai.Show();
                return;
            }

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            try
            {
                DataRow temp = table.Rows[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Невірно введено пароль!");
                return;
            }
            DataRow row = table.Rows[0];
            int id = Convert.ToInt32(row[0]);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Доступ дозволено");
                Hide();
                MainForm mf = new MainForm(loginUser);
                mf.Show();
            }
            else
                MessageBox.Show("Невірно введений логін або пароль!");
        }

        // Підказка в полі логін знкикає, коли заходимо в поле
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введіть логін")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        // ПІдказка з’являється, коли покидаємо поле не ввівши даних
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введіть логін";
                loginField.ForeColor = Color.Gray;
            }
        }

        // Підказка в полі пароль знкикає, коли заходимо в поле
        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введіть пароль")
            {
                passwordField.Text = "";
                passwordField.UseSystemPasswordChar = true;
                passwordField.ForeColor = Color.Black;
            }
        }

        // ПІдказка з’являється, коли покидаємо поле не ввівши даних
        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.UseSystemPasswordChar = false;
                passwordField.Text = "Введіть пароль";
                passwordField.ForeColor = Color.Gray;
            }
        }

        // При натиснені переходимо на форму реєстрації
        private void RegistrLabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            ChooseType chooseT = new ChooseType();
            chooseT.Show();
        }

        // КОли наводимо мишку, текст змінює колір на червоний
        private void RegistrLabel_MouseEnter(object sender, EventArgs e)
        {
            registrLabel.ForeColor = Color.Red;
        }

        // Коли забираємо мишку, текст змінбє колір назад на білий
        private void RegistrLabel_MouseLeave(object sender, EventArgs e)
        {
            registrLabel.ForeColor = Color.White;
        }
    }
}
