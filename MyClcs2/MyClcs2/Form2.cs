using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClcs2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x + y;
            this.LabelResult.Text = z.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x - y;
            this.LabelResult.Text = z.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x * y;
            this.LabelResult.Text = z.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            try 
            {
                var x = int.Parse(this.textBoxOp1.Text);
                var y = int.Parse(this.textBoxOp2.Text);
                var z = x / y;
                this.LabelResult.Text = z.ToString();
            }
            catch (Exception ex) 
            {
                this.LabelResult.Text = "除数不能为零!!!";
            }
        }
    }
}
