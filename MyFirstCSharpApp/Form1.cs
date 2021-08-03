using System;
using System.Windows.Forms;

namespace MyFirstCSharpApp
{
    public partial class Form1 : Form
    {
        public double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBoxNumber1.Text);
                num2 = double.Parse(textBoxNumber2.Text);
                labelAnswer.Text = $"{num1 + num2}";
            } catch { MessageBox.Show("Please enter numbers in both the text fields."); }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBoxNumber1.Text);
                num2 = double.Parse(textBoxNumber2.Text);
                labelAnswer.Text = $"{num1 - num2}";
            }
            catch { MessageBox.Show("Please enter numbers in both the text fields."); }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBoxNumber1.Text);
                num2 = double.Parse(textBoxNumber2.Text);
                labelAnswer.Text = $"{num1 * num2}";
        } catch { MessageBox.Show("Please enter numbers in both the text fields."); }
}

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBoxNumber1.Text);
                num2 = double.Parse(textBoxNumber2.Text);
                labelAnswer.Text = $"{num1 / num2}";
            } catch { MessageBox.Show("Please enter numbers in both the text fields."); }
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBoxNumber1.Text);
                num2 = double.Parse(textBoxNumber2.Text);
                labelAnswer.Text = $"{Math.Sqrt(num1)}";
            } catch { MessageBox.Show("Please enter numbers in both the text fields."); }
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBoxNumber1.Text);
                num2 = double.Parse(textBoxNumber2.Text);
                labelAnswer.Text = $"{Math.Pow(num1, num2)}";
            } catch { MessageBox.Show("Please enter numbers in both the text fields."); }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBoxNumber1.Text);
                num2 = double.Parse(textBoxNumber2.Text);
                labelAnswer.Text = $"{num1 % num2}";
            } catch { MessageBox.Show("Please enter numbers in both the text fields."); }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumber1.Text = "";
            textBoxNumber2.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
