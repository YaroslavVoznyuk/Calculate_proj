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

        private System.Windows.Forms.Button buttonEqual;

        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;

        private System.Windows.Forms.Button buttonCE;

        private System.Windows.Forms.Button buttonPoint;

        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button buttonZero;

        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Substract;

        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;

        private System.Windows.Forms.Button buttonMRC;

        private System.Windows.Forms.Button buttonMMinus;
        private System.Windows.Forms.Button buttonMPlus;

        private System.Windows.Forms.Button buttonMMultiply;

        private System.Windows.Forms.Button button_MDivide;

        private System.Windows.Forms.Button buttonFactorial;

        private System.Windows.Forms.Button buttonDegreeY;

        private System.Windows.Forms.Button buttonSqrtX;

        private System.Windows.Forms.Button buttonSquare;

        private System.Windows.Forms.Button buttonSqrt;

        private System.Windows.Forms.Button buttonPlusMinus;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

        #endregion

        Calc C;

        int k;

        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (label1.Text.IndexOf("∞") != -1)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (label1.Text[0] == '0' && (label1.Text.IndexOf(",") != 1))
                label1.Text = label1.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (label1.Text[0] == '-')
                if (label1.Text[1] == '0' && (label1.Text.IndexOf(",") != 2))
                    label1.Text = label1.Text.Remove(1, 1);
        }

        private bool CanPress()
        {
            if (!Multiply.Enabled)
                return false;

            if (!Divide.Enabled)
                return false;

            if (!buttonMPlus.Enabled)
                return false;

            if (!buttonMMinus.Enabled)
                return false;

            if (!buttonSqrtX.Enabled)
                return false;

            if (!buttonDegreeY.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            Multiply.Enabled = true;
            Divide.Enabled = true;
            buttonMPlus.Enabled = true;
            buttonMMinus.Enabled = true;
            buttonSqrtX.Enabled = true;
            buttonDegreeY.Enabled = true;
        }




    }
}

