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
    public partial class AdminInfo : Form
    {
        public AdminInfo()
        {
            InitializeComponent();
            GetSum();
            GetDebtors();
        }

        private void GetSum()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = "admin";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataRow row = table.Rows[0];
            sumBox.Text = Convert.ToString(row[6]);
        }

        private void GetDebtors()
        {
             DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT name, surname FROM `users` WHERE sum<>0", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = "admin";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string[] arr = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                arr[i] = Convert.ToString(row[1]) + " " + Convert.ToString(row[0]);
            }
            debtorsList.Items.AddRange(arr);

        }

        private void CloseButton_Click(object sender, EventArgs e) => Application.Exit();

        private void CloseButton_MouseEnter(object sender, EventArgs e) => closeButton.ForeColor = Color.Red;

        private void CloseButton_MouseLeave(object sender, EventArgs e) => closeButton.ForeColor = Color.White;

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void BackButton_MouseEnter(object sender, EventArgs e) => backButton.ForeColor = Color.Red;

        private void BackButton_MouseLeave(object sender, EventArgs e) => backButton.ForeColor = Color.White;

        private void WriteOffButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command1 = new MySqlCommand("UPDATE `users_data`.`users` SET `sum` = @sum WHERE `users`.`login` = @login", db.getConnection());

            command1.Parameters.Add("@sum", MySqlDbType.Double).Value = 0;
            command1.Parameters.Add("@login", MySqlDbType.VarChar).Value = "admin";

            db.openConnection();

            if ((command1.ExecuteNonQuery() != 1))
            {
                MessageBox.Show("Помилка доступу");
            }
            db.closeConnection();
            sumBox.Text = Convert.ToString(0);
        }
    }
}
