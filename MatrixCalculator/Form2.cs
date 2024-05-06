using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form2 : Form
    {
        public double Number { get; set; }
        
        public Form2()
        {
            InitializeComponent();
            Number = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Number = (double)numericUpDownMultiplyByNumber.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
