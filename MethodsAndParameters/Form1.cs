using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsAndParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CalculatePerimeter(int width, int length)
        {
            return (width + length) * 2;
        }

        public int CalculateArea(int width, int length)
        {
            return width * length;
        }

        public void displayresult()
        {
            int width = Convert.ToInt32(txtWidth.Text);
            int length = Convert.ToInt32(txtLength.Text);

            lblPerimeter.Text = CalculatePerimeter(width, length).ToString();
            lblArea.Text = CalculateArea(width, length).ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            displayresult();

            lblPerimeter.Visible = true;
            lblArea.Visible = true;
        }
    }
}
