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
            FillMatrix((int)numericUpDownRowsA.Value, (int)numericUpDownColumnsA.Value, dataGridViewMatrixA);
        }

        private void buttonFillMatrixB_Click(object sender, EventArgs e)
        {
            FillMatrix((int)numericUpDownRowsB.Value, (int)numericUpDownColumnsB.Value, dataGridViewMatrixB);
        }

        private void FillMatrix(int rows, int columns, DataGridView matrix)
        {
            if (rows <= 0 || columns <= 0)
            {
                matrix.Rows.Clear();
                return;
            }

            matrix.RowCount = rows;
            matrix.ColumnCount = columns;
        }

        private void ButtonArrowDown_Click(object sender, EventArgs e)
        {
            CopyMatrix(dataGridViewMatrixA, dataGridViewMatrixB);
            UpdateNumericUpDownValues();
        }

        private void ButtonArrowUpDown_Click(object sender, EventArgs e)
        {
            SwapMatrices();
            UpdateNumericUpDownValues();
        }

        private void ButtonArrowUp_Click(object sender, EventArgs e)
        {
            CopyMatrix(dataGridViewMatrixB, dataGridViewMatrixA);
            UpdateNumericUpDownValues();
        }

        private void ButtonArrowLeft_Click(object sender, EventArgs e)
        {
            CopyMatrix(dataGridViewResult, dataGridViewMatrixB);
            UpdateNumericUpDownValues();
        }

        private void UpdateNumericUpDownValues()
        {
            numericUpDownRowsA.Value = dataGridViewMatrixA.RowCount;
            numericUpDownColumnsA.Value = dataGridViewMatrixA.ColumnCount;
            numericUpDownRowsB.Value = dataGridViewMatrixB.RowCount;
            numericUpDownColumnsB.Value = dataGridViewMatrixB.ColumnCount;
        }

        private void CopyMatrix(DataGridView source, DataGridView destination)
        {
            if (source.RowCount == 0 && source.ColumnCount == 0) return;

            destination.RowCount = source.RowCount;
            destination.ColumnCount = source.ColumnCount;

            for (int i = 0; i < source.RowCount; i++)
            {
                for (int j = 0; j < source.ColumnCount; j++)
                {
                    destination.Rows[i].Cells[j].Value = source.Rows[i].Cells[j].Value;
                }
            }
        }

        private void SwapMatrices()
        {
            DataGridView temp = new DataGridView();

            CopyMatrix(dataGridViewMatrixA, temp);
            CopyMatrix(dataGridViewMatrixB, dataGridViewMatrixA);
            CopyMatrix(temp, dataGridViewMatrixB);
        }

        private void ButtonAddMatrices_Click(object sender, EventArgs e)
        {
            //int[,] matrix = new int[rows, columns];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        matrix[i, j] = matrix_A[i, j] + matrix_B[i, j];
            //    }
            //}
        }
    }
}
