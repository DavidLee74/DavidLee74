namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.ButtonMemoryClear = new System.Windows.Forms.Button();
            this.ButtonBackspace = new System.Windows.Forms.Button();
            this.ButtonMemoryPlus = new System.Windows.Forms.Button();
            this.ButtonMemoryRecall = new System.Windows.Forms.Button();
            this.ButtonMemoryMinus = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.ButtonPi = new System.Windows.Forms.Button();
            this.ButtonSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Black;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.Lime;
            this.Display.Location = new System.Drawing.Point(45, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(412, 35);
            this.Display.TabIndex = 0;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(262, 181);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(34, 30);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(302, 181);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(34, 30);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(342, 181);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(34, 30);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(342, 145);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(34, 30);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(302, 145);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(34, 30);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(262, 145);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(34, 30);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(262, 109);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(34, 30);
            this.Button7.TabIndex = 7;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(302, 109);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(34, 30);
            this.Button8.TabIndex = 8;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(342, 109);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(34, 30);
            this.Button9.TabIndex = 9;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(262, 217);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(74, 30);
            this.Button0.TabIndex = 10;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(382, 109);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(34, 66);
            this.ButtonPlus.TabIndex = 11;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.button10_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(382, 73);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(34, 30);
            this.ButtonMinus.TabIndex = 12;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Location = new System.Drawing.Point(382, 181);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(34, 66);
            this.ButtonEquals.TabIndex = 13;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(422, 109);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(34, 66);
            this.ButtonClear.TabIndex = 14;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Location = new System.Drawing.Point(422, 181);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(34, 30);
            this.ButtonMultiply.TabIndex = 15;
            this.ButtonMultiply.Text = "X";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(422, 217);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(34, 30);
            this.ButtonDivide.TabIndex = 16;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.Location = new System.Drawing.Point(342, 217);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(34, 30);
            this.ButtonDecimal.TabIndex = 17;
            this.ButtonDecimal.Text = ".";
            this.ButtonDecimal.UseVisualStyleBackColor = true;
            this.ButtonDecimal.Click += new System.EventHandler(this.ButtonDecimal_Click);
            // 
            // ButtonMemoryClear
            // 
            this.ButtonMemoryClear.Location = new System.Drawing.Point(222, 109);
            this.ButtonMemoryClear.Name = "ButtonMemoryClear";
            this.ButtonMemoryClear.Size = new System.Drawing.Size(34, 30);
            this.ButtonMemoryClear.TabIndex = 18;
            this.ButtonMemoryClear.Text = "MC";
            this.ButtonMemoryClear.UseVisualStyleBackColor = true;
            this.ButtonMemoryClear.Click += new System.EventHandler(this.ButtonMemoryClear_Click);
            // 
            // ButtonBackspace
            // 
            this.ButtonBackspace.Location = new System.Drawing.Point(422, 73);
            this.ButtonBackspace.Name = "ButtonBackspace";
            this.ButtonBackspace.Size = new System.Drawing.Size(34, 30);
            this.ButtonBackspace.TabIndex = 20;
            this.ButtonBackspace.Text = "<--";
            this.ButtonBackspace.UseVisualStyleBackColor = true;
            // 
            // ButtonMemoryPlus
            // 
            this.ButtonMemoryPlus.Location = new System.Drawing.Point(222, 181);
            this.ButtonMemoryPlus.Name = "ButtonMemoryPlus";
            this.ButtonMemoryPlus.Size = new System.Drawing.Size(34, 30);
            this.ButtonMemoryPlus.TabIndex = 19;
            this.ButtonMemoryPlus.Text = "M+";
            this.ButtonMemoryPlus.UseVisualStyleBackColor = true;
            this.ButtonMemoryPlus.Click += new System.EventHandler(this.ButtonMemoryPlus_Click);
            // 
            // ButtonMemoryRecall
            // 
            this.ButtonMemoryRecall.Location = new System.Drawing.Point(222, 145);
            this.ButtonMemoryRecall.Name = "ButtonMemoryRecall";
            this.ButtonMemoryRecall.Size = new System.Drawing.Size(34, 30);
            this.ButtonMemoryRecall.TabIndex = 21;
            this.ButtonMemoryRecall.Text = "MR";
            this.ButtonMemoryRecall.UseVisualStyleBackColor = true;
            this.ButtonMemoryRecall.Click += new System.EventHandler(this.ButtonMemoryRecall_Click);
            // 
            // ButtonMemoryMinus
            // 
            this.ButtonMemoryMinus.Location = new System.Drawing.Point(222, 217);
            this.ButtonMemoryMinus.Name = "ButtonMemoryMinus";
            this.ButtonMemoryMinus.Size = new System.Drawing.Size(34, 30);
            this.ButtonMemoryMinus.TabIndex = 22;
            this.ButtonMemoryMinus.Text = "M-";
            this.ButtonMemoryMinus.UseVisualStyleBackColor = true;
            // 
            // ButtonSin
            // 
            this.ButtonSin.Location = new System.Drawing.Point(182, 109);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(34, 30);
            this.ButtonSin.TabIndex = 23;
            this.ButtonSin.Text = "Sin";
            this.ButtonSin.UseVisualStyleBackColor = true;
            this.ButtonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.Location = new System.Drawing.Point(182, 145);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(34, 30);
            this.ButtonCos.TabIndex = 24;
            this.ButtonCos.Text = "Cos";
            this.ButtonCos.UseVisualStyleBackColor = true;
            this.ButtonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // ButtonTan
            // 
            this.ButtonTan.Location = new System.Drawing.Point(182, 181);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(34, 30);
            this.ButtonTan.TabIndex = 25;
            this.ButtonTan.Text = "Tan";
            this.ButtonTan.UseVisualStyleBackColor = true;
            this.ButtonTan.Click += new System.EventHandler(this.ButtonTan_Click);
            // 
            // ButtonPi
            // 
            this.ButtonPi.Location = new System.Drawing.Point(182, 217);
            this.ButtonPi.Name = "ButtonPi";
            this.ButtonPi.Size = new System.Drawing.Size(34, 30);
            this.ButtonPi.TabIndex = 26;
            this.ButtonPi.Text = "Pi";
            this.ButtonPi.UseVisualStyleBackColor = true;
            this.ButtonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // ButtonSqrt
            // 
            this.ButtonSqrt.Location = new System.Drawing.Point(142, 109);
            this.ButtonSqrt.Name = "ButtonSqrt";
            this.ButtonSqrt.Size = new System.Drawing.Size(34, 30);
            this.ButtonSqrt.TabIndex = 27;
            this.ButtonSqrt.Text = "Sqrt";
            this.ButtonSqrt.UseVisualStyleBackColor = true;
            this.ButtonSqrt.Click += new System.EventHandler(this.ButtonSqrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 266);
            this.Controls.Add(this.ButtonSqrt);
            this.Controls.Add(this.ButtonPi);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonMemoryMinus);
            this.Controls.Add(this.ButtonMemoryRecall);
            this.Controls.Add(this.ButtonBackspace);
            this.Controls.Add(this.ButtonMemoryPlus);
            this.Controls.Add(this.ButtonMemoryClear);
            this.Controls.Add(this.ButtonDecimal);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "My First C# Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonDecimal;
        private System.Windows.Forms.Button ButtonMemoryClear;
        private System.Windows.Forms.Button ButtonBackspace;
        private System.Windows.Forms.Button ButtonMemoryPlus;
        private System.Windows.Forms.Button ButtonMemoryRecall;
        private System.Windows.Forms.Button ButtonMemoryMinus;
        private System.Windows.Forms.Button ButtonSin;
        private System.Windows.Forms.Button ButtonCos;
        private System.Windows.Forms.Button ButtonTan;
        private System.Windows.Forms.Button ButtonPi;
        private System.Windows.Forms.Button ButtonSqrt;
    }
}

