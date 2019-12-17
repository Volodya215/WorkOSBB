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
    public partial class MainForm : Form
    {
        private string loginUser;
        public MainForm(string loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
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

        // Фіксуємо точку натиснення поля
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        // Робота з кнопкою закриття вікна
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        // Переглянути дані про юзера
        private void DataUserButton_Click(object sender, EventArgs e)
        {
            Hide();
            UserData ud = new UserData(loginUser);
            ud.Show();
        }

        // Ввести показники лічильників
        private void EnterButton_Click(object sender, EventArgs e)
        {
            Hide();
            EnterServices es = new EnterServices(loginUser);
            es.Show();
        }

        // Змінити юзера
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users_data`.`users` SET `sum` = @sum WHERE `users`.`login` = @uL", db.getConnection());

            command.Parameters.Add("@sum", MySqlDbType.VarChar).Value = 0.0;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                MessageBox.Show("Послуги оплачено");
            }
            else
                MessageBox.Show("Помилка доступу");

            db.closeConnection();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 g = new Form1();
            g.Show();
        }
    }
}
