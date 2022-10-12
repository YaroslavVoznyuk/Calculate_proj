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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonSqrtX = new System.Windows.Forms.Button();
            this.buttonDegreeY = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.button_MDivide = new System.Windows.Forms.Button();
            this.buttonMMultiply = new System.Windows.Forms.Button();
            this.buttonMMinus = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMRC = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 59);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlusMinus.Location = new System.Drawing.Point(520, 106);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(50, 38);
            this.buttonPlusMinus.TabIndex = 1;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSqrt.Location = new System.Drawing.Point(520, 176);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(50, 38);
            this.buttonSqrt.TabIndex = 3;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSquare.Location = new System.Drawing.Point(520, 226);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(50, 38);
            this.buttonSquare.TabIndex = 4;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = false;
            // 
            // buttonSqrtX
            // 
            this.buttonSqrtX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSqrtX.Location = new System.Drawing.Point(520, 276);
            this.buttonSqrtX.Name = "buttonSqrtX";
            this.buttonSqrtX.Size = new System.Drawing.Size(50, 38);
            this.buttonSqrtX.TabIndex = 5;
            this.buttonSqrtX.Text = "x√";
            this.buttonSqrtX.UseVisualStyleBackColor = false;
            // 
            // buttonDegreeY
            // 
            this.buttonDegreeY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDegreeY.Location = new System.Drawing.Point(520, 326);
            this.buttonDegreeY.Name = "buttonDegreeY";
            this.buttonDegreeY.Size = new System.Drawing.Size(50, 38);
            this.buttonDegreeY.TabIndex = 6;
            this.buttonDegreeY.Text = "x^y";
            this.buttonDegreeY.UseVisualStyleBackColor = false;
            // 
            // buttonFactorial
            // 
            this.buttonFactorial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFactorial.Location = new System.Drawing.Point(520, 376);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(50, 38);
            this.buttonFactorial.TabIndex = 7;
            this.buttonFactorial.Text = "n!";
            this.buttonFactorial.UseVisualStyleBackColor = false;
            // 
            // button_MDivide
            // 
            this.button_MDivide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_MDivide.Location = new System.Drawing.Point(388, 106);
            this.button_MDivide.Name = "button_MDivide";
            this.button_MDivide.Size = new System.Drawing.Size(50, 38);
            this.button_MDivide.TabIndex = 8;
            this.button_MDivide.Text = "M÷";
            this.button_MDivide.UseVisualStyleBackColor = false;
            // 
            // buttonMMultiply
            // 
            this.buttonMMultiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMMultiply.Location = new System.Drawing.Point(308, 106);
            this.buttonMMultiply.Name = "buttonMMultiply";
            this.buttonMMultiply.Size = new System.Drawing.Size(50, 38);
            this.buttonMMultiply.TabIndex = 9;
            this.buttonMMultiply.Text = "M×";
            this.buttonMMultiply.UseVisualStyleBackColor = false;
            // 
            // buttonMMinus
            // 
            this.buttonMMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMMinus.Location = new System.Drawing.Point(238, 106);
            this.buttonMMinus.Name = "buttonMMinus";
            this.buttonMMinus.Size = new System.Drawing.Size(50, 38);
            this.buttonMMinus.TabIndex = 10;
            this.buttonMMinus.Text = "M-";
            this.buttonMMinus.UseVisualStyleBackColor = false;
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMPlus.Location = new System.Drawing.Point(168, 106);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(50, 38);
            this.buttonMPlus.TabIndex = 11;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = false;
            // 
            // buttonMRC
            // 
            this.buttonMRC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMRC.Location = new System.Drawing.Point(98, 106);
            this.buttonMRC.Name = "buttonMRC";
            this.buttonMRC.Size = new System.Drawing.Size(50, 38);
            this.buttonMRC.TabIndex = 12;
            this.buttonMRC.Text = "MRC";
            this.buttonMRC.UseVisualStyleBackColor = false;
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Multiply.Location = new System.Drawing.Point(388, 176);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(50, 38);
            this.Multiply.TabIndex = 13;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = false;
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Divide.Location = new System.Drawing.Point(388, 226);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 38);
            this.Divide.TabIndex = 14;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = false;
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sum.Location = new System.Drawing.Point(388, 276);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(50, 38);
            this.Sum.TabIndex = 15;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = false;
            // 
            // Substract
            // 
            this.Substract.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Substract.Location = new System.Drawing.Point(388, 326);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(50, 38);
            this.Substract.TabIndex = 16;
            this.Substract.Text = "-";
            this.Substract.UseVisualStyleBackColor = false;
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonZero.Location = new System.Drawing.Point(168, 326);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(50, 38);
            this.buttonZero.TabIndex = 17;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOne.Location = new System.Drawing.Point(168, 276);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(50, 38);
            this.buttonOne.TabIndex = 18;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTwo.Location = new System.Drawing.Point(238, 276);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(50, 38);
            this.buttonTwo.TabIndex = 19;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThree.Location = new System.Drawing.Point(308, 276);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(50, 38);
            this.buttonThree.TabIndex = 20;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPoint.Location = new System.Drawing.Point(238, 326);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(50, 38);
            this.buttonPoint.TabIndex = 21;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = false;
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCE.Location = new System.Drawing.Point(308, 326);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 38);
            this.buttonCE.TabIndex = 22;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFour.Location = new System.Drawing.Point(168, 226);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(50, 38);
            this.buttonFour.TabIndex = 23;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFive.Location = new System.Drawing.Point(238, 226);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(50, 38);
            this.buttonFive.TabIndex = 24;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSix.Location = new System.Drawing.Point(308, 226);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(50, 38);
            this.buttonSix.TabIndex = 25;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSeven.Location = new System.Drawing.Point(168, 176);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(50, 38);
            this.buttonSeven.TabIndex = 26;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEight.Location = new System.Drawing.Point(238, 176);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(50, 38);
            this.buttonEight.TabIndex = 27;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNine.Location = new System.Drawing.Point(308, 176);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(50, 38);
            this.buttonNine.TabIndex = 28;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonEqual.Location = new System.Drawing.Point(308, 376);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(130, 38);
            this.buttonEqual.TabIndex = 29;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 503);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.buttonMRC);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMMinus);
            this.Controls.Add(this.buttonMMultiply);
            this.Controls.Add(this.button_MDivide);
            this.Controls.Add(this.buttonFactorial);
            this.Controls.Add(this.buttonDegreeY);
            this.Controls.Add(this.buttonSqrtX);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.groupBox1.ResumeLayout(false);
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

        private System.Windows.Forms.Button buttonOne;

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
    }
}

