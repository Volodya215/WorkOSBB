﻿using MySql.Data.MySqlClient;
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
    public partial class EnterServices : Form
    {
        private string loginUser;
        public EnterServices(string loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
        }

        // Закриття вікна
        private void CloseButton_Click(object sender, EventArgs e) => Application.Exit();

        // Колір кнопки при взаємодії
        private void CloseButton_MouseEnter(object sender, EventArgs e) => closeButton.ForeColor = Color.Red;

        private void CloseButton_MouseLeave(object sender, EventArgs e) => closeButton.ForeColor = Color.White;

        // При натиснені повертаємося в головне меню
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mf = new MainForm(loginUser);
            mf.Show();
        }

        // Колір кнопки при взаємодії
        private void BackButton_MouseEnter(object sender, EventArgs e) => backButton.ForeColor = Color.Red;

        private void BackButton_MouseLeave(object sender, EventArgs e) => backButton.ForeColor = Color.White;

        private void EndButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataRow row = table.Rows[0];

            string type = Convert.ToString(row[5]);

            double sum = DeterminePay(type, row);

            MySqlCommand command1 = new MySqlCommand("UPDATE `users_data`.`users` SET `sum` = @sum WHERE `users`.`login` = @login", db.getConnection());

            command1.Parameters.Add("@sum", MySqlDbType.Double).Value = sum;
            command1.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;

            db.openConnection();

            if ((command1.ExecuteNonQuery() == 1))
            {
                MessageBox.Show("Послуги записано");
            }
            else
                MessageBox.Show("Помилка доступу");

            db.closeConnection();
            SetHomePay();
        }

        private double DeterminePay(String type, DataRow row)
        {
            double sum = Convert.ToDouble(electricNum.Value) * 0.25 + Convert.ToDouble(WarmNum.Value) * 25 
                + Convert.ToDouble(GasNum.Value) * 0.34 + Convert.ToDouble(waterNum.Value) * 13 + 200; 

            if (type == "1")
            {
                sum *= 1;
            }
            else if (type == "2")
            {
                sum *= (1 - Convert.ToDouble(row[7]) / 100.0);
            }
            else if (type == "3")
            {
                sum *= (1 + Convert.ToDouble(row[8]) / 100.0);
            }
            return sum;
        }

        private void SetHomePay()
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT sum FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = "admin";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            DataRow row = table.Rows[0];

            int sum = Convert.ToInt32(row[0]);
            sum += 200;

            MySqlCommand command1 = new MySqlCommand("UPDATE `users_data`.`users` SET `sum` = @sum WHERE `users`.`login` = @login", db.getConnection());

            command1.Parameters.Add("@sum", MySqlDbType.Double).Value = sum;
            command1.Parameters.Add("@login", MySqlDbType.VarChar).Value = "admin";

            db.openConnection();

            if ((command1.ExecuteNonQuery() != 1))
            {
                MessageBox.Show("Помилка доступу");
            }
            db.closeConnection();
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
