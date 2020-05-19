using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlifCalcv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string number = "";
        static double x = 0;
        static double y = 0;
        static char function = ' ';

        private void Num_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            number += btn.Text;
            PanelTBox.Text = number;
        }

        private void BackspaceBtn_Click(object sender, EventArgs e)
        {
            char[] nums = number.ToCharArray();
            number = "";
            for (int i = 0; i < nums.Length - 1; i++)
            {
                number += nums[i];
            }
            PanelTBox.Text = number;
        }

        private void ClearElementBtn_Click(object sender, EventArgs e)
        {
            number = "";
            y = 0;
            PanelTBox.Text = "0";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            number = "";
            y = 0;
            x = 0;
            PanelTBox.Text = "0";
            FunctionLbl.Text = "";
        }

        private void Function_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            function = char.Parse(btn.Text);
            FunctionLbl.Text = function.ToString();
            if (x == 0)
            {
                x = double.Parse(number);
                number = "";
            }
            else
            {
                y = double.Parse(number);
                number = "";
                technique();
            }
        }

        private void technique()
        {
            switch (function)
            {
                case '+':
                    {
                        x += y;
                    }
                    break;
                case '/':
                    {
                        x /= y;
                    }
                    break;
                case '*':
                    {
                        x *= y;
                    }
                    break;
                case '-':
                    {
                        x -= y;
                    }
                    break;
            }
            y = 0;
            function = ' ';
            PanelTBox.Text = x.ToString();
        }
    }
}
