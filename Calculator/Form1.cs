using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Calculator : Form
	{
		Color selectcolor = Color.Yellow;
		Color selectopcolor = SystemColors.ActiveBorder;
		double total = 0;
		bool newreset = false;
		enum Buttons { Add, Subtract, Multiply, Divide, Backspace, Decimal, Equals, Negative, None, MC, MR, MP, MM, MS}
		Buttons lastop = Buttons.None;

		double mem = 0;

		public Calculator()
		{
			InitializeComponent();
		}
 

		private void Form1_Load(object sender, EventArgs e)
		{
			calcdisplay.Text = "0";
		}


		private void PressButton(int num)
		{
			if (calcdisplay.Text.Length >= 16) { return; }

			else if (calcdisplay.Text.Equals("0") || newreset == true)
			{
				calcdisplay.Text = num.ToString();
				newreset = false;
			}
			else
			{
				calcdisplay.Text = calcdisplay.Text + num.ToString();
			}
		}
		private void PressButton(Buttons button)
		{
			if (button == Buttons.Decimal && calcdisplay.Text.IndexOf(".") == -1)
			{
				calcdisplay.Text = calcdisplay.Text + ".";
			}

			else if (button == Buttons.Equals)
			{
				if (lastop != Buttons.None)
				{
					PressButton(lastop);
					ResetCalc(true, calcdisplay.Text);
				}
			}

			else if (button == Buttons.Add)
			{
				if (lastop != Buttons.Add)
				{
					if (lastop == Buttons.Subtract) { PressButton(Buttons.Subtract); }
					if (lastop == Buttons.Multiply) { PressButton(Buttons.Multiply); }
					if (lastop == Buttons.Divide) { PressButton(Buttons.Divide); }
					lastop = Buttons.Add;
					if (total == 0)
					{
						total = double.Parse(calcdisplay.Text);
						ResetCalc(false, calcdisplay.Text);
					}
				}
				else if (newreset) { return; }
				else if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);
					ResetCalc(false, calcdisplay.Text);
				}
				else
				{
					total = total + double.Parse(calcdisplay.Text);
					ResetCalc(false, total.ToString());
				}
				ResetColors();
				if (lastop == Buttons.Add) { buttonadd.BackColor = selectopcolor; }
			}

			else if (button == Buttons.Subtract)
			{
				if (lastop != Buttons.Subtract)
				{
					if (lastop == Buttons.Add) { PressButton(Buttons.Add); }
					if (lastop == Buttons.Multiply) { PressButton(Buttons.Multiply); }
					if (lastop == Buttons.Divide) { PressButton(Buttons.Divide); }
					lastop = Buttons.Subtract;
					if (total == 0)
					{
						total = double.Parse(calcdisplay.Text);
						ResetCalc(false, calcdisplay.Text);
					}
				}
				else if (newreset) { return; }
				else if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);
					ResetCalc(false, calcdisplay.Text);
				}
				else
				{
					total = total - double.Parse(calcdisplay.Text);
					ResetCalc(false, total.ToString());
				}
				ResetColors();
				if (lastop == Buttons.Subtract) { buttonsubtract.BackColor = selectopcolor; }
			}

			else if (button == Buttons.Multiply)
			{
				if (lastop != Buttons.Multiply)
				{
					if (lastop == Buttons.Subtract) { PressButton(Buttons.Subtract); }
					if (lastop == Buttons.Add) { PressButton(Buttons.Add); }
					if (lastop == Buttons.Divide) { PressButton(Buttons.Divide); }
					lastop = Buttons.Multiply;
					if (total == 0)
					{
						total = double.Parse(calcdisplay.Text);
						ResetCalc(false, calcdisplay.Text);
					}
					buttonmultiply.BackColor = selectopcolor;
				}
				else if (newreset) { return; }
				else if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);
					ResetCalc(false, calcdisplay.Text);
				}
				else
				{
					total = total * double.Parse(calcdisplay.Text);
					ResetCalc(false, total.ToString());
				}
			}

			else if (button == Buttons.Divide)
			{
				if (lastop != Buttons.Divide)
				{
					if (lastop == Buttons.Subtract) { PressButton(Buttons.Subtract); }
					if (lastop == Buttons.Multiply) { PressButton(Buttons.Multiply); }
					if (lastop == Buttons.Add) { PressButton(Buttons.Add); }
					lastop = Buttons.Divide;
					if (total == 0)
					{
						total = double.Parse(calcdisplay.Text);
						ResetCalc(false, calcdisplay.Text);
					}
					buttondivide.BackColor = selectopcolor;
				}
				else if (newreset) { return; }
				else if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);
					ResetCalc(false, calcdisplay.Text);
				}
				else
				{
					total = total / double.Parse(calcdisplay.Text);
					ResetCalc(false, total.ToString());
				}
			}

			//Old try at the operators

			/*else if (button == Buttons.Add)
			{
				lastop = Buttons.Add;
				if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);			// If no previous numbers, just set to 0
					ResetCalc(false, calcdisplay.Text);
				} 
				else
				{
					total = total + double.Parse(calcdisplay.Text);	// otherwise, add the 2 together
					ResetCalc(false, total.ToString());
				}
				buttonadd.BackColor = SystemColors.ActiveBorder;
			}

			else if (button == Buttons.Subtract)
			{
				lastop = Buttons.Subtract;
				if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);         // If no previous numbers, just set to 0
					ResetCalc(false, calcdisplay.Text);
				}
				else
				{
					total = total - double.Parse(calcdisplay.Text); // otherwise, add the 2 together
					ResetCalc(false, total.ToString());
				}
				buttonsubtract.BackColor = SystemColors.ActiveBorder;
			}

			else if (button == Buttons.Multiply)
			{
				lastop = Buttons.Multiply;
				if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);         // If no previous numbers, just set to 0
					ResetCalc(false, calcdisplay.Text);
				}
				else
				{
					total = total * double.Parse(calcdisplay.Text); // otherwise, add the 2 together
					ResetCalc(false, total.ToString());
				}
				buttonmultiply.BackColor = SystemColors.ActiveBorder;
			}

			else if (button == Buttons.Divide)
			{
				lastop = Buttons.Divide;
				if (total == 0)
				{
					total = double.Parse(calcdisplay.Text);         // If no previous numbers, just set to 0
					ResetCalc(false, calcdisplay.Text);
				}
				else
				{
					total = total / double.Parse(calcdisplay.Text); // otherwise, add the 2 together
					ResetCalc(false, total.ToString());
				}
				buttondivide.BackColor = SystemColors.ActiveBorder;
			}
			*/

			else if (button == Buttons.Backspace)
			{
				if (calcdisplay.Text.Length <= 1) { calcdisplay.Text = "0"; return; }
				String lastchar = calcdisplay.Text.Last().ToString();
				calcdisplay.Text = calcdisplay.Text.Remove(calcdisplay.Text.Length - 1);
			}

			else if (button == Buttons.Negative)
			{
				if(calcdisplay.Text == "0") { return; }
				else if(calcdisplay.Text.IndexOf("-") == -1) { calcdisplay.Text = "-" + calcdisplay.Text; }
				else { calcdisplay.Text = calcdisplay.Text.Substring(1); }
			}

			else if (button == Buttons.MS)
			{
				mem = double.Parse(calcdisplay.Text);
				newreset = true;
			}
			else if (button == Buttons.MC)
			{
				mem = 0;
				newreset = true;
			}
			else if (button == Buttons.MP)
			{
				mem = mem + double.Parse(calcdisplay.Text);
				newreset = true;
			}
			else if (button == Buttons.MM)
			{
				mem = mem - double.Parse(calcdisplay.Text);
				newreset = true;
			}
			else if (button == Buttons.MR)
			{
				calcdisplay.Text = mem.ToString();
				newreset = true;
			}
			ResetNumColors();
		}

		private void ResetCalc(bool resettotal = false, String newdisplay = "0")// Reset calculator to default state
		{
			calcdisplay.Text = newdisplay;
			newreset = true;

			ResetColors();
			if (resettotal) { total = 0; lastop = Buttons.None; }
		}

		private void ResetColors()
		{
			buttonadd.BackColor = SystemColors.Control;
			buttonsubtract.BackColor = SystemColors.Control;
			buttonmultiply.BackColor = SystemColors.Control;
			buttondivide.BackColor = SystemColors.Control;
		}
		private void ResetNumColors()
		{
			button0.BackColor = SystemColors.Control;
			button1.BackColor = SystemColors.Control;
			button2.BackColor = SystemColors.Control;
			button3.BackColor = SystemColors.Control;
			button4.BackColor = SystemColors.Control;
			button5.BackColor = SystemColors.Control;
			button6.BackColor = SystemColors.Control;
			button7.BackColor = SystemColors.Control;
			button8.BackColor = SystemColors.Control;
			button9.BackColor = SystemColors.Control;
		}

//Mouse Downs
		private void buttonC_MouseDown(object sender, EventArgs e) { buttonC.BackColor = selectcolor; }
		private void buttonCE_MouseDown(object sender, EventArgs e) { buttonCE.BackColor = selectcolor; }
		private void button1_MouseDown(object sender, EventArgs e) { button1.BackColor = selectcolor; }
		private void button2_MouseDown(object sender, EventArgs e) { button2.BackColor = selectcolor; }
		private void button3_MouseDown(object sender, EventArgs e) { button3.BackColor = selectcolor; }
		private void button4_MouseDown(object sender, EventArgs e) { button4.BackColor = selectcolor; }
		private void button5_MouseDown(object sender, EventArgs e) { button5.BackColor = selectcolor; }
		private void button6_MouseDown(object sender, EventArgs e) { button6.BackColor = selectcolor; }
		private void button7_MouseDown(object sender, EventArgs e) { button7.BackColor = selectcolor; }
		private void button8_MouseDown(object sender, EventArgs e) { button8.BackColor = selectcolor; }
		private void button9_MouseDown(object sender, EventArgs e) { button9.BackColor = selectcolor; }
		private void button0_MouseDown(object sender, EventArgs e) { button0.BackColor = selectcolor; }
		private void buttondecimal_MouseDown(object sender, EventArgs e) { buttondecimal.BackColor = selectcolor; }
		private void buttonbackspace_MouseDown(object sender, EventArgs e) { buttonbackspace.BackColor = selectcolor; }
		private void buttonadd_MouseDown(object sender, EventArgs e) { buttonadd.BackColor = selectcolor; }
		private void buttonequals_MouseDown(object sender, EventArgs e) { buttonequals.BackColor = selectcolor; }
		private void buttonsubtract_MouseDown(object sender, EventArgs e) { buttonsubtract.BackColor = selectcolor; }
		private void buttonmultiply_MouseDown(object sender, EventArgs e) { buttonmultiply.BackColor = selectcolor; }
		private void buttondivide_MouseDown(object sender, EventArgs e) { buttondivide.BackColor = selectcolor; }
		private void buttonnegative_MouseDown(object sender, EventArgs e) { buttonnegative.BackColor = selectcolor; }
		private void buttonMC_MouseDown(object sender, EventArgs e) { buttonMC.BackColor = selectcolor; }
		private void buttonMR_MouseDown(object sender, EventArgs e) { buttonMR.BackColor = selectcolor; }
		private void buttonMP_MouseDown(object sender, EventArgs e) { buttonMP.BackColor = selectcolor; }
		private void buttonMM_MouseDown(object sender, EventArgs e) { buttonMM.BackColor = selectcolor; }
		private void buttonMS_MouseDown(object sender, EventArgs e) { buttonMS.BackColor = selectcolor; }

//Mouse Ups

		private void buttonC_MouseUp(object sender, EventArgs e) { ResetCalc(true); buttonC.BackColor = SystemColors.Control; }
		private void buttonCE_MouseUp(object sender, EventArgs e) { ResetCalc(); buttonCE.BackColor = SystemColors.Control; }
		private void button1_MouseUp(object sender, EventArgs e) { PressButton(1); button1.BackColor = SystemColors.Control; }
		private void button2_MouseUp(object sender, EventArgs e) { PressButton(2); button2.BackColor = SystemColors.Control; }
		private void button3_MouseUp(object sender, EventArgs e) { PressButton(3); button3.BackColor = SystemColors.Control; }
		private void button4_MouseUp(object sender, EventArgs e) { PressButton(4); button4.BackColor = SystemColors.Control; }
		private void button5_MouseUp(object sender, EventArgs e) { PressButton(5); button5.BackColor = SystemColors.Control; }
		private void button6_MouseUp(object sender, EventArgs e) { PressButton(6); button6.BackColor = SystemColors.Control; }
		private void button7_MouseUp(object sender, EventArgs e) { PressButton(7); button7.BackColor = SystemColors.Control; }
		private void button8_MouseUp(object sender, EventArgs e) { PressButton(8); button8.BackColor = SystemColors.Control; }
		private void button9_MouseUp(object sender, EventArgs e) { PressButton(9); button9.BackColor = SystemColors.Control; }
		private void button0_MouseUp(object sender, EventArgs e) { PressButton(0); button0.BackColor = SystemColors.Control; }
		private void buttondecimal_MouseUp(object sender, EventArgs e) { PressButton(Buttons.Decimal); buttondecimal.BackColor = SystemColors.Control; }
		private void buttonbackspace_MouseUp(object sender, EventArgs e) { PressButton(Buttons.Backspace); buttonbackspace.BackColor = SystemColors.Control; }
		private void buttonadd_MouseUp(object sender, EventArgs e) { PressButton(Buttons.Add); }
		private void buttonequals_MouseUp(object sender, EventArgs e)	{ PressButton(Buttons.Equals); buttonequals.BackColor = SystemColors.Control; }
		private void buttonsubtract_MouseUp(object sender, EventArgs e) { PressButton(Buttons.Subtract); }
		private void buttonmultiply_MouseUp(object sender, EventArgs e) { PressButton(Buttons.Multiply); }
		private void buttondivide_MouseUp(object sender, EventArgs e) { PressButton(Buttons.Divide); }
		private void buttonnegative_MouseUp(object sender, EventArgs e) { PressButton(Buttons.Negative); buttonnegative.BackColor = SystemColors.Control; }
		private void buttonMC_MouseUp(object sender, EventArgs e) { PressButton(Buttons.MC); buttonMC.BackColor = SystemColors.Control; }
		private void buttonMR_MouseUp(object sender, EventArgs e) { PressButton(Buttons.MR); buttonMR.BackColor = SystemColors.Control; }
		private void buttonMP_MouseUp(object sender, EventArgs e) { PressButton(Buttons.MP); buttonMP.BackColor = SystemColors.Control; }
		private void buttonMM_MouseUp(object sender, EventArgs e) { PressButton(Buttons.MM); buttonMM.BackColor = SystemColors.Control; }
		private void buttonMS_MouseUp(object sender, EventArgs e) { PressButton(Buttons.MS); buttonMS.BackColor = SystemColors.Control; }


		private void calcdisplay_Enter(object sender, EventArgs e) { ActiveControl = null; } // Makes cursor not show up when you click text box.
		

		private void Calculator_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0){ button0_MouseUp(sender,e); button0.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) { button1_MouseUp(sender, e); button1.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) { button2_MouseUp(sender, e); button2.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) { button3_MouseUp(sender, e); button3.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) { button4_MouseUp(sender, e); button4.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) { button5_MouseUp(sender, e); button5.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) { button6_MouseUp(sender, e); button6.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) { button7_MouseUp(sender, e); button7.BackColor = selectcolor; }
			if ((e.KeyCode == Keys.D8 && e.Modifiers != Keys.Shift) || e.KeyCode == Keys.NumPad8) { button8_MouseUp(sender, e); button8.BackColor = selectcolor; }
			if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) { button9_MouseUp(sender, e); button9.BackColor = selectcolor; }
			if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod) { buttondecimal_MouseUp(sender, e); buttondecimal.BackColor = selectcolor; }
			if (e.KeyCode == Keys.Back) { buttonbackspace_MouseUp(sender, e); buttonbackspace.BackColor = selectcolor; }
			if ((e.KeyCode == Keys.Oemplus && e.Modifiers == Keys.Shift) || e.KeyCode == Keys.Add) { buttonadd_MouseUp(sender, e); buttonadd.BackColor = selectcolor; }
			if ((e.KeyCode == Keys.Oemplus && e.Modifiers != Keys.Shift) || e.KeyCode == Keys.Enter) { buttonequals_MouseUp(sender, e); buttonequals.BackColor = selectcolor; }
			if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) { buttonsubtract_MouseUp(sender, e); buttonsubtract.BackColor = selectcolor; }
			if (e.KeyCode == Keys.Multiply || (e.KeyCode == Keys.D8 && e.Modifiers == Keys.Shift)) { buttonmultiply_MouseUp(sender, e); buttonmultiply.BackColor = selectcolor; }
			if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion) { buttondivide_MouseUp(sender, e); buttondivide.BackColor = selectcolor; }
			if (e.KeyCode == Keys.Escape) { buttonC_MouseUp(sender, e); buttonC.BackColor = selectcolor; }
			if (e.KeyCode == Keys.Delete) { buttonCE_MouseUp(sender, e); buttonCE.BackColor = selectcolor; }
		}

		private void Calculator_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0) { button0.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) { button1.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) { button2.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) { button3.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) { button4.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) { button5.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) { button6.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7) { button7.BackColor = SystemColors.Control; }
			if ((e.KeyCode == Keys.D8 && e.Modifiers != Keys.Shift) || e.KeyCode == Keys.NumPad8) { button8.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9) { button9.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod) { buttondecimal.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Back) { buttonbackspace.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add) { buttonadd.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Enter) { buttonequals.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract) { buttonsubtract.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Multiply || e.KeyCode == Keys.D8) { buttonmultiply.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion) { buttondivide.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Escape) { buttonC.BackColor = SystemColors.Control; }
			if (e.KeyCode == Keys.Delete) { buttonCE.BackColor = SystemColors.Control; }
		}
	}
}
