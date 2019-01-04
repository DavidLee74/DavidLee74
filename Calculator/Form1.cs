using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;





namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Display.Text = "0";
            
            
        }
        private void UpdateDisplay(int ButtonPushed)
        {
            double Buffer = 0;
            double Power = 0;
            //Buffer = (float)Convert.ToDouble(Display.Text);
            Buffer = Convert.ToDouble(Display.Text);
            if (Program.Decimals == -1)
                {
            Buffer = Buffer * 10 + ButtonPushed;
                }//end if
            if (Program.Decimals >= 0)
                {
                    Program.Decimals++; // We already are below zero. We pushed a button so we are 1 more decimal place over.
                    Power = Math.Pow(10, Program.Decimals);  
                    Buffer = Buffer + (ButtonPushed / Power);
                }//end if

            Display.Text = Convert.ToString(Buffer);

         }// end UpdateDisplay
        private void OperationPressed(int ButtonPushed)
        {
        // Use this function to handle operation key presses instead of local handlers. Not yet implemented. 
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = ButtonPushed; // Subtraction
            Program.Decimals = -1;
        }

        private void CalculateResult(int Operation)
        {
            if (Operation == 0)
            {
                Display.Text = "0";
            }//end if
            if (Operation == 1) // Addition
            {
                Program.Answer = Program.Value1 + Program.Value2;
            }//end if
            if (Operation == 2)// Subtraction
            {
                Program.Answer = Program.Value1 - Program.Value2;
            }//end if
            if (Operation == 3)// Multiplication
            {
                Program.Answer = Program.Value1 * Program.Value2;
            }// end if
            if (Operation == 4)// Division
            {
                Program.Answer = Program.Value1 / Program.Value2;
            }
            if (Operation == 5) // Sine
            {
                Program.Answer = Math.Sin(Program.Value1);
            }// endif
            if (Operation == 6) // Cos
            {
                Program.Answer = Math.Cos(Program.Value1);
            }// endif
            if (Operation == 7) // Tan
            {
                Program.Answer = Math.Tan(Program.Value1);
            }// endif
            if (Operation == 8) // Sqrt
            {
                Program.Answer = Math.Sqrt(Program.Value1);
            }// endif
            Display.Text = Convert.ToString(Program.Answer);

            Program.Value1 = 0;
            Program.Value2 = 0;
            Program.Operation = 0; // May not want to zero all these out. 
            Program.Answer = 0;
            Program.Decimals = -1;
        }


        private void Button0_Click(object sender, EventArgs e)
        {
            UpdateDisplay(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                       UpdateDisplay(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateDisplay(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdateDisplay(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UpdateDisplay(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UpdateDisplay(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            UpdateDisplay(6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            UpdateDisplay(7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            UpdateDisplay(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            UpdateDisplay(9);
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value2 = Buffer;
            CalculateResult(Program.Operation);
            Program.Decimals = -1; // New operation is going to start. Reset Decimal place counter.

        }

        private void button10_Click(object sender, EventArgs e)// Press + button
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 1; // addition
            Program.Decimals = -1;
            
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 2; // Subtraction
            Program.Decimals = -1;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 3; // Subtraction
            Program.Decimals = -1;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 4; // Subtraction
            Program.Decimals = -1;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Program.Value1 = 0;
            Program.Value2 = 0;
            Program.Operation = 0;
            Program.Decimals = -1;
            Display.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDecimal_Click(object sender, EventArgs e)
        {
                        //if (Program.Decimals > 0) Program.Decimals += 1;
                        if (Program.Decimals == -1) Program.Decimals = 0;
        }

        private void ButtonMemoryClear_Click(object sender, EventArgs e)
        {
            Program.Memory = 0;
        }

        private void ButtonMemoryPlus_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Memory = Buffer;
            
        }

        private void ButtonMemoryRecall_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            String DisplayValue;
            Buffer = Program.Memory;
            DisplayValue = Convert.ToString(Buffer);
            Display.Text = DisplayValue;
            
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            String DisplayValue;
            Buffer = 3.14159265358979;
            DisplayValue = Convert.ToString(Buffer);
            Display.Text = DisplayValue;
        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 5; // Sin
            Program.Decimals = -1;
            CalculateResult(Program.Operation);
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 6; // Cos
            Program.Decimals = -1;
            CalculateResult(Program.Operation);
        }

        private void ButtonTan_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 7; // Tan
            Program.Decimals = -1;
            CalculateResult(Program.Operation);
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            double Buffer = 0;
            Buffer = Convert.ToDouble(Display.Text);
            Program.Value1 = Buffer;
            Display.Text = "0";
            Program.Operation = 8; // Sqrt
            Program.Decimals = -1;
            CalculateResult(Program.Operation);
        }

        

        
    }
}
