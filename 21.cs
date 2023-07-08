namespace WinFormsApp1;
public partial class Form1 : Form
{
private TextBox number1TextBox;
private TextBox number2TextBox;
private Button addButton;
private Button subButton;
private Button mulButton;
private Button divButton;
private Button modButton;
private Label result;
public Form1()
{
InitializeComponents();
}
private void InitializeComponents()
{
number1TextBox = new TextBox();
number1TextBox.Location = new System.Drawing.Point(100, 30);
this.Controls.Add(number1TextBox);
number2TextBox = new TextBox();
number2TextBox.Location = new System.Drawing.Point(100, 60);
this.Controls.Add(number2TextBox);
addButton = new Button();
addButton.Text = &quot;Add&quot;;
addButton.Location = new System.Drawing.Point(10, 110);
addButton.Height = 40;
addButton.Click += add;

this.Controls.Add(addButton);
subButton = new Button();
subButton.Text = &quot;Sub&quot;;
subButton.Location = new System.Drawing.Point(100, 110);
subButton.Height = 40;
subButton.Click += sub;
this.Controls.Add(subButton);
mulButton = new Button();
mulButton.Text = &quot;Mul&quot;;
mulButton.Location = new System.Drawing.Point(200, 110);
mulButton.Click += mul;
mulButton.Height = 40;
this.Controls.Add(mulButton);
divButton = new Button();
divButton.Text = &quot;Div&quot;;
divButton.Location = new System.Drawing.Point(300, 110);
divButton.Click += div;
divButton.Height = 40;
this.Controls.Add(divButton);
modButton = new Button();
modButton.Text = &quot;Mod&quot;;
modButton.Location = new System.Drawing.Point(400, 110);
modButton.Height = 40;
modButton.Click += mod;
this.Controls.Add(modButton);
result = new Label();
result.Location = new System.Drawing.Point(50, 200);
this.Controls.Add(result);
result.Height = 40;
result.Width = 200;
}

private void add(object sender, EventArgs e)
{
int num1 = int.Parse(number1TextBox.Text);
int num2 = int.Parse(number2TextBox.Text);

int res = num1 + num2;
result.Text = &quot;Addition :&quot;+res.ToString();
}
private void sub(object sender, EventArgs e)
{
int num1 = int.Parse(number1TextBox.Text);
int num2 = int.Parse(number2TextBox.Text);
int res = num1 - num2;
result.Text = &quot;Substraction :&quot;+res.ToString();
}
private void mul(object sender, EventArgs e)
{
int num1 = int.Parse(number1TextBox.Text);
int num2 = int.Parse(number2TextBox.Text);
int res = num1 * num2;
result.Text = &quot;Multiplication :&quot;+res.ToString();
}
private void div(object sender, EventArgs e)
{
int num1 = int.Parse(number1TextBox.Text);
int num2 = int.Parse(number2TextBox.Text);
int res = num1 / num2;
result.Text = &quot;Division :&quot;+res.ToString();
}
private void mod(object sender, EventArgs e)
{
int num1 = int.Parse(number1TextBox.Text);
int num2 = int.Parse(number2TextBox.Text);
int res = num1 % num2;
result.Text = &quot;Modulus :&quot;+res.ToString();
}
}