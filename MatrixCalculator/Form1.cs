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
            if (source.RowCount == 0 || source.ColumnCount == 0)
            {
                destination.Rows.Clear();
                return;
            }

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
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;
            int rowsB = dataGridViewMatrixB.RowCount;
            int columnsB = dataGridViewMatrixB.ColumnCount;

            if (rowsA != rowsB || columnsA != columnsB)
            {
                MessageBox.Show("Размеры матриц не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[,] resultMatrix = new int[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    int valueA = Convert.ToInt32(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                    int valueB = Convert.ToInt32(dataGridViewMatrixB.Rows[i].Cells[j].Value);
                    resultMatrix[i, j] = valueA + valueB;
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - сложение матриц A и B:";
            ShowResultInDataGridView(resultMatrix, dataGridViewResult);
        }

        private void buttonSubtractMatrices_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;
            int rowsB = dataGridViewMatrixB.RowCount;
            int columnsB = dataGridViewMatrixB.ColumnCount;

            if (rowsA != rowsB || columnsA != columnsB)
            {
                MessageBox.Show("Размеры матриц не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[,] resultMatrix = new int[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    int valueA = Convert.ToInt32(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                    int valueB = Convert.ToInt32(dataGridViewMatrixB.Rows[i].Cells[j].Value);
                    resultMatrix[i, j] = valueA - valueB;
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - вычитание матриц A и B:";
            ShowResultInDataGridView(resultMatrix, dataGridViewResult);
        }

        private void buttonMultiplyMatrices_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;
            int rowsB = dataGridViewMatrixB.RowCount;
            int columnsB = dataGridViewMatrixB.ColumnCount;

            if (columnsA != rowsB)
            {
                MessageBox.Show("Количество столбцов матрицы A не совпадает с количеством строк матрицы B.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[,] resultMatrix = new int[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    for (int k = 0; k < columnsA; k++)
                    {
                        int valueA = Convert.ToInt32(dataGridViewMatrixA.Rows[i].Cells[k].Value);
                        int valueB = Convert.ToInt32(dataGridViewMatrixB.Rows[k].Cells[j].Value);
                        resultMatrix[i, j] += valueA * valueB;
                    }
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - умножение матриц A и B:";
            ShowResultInDataGridView(resultMatrix, dataGridViewResult);
        }

        private void ShowResultInDataGridView(int[,] matrix, DataGridView destination)
        {
            destination.Rows.Clear();
            destination.Columns.Clear();

            destination.RowCount = matrix.GetLength(0);
            destination.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < destination.RowCount; i++)
            {
                for (int j = 0; j < destination.ColumnCount; j++)
                {
                    destination.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
    }
}
