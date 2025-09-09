namespace PlandoCalculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            button_negate = new Button();
            label1 = new Label();
            button_zero = new Button();
            button_dot = new Button();
            button_equal = new Button();
            button_plus = new Button();
            button_three = new Button();
            button_two = new Button();
            button_one = new Button();
            button_multiply = new Button();
            buttone_nine = new Button();
            button_eight = new Button();
            button_seven = new Button();
            button_minus = new Button();
            button_six = new Button();
            button_five = new Button();
            button_four = new Button();
            button_divide = new Button();
            button_squareroot = new Button();
            button19 = new Button();
            button_onedivide = new Button();
            button_delete = new Button();
            button_clear = new Button();
            button_clearEntry = new Button();
            button_percent = new Button();
            textResult = new TextBox();
            labelOperation = new Label();
            SuspendLayout();
            // 
            // button_negate
            // 
            button_negate.Font = new Font("Segoe UI", 15F);
            button_negate.Location = new Point(2, 408);
            button_negate.Margin = new Padding(3, 3, 3, 2);
            button_negate.Name = "button_negate";
            button_negate.Size = new Size(75, 54);
            button_negate.TabIndex = 1;
            button_negate.Text = "+/-";
            button_negate.UseVisualStyleBackColor = true;
            button_negate.Click += negateClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 133);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 2;
            label1.Text = " ";
            // 
            // button_zero
            // 
            button_zero.Font = new Font("Segoe UI", 15F);
            button_zero.Location = new Point(78, 408);
            button_zero.Margin = new Padding(2, 3, 3, 3);
            button_zero.Name = "button_zero";
            button_zero.Size = new Size(75, 54);
            button_zero.TabIndex = 4;
            button_zero.Text = "0";
            button_zero.UseVisualStyleBackColor = true;
            button_zero.Click += addDigitsClicked;
            // 
            // button_dot
            // 
            button_dot.Font = new Font("Segoe UI", 15F);
            button_dot.Location = new Point(155, 408);
            button_dot.Name = "button_dot";
            button_dot.Size = new Size(75, 54);
            button_dot.TabIndex = 5;
            button_dot.Text = ".";
            button_dot.UseVisualStyleBackColor = true;
            button_dot.Click += addDigitsClicked;
            // 
            // button_equal
            // 
            button_equal.Font = new Font("Segoe UI", 15F);
            button_equal.Location = new Point(232, 408);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(75, 54);
            button_equal.TabIndex = 6;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = true;
            button_equal.Click += equalClicked;
            // 
            // button_plus
            // 
            button_plus.Font = new Font("Segoe UI", 15F);
            button_plus.Location = new Point(232, 350);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(75, 54);
            button_plus.TabIndex = 10;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = true;
            button_plus.Click += operationsClicked;
            // 
            // button_three
            // 
            button_three.Font = new Font("Segoe UI", 15F);
            button_three.Location = new Point(155, 350);
            button_three.Name = "button_three";
            button_three.Size = new Size(75, 54);
            button_three.TabIndex = 9;
            button_three.Text = "3";
            button_three.UseVisualStyleBackColor = true;
            button_three.Click += addDigitsClicked;
            // 
            // button_two
            // 
            button_two.Font = new Font("Segoe UI", 15F);
            button_two.Location = new Point(78, 350);
            button_two.Margin = new Padding(2, 3, 3, 3);
            button_two.Name = "button_two";
            button_two.Size = new Size(75, 54);
            button_two.TabIndex = 8;
            button_two.Text = "2";
            button_two.UseVisualStyleBackColor = true;
            button_two.Click += addDigitsClicked;
            // 
            // button_one
            // 
            button_one.Font = new Font("Segoe UI", 15F);
            button_one.Location = new Point(2, 350);
            button_one.Margin = new Padding(3, 3, 3, 2);
            button_one.Name = "button_one";
            button_one.Size = new Size(75, 54);
            button_one.TabIndex = 7;
            button_one.Text = "1";
            button_one.UseVisualStyleBackColor = true;
            button_one.Click += addDigitsClicked;
            // 
            // button_multiply
            // 
            button_multiply.Font = new Font("Segoe UI", 15F);
            button_multiply.Location = new Point(232, 234);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(75, 54);
            button_multiply.TabIndex = 18;
            button_multiply.Text = "*";
            button_multiply.UseVisualStyleBackColor = true;
            button_multiply.Click += operationsClicked;
            // 
            // buttone_nine
            // 
            buttone_nine.Font = new Font("Segoe UI", 15F);
            buttone_nine.Location = new Point(155, 234);
            buttone_nine.Name = "buttone_nine";
            buttone_nine.Size = new Size(75, 54);
            buttone_nine.TabIndex = 17;
            buttone_nine.Text = "9";
            buttone_nine.UseVisualStyleBackColor = true;
            buttone_nine.Click += addDigitsClicked;
            // 
            // button_eight
            // 
            button_eight.Font = new Font("Segoe UI", 15F);
            button_eight.Location = new Point(78, 234);
            button_eight.Margin = new Padding(2, 3, 3, 3);
            button_eight.Name = "button_eight";
            button_eight.Size = new Size(75, 54);
            button_eight.TabIndex = 16;
            button_eight.Text = "8";
            button_eight.UseVisualStyleBackColor = true;
            button_eight.Click += addDigitsClicked;
            // 
            // button_seven
            // 
            button_seven.Font = new Font("Segoe UI", 15F);
            button_seven.Location = new Point(2, 234);
            button_seven.Margin = new Padding(3, 3, 3, 2);
            button_seven.Name = "button_seven";
            button_seven.Size = new Size(75, 54);
            button_seven.TabIndex = 15;
            button_seven.Text = "7";
            button_seven.UseVisualStyleBackColor = true;
            button_seven.Click += addDigitsClicked;
            // 
            // button_minus
            // 
            button_minus.Font = new Font("Segoe UI", 15F);
            button_minus.Location = new Point(232, 292);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(75, 54);
            button_minus.TabIndex = 14;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = true;
            button_minus.Click += operationsClicked;
            // 
            // button_six
            // 
            button_six.Font = new Font("Segoe UI", 15F);
            button_six.Location = new Point(155, 292);
            button_six.Name = "button_six";
            button_six.Size = new Size(75, 54);
            button_six.TabIndex = 13;
            button_six.Text = "6";
            button_six.UseVisualStyleBackColor = true;
            button_six.Click += addDigitsClicked;
            // 
            // button_five
            // 
            button_five.Font = new Font("Segoe UI", 15F);
            button_five.Location = new Point(78, 292);
            button_five.Margin = new Padding(2, 3, 3, 3);
            button_five.Name = "button_five";
            button_five.Size = new Size(75, 54);
            button_five.TabIndex = 12;
            button_five.Text = "5";
            button_five.UseVisualStyleBackColor = true;
            button_five.Click += addDigitsClicked;
            // 
            // button_four
            // 
            button_four.Font = new Font("Segoe UI", 15F);
            button_four.Location = new Point(2, 292);
            button_four.Margin = new Padding(3, 3, 3, 2);
            button_four.Name = "button_four";
            button_four.Size = new Size(75, 54);
            button_four.TabIndex = 11;
            button_four.Text = "4";
            button_four.UseVisualStyleBackColor = true;
            button_four.Click += addDigitsClicked;
            // 
            // button_divide
            // 
            button_divide.Font = new Font("Segoe UI", 15F);
            button_divide.Location = new Point(232, 176);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(75, 54);
            button_divide.TabIndex = 22;
            button_divide.Text = "/";
            button_divide.UseVisualStyleBackColor = true;
            button_divide.Click += operationsClicked;
            // 
            // button_squareroot
            // 
            button_squareroot.Font = new Font("Segoe UI", 15F);
            button_squareroot.Location = new Point(155, 176);
            button_squareroot.Name = "button_squareroot";
            button_squareroot.Size = new Size(75, 54);
            button_squareroot.TabIndex = 21;
            button_squareroot.Text = "√";
            button_squareroot.UseVisualStyleBackColor = true;
            button_squareroot.Click += squareRootClicked;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 15F);
            button19.Location = new Point(78, 176);
            button19.Margin = new Padding(2, 3, 3, 3);
            button19.Name = "button19";
            button19.Size = new Size(75, 54);
            button19.TabIndex = 20;
            button19.Text = "x²";
            button19.UseVisualStyleBackColor = true;
            button19.Click += squaredClick;
            // 
            // button_onedivide
            // 
            button_onedivide.Font = new Font("Segoe UI", 15F);
            button_onedivide.Location = new Point(2, 176);
            button_onedivide.Margin = new Padding(3, 3, 3, 2);
            button_onedivide.Name = "button_onedivide";
            button_onedivide.Size = new Size(75, 54);
            button_onedivide.TabIndex = 19;
            button_onedivide.Text = "1/x";
            button_onedivide.UseVisualStyleBackColor = true;
            button_onedivide.Click += onedivideClicked;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 15F);
            button_delete.Location = new Point(233, 118);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 54);
            button_delete.TabIndex = 26;
            button_delete.Text = "DEL";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += deleteClicked;
            // 
            // button_clear
            // 
            button_clear.Font = new Font("Segoe UI", 15F);
            button_clear.Location = new Point(156, 118);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 54);
            button_clear.TabIndex = 25;
            button_clear.Text = "E";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += clearClicked;
            // 
            // button_clearEntry
            // 
            button_clearEntry.Font = new Font("Segoe UI", 15F);
            button_clearEntry.Location = new Point(79, 118);
            button_clearEntry.Margin = new Padding(2, 3, 3, 3);
            button_clearEntry.Name = "button_clearEntry";
            button_clearEntry.Size = new Size(75, 54);
            button_clearEntry.TabIndex = 24;
            button_clearEntry.Text = "CE";
            button_clearEntry.UseVisualStyleBackColor = true;
            button_clearEntry.Click += clearEntryClicked;
            // 
            // button_percent
            // 
            button_percent.Font = new Font("Segoe UI", 15F);
            button_percent.Location = new Point(3, 118);
            button_percent.Margin = new Padding(3, 3, 3, 2);
            button_percent.Name = "button_percent";
            button_percent.Size = new Size(75, 54);
            button_percent.TabIndex = 23;
            button_percent.Text = "%";
            button_percent.UseVisualStyleBackColor = true;
            button_percent.Click += percentClicked;
            // 
            // textResult
            // 
            textResult.Font = new Font("Segoe UI", 25F);
            textResult.Location = new Point(0, 49);
            textResult.Name = "textResult";
            textResult.Size = new Size(306, 52);
            textResult.TabIndex = 27;
            textResult.Text = "0";
            textResult.TextAlign = HorizontalAlignment.Right;
            // 
            // labelOperation
            // 
            labelOperation.AutoSize = true;
            labelOperation.Font = new Font("Segoe UI", 20F);
            labelOperation.ForeColor = SystemColors.ButtonShadow;
            labelOperation.Location = new Point(2, 9);
            labelOperation.Name = "labelOperation";
            labelOperation.Size = new Size(0, 37);
            labelOperation.TabIndex = 28;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 466);
            Controls.Add(labelOperation);
            Controls.Add(textResult);
            Controls.Add(button_delete);
            Controls.Add(button_clear);
            Controls.Add(button_clearEntry);
            Controls.Add(button_percent);
            Controls.Add(button_divide);
            Controls.Add(button_squareroot);
            Controls.Add(button19);
            Controls.Add(button_onedivide);
            Controls.Add(button_multiply);
            Controls.Add(buttone_nine);
            Controls.Add(button_eight);
            Controls.Add(button_seven);
            Controls.Add(button_minus);
            Controls.Add(button_six);
            Controls.Add(button_five);
            Controls.Add(button_four);
            Controls.Add(button_plus);
            Controls.Add(button_three);
            Controls.Add(button_two);
            Controls.Add(button_one);
            Controls.Add(button_equal);
            Controls.Add(button_dot);
            Controls.Add(button_zero);
            Controls.Add(label1);
            Controls.Add(button_negate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            Text = "PlandoCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_negate;
        private Label label1;
        private Button button_zero;
        private Button button_dot;
        private Button button_equal;
        private Button button_plus;
        private Button button_three;
        private Button button_two;
        private Button button_one;
        private Button button_multiply;
        private Button buttone_nine;
        private Button button_eight;
        private Button button_seven;
        private Button button_minus;
        private Button button_six;
        private Button button_five;
        private Button button_four;
        private Button button_divide;
        private Button button_squareroot;
        private Button button19;
        private Button button_onedivide;
        private Button button_delete;
        private Button button_clear;
        private Button button_clearEntry;
        private Button button_percent;
        private TextBox textResult;
        private Label labelOperation;
    }
}
