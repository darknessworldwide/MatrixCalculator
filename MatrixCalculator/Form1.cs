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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFillMatrixA_Click(object sender, EventArgs e)
        {
            int rows = (int)numericUpDownRowsA.Value;
            int columns = (int)numericUpDownColumnsA.Value;

            dataGridViewMatrixA.Rows.Clear();
            dataGridViewMatrixA.Columns.Clear();

            if (rows <= 0 || columns <= 0) return;

            dataGridViewMatrixA.RowCount = rows;
            dataGridViewMatrixA.ColumnCount = columns;
        }

        private void buttonFillMatrixB_Click(object sender, EventArgs e)
        {
            int rows = (int)numericUpDownRowsB.Value;
            int columns = (int)numericUpDownColumnsB.Value;

            dataGridViewMatrixB.Rows.Clear();
            dataGridViewMatrixB.Columns.Clear();

            if (rows <= 0 || columns <= 0) return;

            dataGridViewMatrixB.RowCount = rows;
            dataGridViewMatrixB.ColumnCount = columns;
        }
    }
}
