namespace PlandoCalculator
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        double lastOperand = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void addDigitsClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((textResult.Text == "0") || isOperationPerformed)
            {
                textResult.Clear();
                isOperationPerformed = false;
            }

            if (button.Text == ".")
            {
                if (textResult.Text == "")
                    textResult.Text = "0.";

                else if (!textResult.Text.Contains("."))
                    textResult.Text += ".";
            }
            else
            {
                textResult.Text += button.Text;
            }
        }
        private void operationsClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!isOperationPerformed && operationPerformed != "")
            {
                equalClicked(this, EventArgs.Empty);
            }

            operationPerformed = button.Text;
            if (textResult.Text != "" && textResult.Text != ".")
                resultValue = double.Parse(textResult.Text);

            labelOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        private void clearClicked(object sender, EventArgs e)
        {
            textResult.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            labelOperation.Text = "";
        }


        private void clearEntryClicked(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void equalClicked(object sender, EventArgs e)
        {
            double currentValue = double.Parse(textResult.Text);

            if (!isOperationPerformed)
                lastOperand = currentValue;

            switch (operationPerformed)
            {
                case "+":
                    textResult.Text = (resultValue + lastOperand).ToString();
                    break;
                case "-":
                    textResult.Text = (resultValue - lastOperand).ToString();
                    break;
                case "*":
                    textResult.Text = (resultValue * lastOperand).ToString();
                    break;
                case "/":
                    textResult.Text = (resultValue / lastOperand).ToString();
                    break;
                default:
                    break;
            }

            resultValue = double.Parse(textResult.Text);
            labelOperation.Text = "";
            isOperationPerformed = true; 
        }


        private void deleteClicked(object sender, EventArgs e)
        {
            if (textResult.Text.Length > 0)
            {
                textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);

                if (textResult.Text == "")
                {
                    textResult.Text = "0";
                }
            }
        }

        private void negateClicked(object sender, EventArgs e)
        {
            if (textResult.Text != "0")
            {
                double currentValue = double.Parse(textResult.Text);
                currentValue = -currentValue;
                textResult.Text = currentValue.ToString();
            }
        }

        private void percentClicked(object sender, EventArgs e)
        {
            double currentValue = double.Parse(textResult.Text);

            if (resultValue != 0 && operationPerformed != "")
            {
                currentValue = (resultValue * currentValue) / 100;
            }
            else
            {
                currentValue = currentValue / 100;
            }

            textResult.Text = currentValue.ToString();
        }

        private void squaredClick(object sender, EventArgs e)
        {
            try
            {
                double currentValue = double.Parse(textResult.Text);
                labelOperation.Text = $"sqr({currentValue})";
                currentValue = currentValue * currentValue;
                textResult.Text = currentValue.ToString();
                resultValue = currentValue;
                isOperationPerformed = true;
            }
            catch
            {
                textResult.Text = "Error";
                labelOperation.Text = "";
            }
        }

        private void onedivideClicked(object sender, EventArgs e)
        {
            try
            {
                double currentValue = double.Parse(textResult.Text);
                if (currentValue == 0)
                {
                    textResult.Text = "Error";
                    labelOperation.Text = "";
                    return;
                }
                labelOperation.Text = $"1/({currentValue})";
                currentValue = 1 / currentValue;
                textResult.Text = currentValue.ToString();
                resultValue = currentValue;
                isOperationPerformed = true;
            }
            catch
            {
                textResult.Text = "Error";
                labelOperation.Text = "";
            }
        }

        private void squareRootClicked(object sender, EventArgs e)
        {
            try
            {
                double currentValue = double.Parse(textResult.Text);
                if (currentValue < 0)
                {
                    textResult.Text = "Error";
                    labelOperation.Text = "";
                    return;
                }
                labelOperation.Text = $"sqrt({currentValue})";
                currentValue = Math.Sqrt(currentValue);
                textResult.Text = currentValue.ToString();
                resultValue = currentValue;

                isOperationPerformed = true;
            }
            catch
            {
                textResult.Text = "Error";
                labelOperation.Text = "";
            }
        }
    }
}
