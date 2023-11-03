using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaihomaru
{
    public partial class Start : Form
    {
        public bool exit = true;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit)
            {
                Environment.Exit(0);
            }
        }
    }
}
