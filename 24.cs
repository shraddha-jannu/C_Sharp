using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MathQuiz
{
public partial class Form1 : Form
{
Random randomizer = new Random();
int addend1;
int addend2;
int minuend;
int subtrahend;
// These integer variables store the numbers
// for the multiplication problem.
int multiplicand;
int multiplier;
// These integer variables store the numbers
// for the division problem.
int dividend;
int divisor;
int timeLeft;
public void StartTheQuiz()
{
// Fill in the addition problem.
// Generate two random numbers to add.
// Store the values in the variables &#39;addend1&#39; and &#39;addend2&#39;.
addend1 = randomizer.Next(51);
addend2 = randomizer.Next(51);

// Convert the two randomly generated numbers
// into strings so that they can be displayed
// in the label controls.
plusLeftLabel.Text = addend1.ToString();
plusRightLabel.Text = addend2.ToString();
// &#39;sum&#39; is the name of the NumericUpDown control.
// This step makes sure its value is zero before
// adding any values to it.
sum.Value = 0;
// Fill in the addition problem.
// Generate two random numbers to add.
// Store the values in the variables &#39;addend1&#39; and &#39;addend2&#39;.
addend1 = randomizer.Next(51);
addend2 = randomizer.Next(51);
// Convert the two randomly generated numbers
// into strings so that they can be displayed
// in the label controls.
plusLeftLabel.Text = addend1.ToString();
plusRightLabel.Text = addend2.ToString();
// &#39;sum&#39; is the name of the NumericUpDown control.
// This step makes sure its value is zero before
// adding any values to it.
sum.Value = 0;
// Fill in the subtraction problem.
minuend = randomizer.Next(1, 101);
subtrahend = randomizer.Next(1, minuend);
minusLeftLabel.Text = minuend.ToString();
minusRightLabel.Text = subtrahend.ToString();
difference.Value = 0;
// Fill in the multiplication problem.
multiplicand = randomizer.Next(2, 11);
multiplier = randomizer.Next(2, 11);
timesLeftLabel.Text = multiplicand.ToString();
timesRightLabel.Text = multiplier.ToString();
product.Value = 0;
// Fill in the division problem.
divisor = randomizer.Next(2, 11);
int temporaryQuotient = randomizer.Next(2, 11);
dividend = divisor * temporaryQuotient;
dividedLeftLabel.Text = dividend.ToString();
dividedRightLabel.Text = divisor.ToString();
quotient.Value = 0;
// Start the timer.
timeLeft = 30;

timeLabel.Text = &quot;30 seconds&quot;;
timer1.Start();
}
private bool CheckTheAnswer()
{
if ((addend1 + addend2 == sum.Value)
&amp;&amp; (minuend - subtrahend == difference.Value)
&amp;&amp; (multiplicand * multiplier == product.Value)
&amp;&amp; (dividend / divisor == quotient.Value))
return true;
else
return false;
}
public Form1()
{
InitializeComponent();
}
private void label1_Click(object sender, EventArgs e)
{
}
private void startButton_Click(object sender, EventArgs e)
{
StartTheQuiz();
startButton.Enabled = false;
}
private void timer1_Tick(object sender, EventArgs e)
{
if (CheckTheAnswer())
{
// If CheckTheAnswer() returns true, then the user
// got the answer right. Stop the timer
// and show a MessageBox.
timer1.Stop();
MessageBox.Show(&quot;You got all the answers right!&quot;,
&quot;Congratulations!&quot;);
startButton.Enabled = true;
}
else if (timeLeft &gt; 0)
{
// If CheckTheAnswer() returns false, keep counting
// down. Decrease the time left by one second and
// display the new time left by updating the
// Time Left label.
timeLeft = timeLeft - 1;
timeLabel.Text = timeLeft + &quot; seconds&quot;;
}

else
{
// If the user ran out of time, stop the timer, show
// a MessageBox, and fill in the answers.
timer1.Stop();
timeLabel.Text = &quot;Time&#39;s up!&quot;;
MessageBox.Show(&quot;You didn&#39;t finish in time.&quot;, &quot;Sorry!&quot;);
sum.Value = addend1 + addend2;
difference.Value = minuend - subtrahend;
product.Value = multiplicand * multiplier;
quotient.Value = dividend / divisor;
startButton.Enabled = true;
}
timeLabel.BackColor = Color.Red;
}
private void answer_Enter(object sender, EventArgs e)
{
// Select the whole answer in the NumericUpDown control.
NumericUpDown answerBox = sender as NumericUpDown;
if (answerBox != null)
{
int lengthOfAnswer = answerBox.Value.ToString().Length;
answerBox.Select(0, lengthOfAnswer);
}
}
}
}