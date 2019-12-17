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
    public partial class Form1 : Form
    {
        int balance = 100; //Исходный баланс.
        int counter_money = 0; //Текущий ставка.
        int counter_try = 0; //Счетчик попыток.
        int win_money = 0; //Выигранные деньги.
        bool IsActive = true; //Активность кнопки "Погнали!"
        public Form1()
        {
            InitializeComponent();
            startButton.Enabled = false;
        }
        private void dvg1_Tick(object sender, EventArgs e)
        {
            Random random = new Random(); //Создаем экземпляр класса Random
            int dvg = random.Next(8); // Получаем случайное число от 0-7
            Num1Label.Text = dvg.ToString(); //Выводим полученное число.
        }
        private void dvg2_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int dvg = random.Next(8);
            Num2Label.Text = dvg.ToString();
        }
        private void dvg3_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int dvg = random.Next(8);
            Num3Label.Text = dvg.ToString();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            //активируем таймеры
            dvg1.Enabled = true;
            dvg2.Enabled = true;
            dvg3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
            IsActive = true;
            startButton.Enabled = false; //Пока барабаны крутятся кнопка "Погнали!"  заблокирована.
        }
        private void stop1_Tick(object sender, EventArgs e)
        {
            dvg1.Enabled = false; //Останавливаем таймер запускающий первый барабан.
            stop1.Enabled = false; //Останавливаем таймер останавливающий первый барабан.
        }
        private void stop2_Tick(object sender, EventArgs e)
        {
            dvg2.Enabled = false;
            stop2.Enabled = false;
        }
        private void stop3_Tick(object sender, EventArgs e)
        {
            counter_try--; //Уменьшаем число попыток.
            dvg3.Enabled = false;
            stop3.Enabled = false;
            Win_Money();
            if (IsActive)
            {
                if (counter_try != 0) //Если число попыток больше 0, то даем возможность нажать на кнопку "Погнали!" еще раз, если нет, то блокируем кнопку "Погнали!", и выводим информационное окно.
                {
                    label6.Text = "Осталось попыток: " + counter_try;
                    startButton.Enabled = true;
                }
                else
                {
                    label6.Text = "Осталось попыток: " + counter_try;
                    MessageBox.Show("Делайте новую ставку!", "Попытки закончились...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    makeRateButton.Enabled = true;
                    rateNum.Enabled = true;
                }
            }
        }
        private void Init_Counter(decimal counter)
        {
            counter_money = Convert.ToInt32(counter); 
            balance = balance - counter_money;
            label4.Text = "Баланс: $" + balance;
            counter_try = 5;
            label6.Text = "Осталось попыток: " + counter_try;
        }

        private void Win_Money()
        {
            if (Num1Label.Text == "0" && Num2Label.Text == "0" && Num3Label.Text == "0") Upd_Win_Money(17);
            if (Num1Label.Text == "1" && Num2Label.Text == "1" && Num3Label.Text == "1") Upd_Win_Money(10);
            if (Num1Label.Text == "2" && Num2Label.Text == "2" && Num3Label.Text == "2") Upd_Win_Money(11);
            if (Num1Label.Text == "3" && Num2Label.Text == "3" && Num3Label.Text == "3") Upd_Win_Money(12);
            if (Num1Label.Text == "4" && Num2Label.Text == "4" && Num3Label.Text == "4") Upd_Win_Money(13);
            if (Num1Label.Text == "5" && Num2Label.Text == "5" && Num3Label.Text == "5") Upd_Win_Money(14);
            if (Num1Label.Text == "6" && Num2Label.Text == "6" && Num3Label.Text == "6") Upd_Win_Money(15);
            if (Num1Label.Text == "7" && Num2Label.Text == "7" && Num3Label.Text == "7") Upd_Win_Money(20);
            if ((Num1Label.Text == "0" && Num2Label.Text == "0") || (Num2Label.Text == "0" && Num3Label.Text == "0")) Upd_Win_Money(7);
            if ((Num1Label.Text == "1" && Num2Label.Text == "1") || (Num2Label.Text == "1" && Num3Label.Text == "1")) Upd_Win_Money(1);
            if ((Num1Label.Text == "2" && Num2Label.Text == "2") || (Num2Label.Text == "2" && Num3Label.Text == "2")) Upd_Win_Money(2);
            if ((Num1Label.Text == "3" && Num2Label.Text == "3") || (Num2Label.Text == "3" && Num3Label.Text == "3")) Upd_Win_Money(3);
            if ((Num1Label.Text == "4" && Num2Label.Text == "4") || (Num2Label.Text == "4" && Num3Label.Text == "4")) Upd_Win_Money(4);
            if ((Num1Label.Text == "5" && Num2Label.Text == "5") || (Num2Label.Text == "5" && Num3Label.Text == "5")) Upd_Win_Money(5);
            if ((Num1Label.Text == "6" && Num2Label.Text == "6") || (Num2Label.Text == "6" && Num3Label.Text == "6")) Upd_Win_Money(6);
            if ((Num1Label.Text == "7" && Num2Label.Text == "7") || (Num2Label.Text == "7" && Num3Label.Text == "7")) Upd_Win_Money(10);
        }
        private void Upd_Win_Money(int number)
        {
            win_money = counter_money * number; //умножаем ставку на коэффициент получаем кол-во выигранных денег
            DialogResult result = MessageBox.Show("Вы выиграли: $" + win_money, "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Выыодим поздравления.
            balance = balance + win_money; //Прибавляем выигрыш к балансу
            label4.Text = "Баланс: $" + balance; //Выводим обновленный балансе
            startButton.Enabled = false; //Блокируем кнопку "Погнали!"
            makeRateButton.Enabled = true; //Открываем кнопку "Сделать ставку"
            rateNum.Enabled = true;
            IsActive = false; //Это костыль, может кто-то предложит как от него отказаться ))
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Делайте новую ставку!", "Новая игра", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label6.Text = "Осталось попыток: 0"; // Скидываем оставшиеся попытки.
            }
        }

        private void MakeRateButton_Click(object sender, EventArgs e)
        {
            Init_Counter(rateNum.Value);
            startButton.Enabled = true;
            makeRateButton.Enabled = false;
            rateNum.Enabled = false;
        }
    }
}