using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_lssns
{
    public partial class MainForm : Form
    {
        int count = 0; // Задаём начальное значение счетчика

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Мои утилиты' содержит ряд небольших полезных программ", "О программе");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++; // Увеличиваем переменную-счетчик на единицу
            lblCounter.Text = count.ToString(); // Выводим на форму, сконвертировав в строковый тип с помощью встроенного метода ToString
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--; // Уменьшаем переменную-счетчик на единицу
            lblCounter.Text = count.ToString(); // Выводим на форму, сконвертировав в строковый тип с помощью встроенного метода ToString
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            count = 0; // Сбрасываем значение переменной-счетчика
            lblCounter.Text = Convert.ToString(count); // Выводим на форму, сконвертировав в строковый тип с помощью метода ToString из класса Convert
        }
    }
}
