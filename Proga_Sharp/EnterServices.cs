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
        public EnterServices()
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
            MainForm mf = new MainForm();
            mf.Show();
        }

        // Колір кнопки при взаємодії
        private void BackButton_MouseEnter(object sender, EventArgs e) => backButton.ForeColor = Color.Red;

        private void BackButton_MouseLeave(object sender, EventArgs e) => backButton.ForeColor = Color.White;
    }
}
