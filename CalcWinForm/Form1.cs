﻿using System;
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
            labelNumber.Text = "0";
        }


        #region nums 0-9
        private void button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";

            CorrectNumber();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "1";

            CorrectNumber();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "2";

            CorrectNumber();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "3";

            CorrectNumber();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "4";

            CorrectNumber();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "5";

            CorrectNumber();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "6";

            CorrectNumber();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "7";

            CorrectNumber();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "8";

            CorrectNumber();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text += "9";

            CorrectNumber();
        }

        #endregion

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            labelNumber.Text = "0";

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void buttonChangeSign_Click_1(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click_1(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }

        private void buttonCalc_Click_1(object sender, EventArgs e)
        {
            if (!buttonMult.Enabled)
                labelNumber.Text = C.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDiv.Enabled)
                labelNumber.Text = C.Division(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonPlus.Enabled)
                labelNumber.Text = C.Sum(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonMinus.Enabled)
                labelNumber.Text = C.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonSqrtX.Enabled)
                labelNumber.Text = C.SqrtX(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDegreeY.Enabled)
                labelNumber.Text = C.DegreeY(Convert.ToDouble(labelNumber.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void buttonMult_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMult.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonDiv_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDiv.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonPlus_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonPlus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonMinus_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMinus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonSqrtX_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonSqrtX.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonDegreeY_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDegreeY.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonSquare_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void buttonSqrt_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        private void buttonFactorial_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) &&
                    ((Convert.ToDouble(labelNumber.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(labelNumber.Text));

                    labelNumber.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }

        private void buttonMPlus_Click_1(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMMinus_Click_1(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMMult_Click_1(object sender, EventArgs e)
        {
            C.M_Multiplication(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMDiv_Click_1(object sender, EventArgs e)
        {
            C.M_Division(Convert.ToDouble(labelNumber.Text));
        }

        private void buttonMRC_Click_1(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    labelNumber.Text = C.MemoryShow().ToString();

                if (k == 2)
                {
                    C.Memory_Clear();
                    labelNumber.Text = "0";

                    k = 0;
                }
            }
        }
    }
}
