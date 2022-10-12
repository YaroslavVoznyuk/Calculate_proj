using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            C = new Calc();

            //label1.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
                label1.Text = label1.Text.Remove(0, 1);
            else
                label1.Text = "-" + label1.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((label1.Text.IndexOf(",") == -1) && (label1.Text.IndexOf("∞") == -1))
                label1.Text += ",";
        }

        #region nums 0-9

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";

            CorrectNumber();
        }

        #endregion

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (!Multiply.Enabled)
                label1.Text = C.Multiplication(Convert.ToDouble(label1.Text)).ToString();

            if (!Divide.Enabled)
                label1.Text = C.Division(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonMPlus.Enabled)
                label1.Text = C.Sum(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonMMinus.Enabled)
                label1.Text = C.Subtraction(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonSqrtX.Enabled)
                label1.Text = C.SqrtX(Convert.ToDouble(label1.Text)).ToString();

            if (!buttonDegreeY.Enabled)
                label1.Text = C.DegreeY(Convert.ToDouble(label1.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        #region multiply, divide, etc

        //кнопка Умножение
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));;

                Multiply.Enabled = false;

                label1.Text = "0";
            }
        }

        //кнопка Деление
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                Divide.Enabled = false;

                label1.Text = "0";
            }
        }

        //кнопка Сложение
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonMPlus.Enabled = false;

                label1.Text = "0";
            }
        }

        //кнопка Вычитание
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonMMinus.Enabled = false;

                label1.Text = "0";
            }
        }

        //кнопка Корень произвольной степени
        private void buttonSqrtX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonSqrtX.Enabled = false;

                label1.Text = "0";
            }
        }

        //кнопка Возведение в произвольную степень
        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                buttonDegreeY.Enabled = false;

                label1.Text = "0";
            }
        }

        //кнопка Корень квадратный
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                label1.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        //кнопка Квадрат числа
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));

                label1.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        //кнопка Факториал
        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(label1.Text) == (int)(Convert.ToDouble(label1.Text))) &&
                    ((Convert.ToDouble(label1.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(label1.Text));

                    label1.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }

        #endregion

    }
}
