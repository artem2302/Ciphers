using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class XorReshuffle : Form
    {
        private string key, initStr, resStr;

        private void btnStart_Click(object sender, EventArgs e)
        {
            initStr = tbInitStr.Text;
            key = tbKey.Text;
            
        }

        public XorReshuffle()
        {
            InitializeComponent();
        }
    }
}
