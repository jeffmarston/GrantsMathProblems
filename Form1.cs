using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrantsMathProblems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MathPane mp = new MathPane(Callback);
            flowLayoutPanel1.Controls.Add(mp);
        }

        private int Callback()
        {
            MathPane mp = new MathPane(Callback);
            flowLayoutPanel1.Controls.Add(mp);
            mp.Init();
            return 1;
        }
    }
}
