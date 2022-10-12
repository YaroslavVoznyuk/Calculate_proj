namespace CalcWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(554, 396);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        /// <summary>
        /// "="
        /// </summary>
        private System.Windows.Forms.Button buttonCalc;
        /// <summary>
        /// "0"
        /// </summary>
        private System.Windows.Forms.Button button0;
        /// <summary>
        /// "1"
        /// </summary>
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// "2"
        /// </summary>
        private System.Windows.Forms.Button button2;
        /// <summary>
        /// "3"
        /// </summary>
        private System.Windows.Forms.Button button3;
        /// <summary>
        /// "4"
        /// </summary>
        private System.Windows.Forms.Button button4;
        /// <summary>
        /// "5"
        /// </summary>
        private System.Windows.Forms.Button button5;
        /// <summary>
        /// "6"
        /// </summary>
        private System.Windows.Forms.Button button6;
        /// <summary>
        /// "7"
        /// </summary>
        private System.Windows.Forms.Button button7;
        /// <summary>
        /// "8"
        /// </summary>
        private System.Windows.Forms.Button button8;
        /// <summary>
        /// "9"
        /// </summary>        
        private System.Windows.Forms.Button button9;
        /// <summary>
        /// "CE"
        /// </summary>
        private System.Windows.Forms.Button buttonClear;
        /// <summary>
        /// ","
        /// </summary>
        private System.Windows.Forms.Button buttonPoint; 

        /// <summary>
        /// "+"
        /// </summary>
        private System.Windows.Forms.Button buttonPlus;
        /// <summary>
        /// "-"
        /// </summary>
        private System.Windows.Forms.Button buttonMinus;
        /// <summary>
        /// "*"
        /// </summary>
        private System.Windows.Forms.Button buttonMult;
        /// <summary>
        /// "/"
        /// </summary>
        private System.Windows.Forms.Button buttonDiv;
        /// <summary>
        /// "MRC"
        /// </summary>
        private System.Windows.Forms.Button buttonMRC;
        /// <summary>
        /// "M-"
        /// </summary>
        private System.Windows.Forms.Button buttonMMinus;
        /// <summary>
        /// "M+"
        /// </summary>
        private System.Windows.Forms.Button buttonMPlus;
        /// <summary>
        /// "M*"
        /// </summary>
        private System.Windows.Forms.Button buttonMMult;
        /// <summary>
        /// "M/"
        /// </summary>
        private System.Windows.Forms.Button buttonMDiv;
        /// <summary>
        /// "n!"
        /// </summary>
        private System.Windows.Forms.Button buttonFactorial;
        /// <summary>
        /// "^Y" - введение в произвольную ст
        /// </summary>
        private System.Windows.Forms.Button buttonDegreeY;
        /// <summary>
        /// корень произвольной степени
        /// </summary>
        private System.Windows.Forms.Button buttonSqrtX;
        /// <summary>
        /// квадрат числа
        /// </summary>
        private System.Windows.Forms.Button buttonSquare;
        /// <summary>
        /// корень кв
        /// </summary>
        private System.Windows.Forms.Button buttonSqrt;
        /// <summary>
        /// Кнопка изменения знака у числа "+/-"
        /// </summary>
        private System.Windows.Forms.Button buttonChangeSign; 

        private System.Windows.Forms.GroupBox groupBox1;
        /// <summary>
        /// label для вывода
        /// </summary>
        private System.Windows.Forms.Label labelNumber; 

        #endregion

        Calc C;

        int k;

        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }

        private bool CanPress()
        {
            if (!buttonMult.Enabled)
                return false;

            if (!buttonDiv.Enabled)
                return false;

            if (!buttonPlus.Enabled)
                return false;

            if (!buttonMinus.Enabled)
                return false;

            if (!buttonSqrtX.Enabled)
                return false;

            if (!buttonDegreeY.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            buttonMult.Enabled = true;
            buttonDiv.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonSqrtX.Enabled = true;
            buttonDegreeY.Enabled = true;
        }

    }
}

