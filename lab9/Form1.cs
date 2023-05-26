using System;
using System.Linq.Expressions;

namespace lab9
{
    public partial class Form1 : Form
    {
        private List<string> bracketPositions = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Historia", 200);
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
        }
        float num1, num2, newnumber, ans;
        int count;
        bool isResultComputed = false;
        bool isSecondNumberEntered = false;
        float previousResult = 0;
        bool isRadians = true;
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(16, 0);
        }

        private void UpdateBracketPositionsListView()
        {
            listView1.Items.Clear();

            foreach (string position in bracketPositions)
            {
                ListViewItem newItem = new ListViewItem(position);
                listView1.Items.Add(newItem);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            isSecondNumberEntered = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            isSecondNumberEntered = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            isSecondNumberEntered = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            isSecondNumberEntered = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            isSecondNumberEntered = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            isSecondNumberEntered = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            isSecondNumberEntered = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            isSecondNumberEntered = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            isSecondNumberEntered = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            isSecondNumberEntered = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0,";
                textBox1.SelectionStart = textBox1.Text.Length;
            }
            else if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (isResultComputed && isSecondNumberEntered || !isResultComputed && isSecondNumberEntered)
            {
                num2 = float.Parse(textBox1.Text);
                compute(count, num2);
            }
            else if (isResultComputed && !isSecondNumberEntered)
            {
                num1 = ans;
                num2 = newnumber;
                compute(count, num2);
            }
        }

        public void compute(int count, float num2)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - num2;
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + num2;
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * num2;
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        ans = num1 / num2;
                        textBox1.Text = "Dividing by Zero is undefined";    
                    }
                    else
                    {
                        ans = num1 / num2;
                        textBox1.Text = ans.ToString();   
                    }
                    break;
                case 5:
                    ans = num1 % num2;
                    textBox1.Text = ans.ToString();
                    break;
                case 6:
                    ans = Convert.ToSingle(Math.Pow(Convert.ToDouble(num1), num2));
                    textBox1.Text = ans.ToString();
                    break;
                case 7:
                    ans = Convert.ToSingle(num1 * Math.Pow(10, num2));
                    textBox1.Text = ans.ToString();
                    break;
                case 8:
                    ans = Convert.ToSingle(Math.Sqrt(Convert.ToDouble(num1)));
                    textBox1.Text = ans.ToString();
                    break;
                case 9:
                    ans = Convert.ToSingle(Math.Log10(Convert.ToDouble(num1)));
                    textBox1.Text = ans.ToString();
                    break;
                case 10:
                    ans = Convert.ToSingle(Math.Log(Convert.ToDouble(num1)));
                    textBox1.Text = ans.ToString();
                    break;
                case 11:
                    if (isRadians)
                        ans = Convert.ToSingle(Math.Sin(Convert.ToDouble(num1)));
                    else
                        ans = Convert.ToSingle(Math.Sin(Math.PI * Convert.ToDouble(num1) / 180.0));
                    textBox1.Text = ans.ToString();
                    break;
                case 12:
                    if (isRadians)
                        ans = Convert.ToSingle(Math.Cos(Convert.ToDouble(num1)));
                    else
                        ans = Convert.ToSingle(Math.Cos(Math.PI * Convert.ToDouble(num1) / 180.0));
                    textBox1.Text = ans.ToString();
                    break;
                case 13:
                    if (isRadians)
                        ans = Convert.ToSingle(Math.Tan(Convert.ToDouble(num1)));
                    else
                        ans = Convert.ToSingle(Math.Tan(Math.PI * Convert.ToDouble(num1) / 180.0));
                    textBox1.Text = ans.ToString();
                    break;
                case 14:
                    ans = 1;
                    for (int i = 1; i <= num1; i++)
                    {
                        ans *= i;
                    }
                    textBox1.Text = ans.ToString();
                    break;
                case 15:
                    ans = 1 / num1;
                    textBox1.Text = ans.ToString();
                    break;
                case 16:
                    ans = Convert.ToSingle(Math.Ceiling(Convert.ToDouble(num1)));
                    textBox1.Text = ans.ToString();
                    break;
                case 17:
                    ans = Convert.ToSingle(Math.Floor(Convert.ToDouble(num1)));
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
            if (count < 8)
            {
                string expression = $"{num1} {GetOperatorSymbol(count)} {num2} = {ans}";
                ListViewItem newItem = new ListViewItem(expression);
                listView1.Items.Add(newItem);
            }
            else
            {
                string expression = $"{GetOperatorSymbol(count)} {num1} = {ans}";
                ListViewItem newItem = new ListViewItem(expression);
                listView1.Items.Add(newItem);
            }

            newnumber = num2;
            previousResult = ans;
            isResultComputed = true;
            isSecondNumberEntered = false;

        }
        private string GetOperatorSymbol(int count)
        {
            switch (count)
            {
                case 1:
                    return "-";
                case 2:
                    return "+";
                case 3:
                    return "×";
                case 4:
                    return "÷";
                case 5:
                    return "%";
                case 6:
                    return "√";
                case 7:
                    return "Exp";
                case 8:
                    return "^";
                case 9:
                    return "log";
                case 10:
                    return "ln";
                case 11:
                    return "sin";
                case 12:
                    return "cos";
                case 13:
                    return "tan";
                case 14:
                    return "!";
                case 15:
                    return "1/";
                case 16:
                    return "Ceil";
                case 17:
                    return "Floor";
                default:
                    return "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
            isSecondNumberEntered = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(17, 0);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(8, 0);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 6;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(9, 0);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(10, 0);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(11, 0);
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(12, 0);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(13, 0);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Math.PI.ToString();
            isSecondNumberEntered = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 7;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Math.E.ToString();
            isSecondNumberEntered = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(14, 0);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + previousResult.ToString();
            isSecondNumberEntered = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            compute(15, 0);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            isRadians = !isRadians;

            button21.Text = isRadians ? "Rad" : "Deg";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button21.Visible = true;
                button22.Visible = true;
                button23.Visible = true;
                button24.Visible = true;
                button25.Visible = true;
                button26.Visible = true;
                button_cos.Visible = true;
                button28.Visible = true;
                button29.Visible = true;
                button30.Visible = true;
                button31.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
                button34.Visible = true;
                textBox1.Size = new Size(596, 12);
                textBox1.Location = new Point(40, 112);
            }
        }
    }
}