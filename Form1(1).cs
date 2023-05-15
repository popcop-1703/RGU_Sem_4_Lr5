using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string YearMade = textBox1.Text;
            string PowEr = textBox2.Text;
            string Exists = comboBox1.Text;
            string NumbСores = textBox4.Text;

            bool isYear = int.TryParse(YearMade, out int Year);
            bool isPow = decimal.TryParse(PowEr, out decimal power);
            bool isCores = int.TryParse(NumbСores, out int cores);


            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "" && textBox4.Text == "") MessageBox.Show("Заполните все поля", "Ошибка");
            else if (textBox1.Text == "") MessageBox.Show("Заполните поле Год постройки электростанции", "Ошибка");
            else if (textBox2.Text == "") MessageBox.Show("Заполните поле Мощность электростанции", "Ошибка");
            else if (comboBox1.Text == "") MessageBox.Show("Заполните поле Действует", "Ошибка");
            else if (textBox4.Text == "") MessageBox.Show("Заполните поле Количество ядер", "Ошибка");
            else if (!isYear)
            {
                MessageBox.Show("Введено неверное число, год должен быть целым положительным числом.", "Ошибка");
            }
            else if (Year < 0)
            {
                MessageBox.Show("Значение года не может быть отрицательным, введите положительное число", "Ошибка");

            }
            else if (Year > 2023 || Year < 1882)
            {
                MessageBox.Show("Введите значение года из диапазона от 1882 до 2023", "Ошибка");
            }
            else if (!isPow)
            {
                MessageBox.Show("Введено неверное число, пробег должен быть положительным числом", "Ошибка");
            }
            else if (power < 0)
            {
                MessageBox.Show("Значение мощности не может быть отрицательным, введите положительное число", "Ошибка");
            }
            else if (!isCores)
            {
                MessageBox.Show("Введено не число, введите число", "Ошибка");
            }
            else if (cores < 0)
            {
                MessageBox.Show("Количество ядер не может быть отрицательным, введите целое положительное число", "Ошибка");
            }
            else if (cores < 2)
            {
                MessageBox.Show("Минимальное количество ядер = 1, введите количество ядер", "Ошибка");
            }
            else if (cores > 8)
            {
                MessageBox.Show("Максимальное количество ядер = 8, введите количество ядер", "Ошибка");
            }
            else
            {
                Hydroplant hplant = new Hydroplant();
                hplant.Year = Year;
                hplant.Power = power;
                hplant.Exists = comboBox1.Text;
                hplant.NumbOfСores = cores;
                MessageBox.Show(hplant.ToString(), "Информация о Атомной электростанции",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string YearMade = textBox1.Text;
            string PowEr = textBox2.Text;
            string Exists = comboBox1.Text;
            string numPipes = textBox5.Text;

            bool isYear = int.TryParse(YearMade, out int Year);
            bool isPow = decimal.TryParse(PowEr, out decimal power);
            bool isPipes = decimal.TryParse(numPipes, out decimal numpipes);


            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "" && textBox5.Text == "") MessageBox.Show("Заполните все поля", "Ошибка");
            else if (textBox1.Text == "") MessageBox.Show("Заполните поле Год постройки электростанции", "Ошибка");
            else if (textBox2.Text == "") MessageBox.Show("Заполните поле Мощность электростанции", "Ошибка");
            else if (comboBox1.Text == "") MessageBox.Show("Заполните поле Действует", "Ошибка");
            else if (textBox5.Text == "") MessageBox.Show("Заполните поле Количество турбин", "Ошибка");
            else if (!isYear)
            {
                MessageBox.Show("Введено неверное число, год должен быть целым положительным числом.", "Ошибка");
            }
            else if (Year < 0)
            {
                MessageBox.Show("Значение года не может быть отрицательным, введите положительное число", "Ошибка");

            }
            else if (Year > 2023 || Year < 1882)
            {
                MessageBox.Show("Введите значение года из диапазона от 1882 до 2023", "Ошибка");
            }
            else if (!isPow)
            {
                MessageBox.Show("Введено неверное число, мощность должен быть положительным числом", "Ошибка");
            }
            else if (power < 0)
            {
                MessageBox.Show("Значение мощности не может быть отрицательным, введите положительное число", "Ошибка");
            }
            else if (!isPipes)
            {
                MessageBox.Show("Введено неверное число, количество турбин должно быть положительным числом", "Ошибка");
            }
            else if (numpipes < 0)
            {
                MessageBox.Show("Количество турбин не может быть отрицательным, введите положительное число", "Ошибка");
            }
            else if (numpipes < 1)
            {
                MessageBox.Show("Минимальное количество турбин = 1, введите верное количество турбин", "Ошибка");
            }
            else if (numpipes > 32)
            {
                MessageBox.Show("Максимальное количество трубин = 32, введите верное количество турбин", "Ошибка");
            }
            else
            {
                Thermplant tplant = new Thermplant();
                tplant.Year = Year;
                tplant.Power = power;
                tplant.Exists = comboBox1.Text;
                tplant.NumpipesOf = numpipes;
                MessageBox.Show(tplant.ToString(), "Информация о Тепловой электростанции",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string YearMade = textBox1.Text;
            string PowEr = textBox2.Text;
            string Exists = comboBox1.Text;


            bool isYear = int.TryParse(YearMade, out int Year);
            bool isPow = decimal.TryParse(PowEr, out decimal power);


            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "" && textBox4.Text == "") MessageBox.Show("Заполните все поля", "Ошибка");
            else if (textBox1.Text == "") MessageBox.Show("Заполните поле Год постройки электростанции", "Ошибка");
            else if (textBox2.Text == "") MessageBox.Show("Заполните поле Мощность электростанции", "Ошибка");
            else if (comboBox1.Text == "") MessageBox.Show("Заполните поле Действует", "Ошибка");
            else if (comboBox2.Text == "") MessageBox.Show("Заполните поле Используемый тип генератора", "Ошибка");
            else if (!isYear)
            {
                MessageBox.Show("Введено неверное число, год должен быть целым положительным числом.", "Ошибка");
            }
            else if (Year < 0)
            {
                MessageBox.Show("Значение года не может быть отрицательным, введите положительное число", "Ошибка");

            }
            else if (Year > 2023 || Year < 1882)
            {
                MessageBox.Show("Введите значение года из диапазона от 1882 до 2023", "Ошибка");
            }
            else if (!isPow)
            {
                MessageBox.Show("Введено неверное число, пробег должен быть положительным числом", "Ошибка");
            }
            else if (power < 0)
            {
                MessageBox.Show("Значение мощности не может быть отрицательным, введите положительное число", "Ошибка");
            }
            else
            {
                Nuclearplant nplant = new Nuclearplant();
                nplant.Year = Year;
                nplant.Power = power;
                nplant.Exists = comboBox1.Text;
                nplant.Type = comboBox2.Text;
                MessageBox.Show(nplant.ToString(), "Информация о Газовойэлектростанции",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                double energy = double.Parse(textBox2.Text + e.KeyChar);
                if (energy < 0 || energy > 1000000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                double year = double.Parse(textBox1.Text + e.KeyChar);
                if (year < 0 || year > 2023)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                double kol = double.Parse(textBox4.Text + e.KeyChar);
                if (kol < 0 || kol > 10000)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                double kol = double.Parse(textBox4.Text + e.KeyChar);
                if (kol < 0 || kol > 10000)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
