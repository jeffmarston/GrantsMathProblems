using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GrantsMathProblems
{
    public partial class MathPane : UserControl
    {
        private Func<int> newPaneCb = null;

        public MathPane(Func<int> callback)
        {
            InitializeComponent();

            newPaneCb = callback;
            var rando = new Random();
            var num1 = rando.Next(10, 100);
            var num2 = rando.Next(10, 300);

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
        }

        public void Init()
        {
            textBox3.Focus();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text) == Int32.Parse(textBox3.Text))
                {
                    textBox3.BackColor = Color.LightGreen;
                    newPaneCb();
                }
                else
                {
                    textBox3.BackColor = Color.Pink;
                }
            }
        }
    }
}
