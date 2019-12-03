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
    public partial class ChooseType : Form
    {
        public ChooseType()
        {
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
            StartPage sp = new StartPage();
            sp.Show();
        }

        // Колір кнопки при взаємодії
        private void BackButton_MouseEnter(object sender, EventArgs e) => backButton.ForeColor = Color.Red;

        private void BackButton_MouseLeave(object sender, EventArgs e) => backButton.ForeColor = Color.White;

        //      Вибір типу користувача
        private void Inhabitant_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registr = new RegisterForm(1);
            registr.NameLabel("Розмір квартири", "К-кість мешканців");
            registr.Show();
        }

        private void Company_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registr = new RegisterForm(3);
            registr.NameLabel("Тип підприємства", "К-кість працівників");
            registr.Show();
        }

        private void Inhbenefit_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registr = new RegisterForm(2);
            registr.NameLabel("Знижка", "Причина пільг");
            registr.Show();
        }
    }
}
