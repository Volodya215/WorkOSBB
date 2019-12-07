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
    public partial class UserData : Form
    {
        private string loginUser;

        public UserData(string loginUser)
        {
            this.loginUser = loginUser;
            InitializeComponent();
            saveButton.Enabled = false;
            EnableMethods();
            InstallDataDB();
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

        private void EnableMethods()
        {
            userNameField.Enabled = loginField.Enabled = passField.Enabled = typeField.Enabled 
                = idField.Enabled = feat1Field.Enabled = feat2Field.Enabled = moneyField.Enabled = false;
        }

        private void InstallDataDB()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            DataRow row = table.Rows[0];
            idField.Text = Convert.ToString(row[0]);
            loginField.Text = Convert.ToString(row[1]);
            passField.Text = Convert.ToString(row[2]);
            userNameField.Text = Convert.ToString(row[3]) + " " + Convert.ToString(row[4]);
            typeField.Text = Convert.ToString(row[5]);
            moneyField.Text = Convert.ToString(row[6]);
            feat1Field.Text = Convert.ToString(row[7]);
            feat2Field.Text = Convert.ToString(row[8]);
            SetFeature();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            changeButton.Enabled = false;
            passField.Enabled = feat1Field.Enabled = feat2Field.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckFeatures(typeField.Text))
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users_data`.`users` SET `pass` = @pass, `features1` = @features1, `features2` = @features2  WHERE `users`.`id` = @id", db.getConnection());

            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@features1", MySqlDbType.VarChar).Value = feat1Field.Text;
            command.Parameters.Add("@features2", MySqlDbType.VarChar).Value = feat2Field.Text;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = idField.Text;

            db.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                MessageBox.Show("Акаунт успішно оновлена");
            }
            else
                MessageBox.Show("Акаунт не створено");

            db.closeConnection();

            passField.Enabled = feat1Field.Enabled = feat2Field.Enabled = false;
            changeButton.Enabled = true;
            saveButton.Enabled = false;
        }

        private bool CheckFeatures(string type)
        {
            if (type == "1")
            {
                try
                {
                    Convert.ToDouble(feat1Field.Text);
                    Convert.ToInt32(feat2Field.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некоректно введено властивості!!!");
                    return true;
                }
            }
            else if (type == "2")
            {
                try
                {
                    double discount = Convert.ToDouble(feat1Field.Text);

                    if (discount < 0 && discount > 100)
                    {
                        MessageBox.Show("Некоректно введено знижку!!!");
                        return true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некоректно введено властивості!!!");
                    return true;
                }
            }
            else if (type == "3")
            {
                try
                {
                    Convert.ToInt32(feat2Field.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некоректно введено властивості!!!");
                    return true;
                }
            }
            return false;
        }

        private void SetFeature()
        {
            if (typeField.Text == "1")
                NameLabel("Розмір квартири", "К-кість мешканців");
            else if (typeField.Text == "2")
                NameLabel("Знижка", "Причина пільг");
            else if (typeField.Text == "3")
                NameLabel("Тип підприємства", "К-кість працівників");
        }

        // Встановлюємо назви властивостей залежно від типу користувача
        public void NameLabel(string feat1, string feat2)
        {
            feat1Label.Text = feat1;
            feat2Label.Text = feat2;
        }
    }
}
