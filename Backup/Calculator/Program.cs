using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // Global variable declarations
        // This is not a standard C# practice. It's not designed for Global variables.
        public static int Operation = 0;
        public static double Memory = 0;
        public static double Value1 = 0;
        public static double Value2 = 0;
        public static double Answer = 0;
        public static int Decimals = -1;

                
        // implementation
        [STAThread]
        static void Main()
        {
            float fDisplay;
            float fOperand1;
            float fOperand2;
            int fOperation;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
