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
            Application.Exit();
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
            if (rows == 0 || columns == 0)
            {
                matrix.Rows.Clear();
                matrix.Columns.Clear();
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
                destination.Columns.Clear();
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

            UpdateNumericUpDownValues();
        }

        private void ButtonAddMatrices_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;
            int rowsB = dataGridViewMatrixB.RowCount;
            int columnsB = dataGridViewMatrixB.ColumnCount;

            if (rowsA != rowsB || columnsA != columnsB)
            {
                MessageBox.Show("Размеры матриц не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    double valueA = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                    double valueB = Convert.ToDouble(dataGridViewMatrixB.Rows[i].Cells[j].Value);
                    resultMatrix[i, j] = valueA + valueB;
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - сумма матриц A и B:";
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
                MessageBox.Show("Размеры матриц не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    double valueA = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                    double valueB = Convert.ToDouble(dataGridViewMatrixB.Rows[i].Cells[j].Value);
                    resultMatrix[i, j] = valueA - valueB;
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - разность матриц A и B:";
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
                MessageBox.Show("Количество столбцов матрицы A не совпадает с количеством строк матрицы B!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[,] resultMatrix = new double[rowsA, columnsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    for (int k = 0; k < columnsA; k++)
                    {
                        double valueA = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[k].Value);
                        double valueB = Convert.ToDouble(dataGridViewMatrixB.Rows[k].Cells[j].Value);
                        resultMatrix[i, j] += valueA * valueB;
                    }
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - произведение матриц A и B:";
            ShowResultInDataGridView(resultMatrix, dataGridViewResult);
        }

        private void buttonInverseMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;
            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            Matrix<double> matrixA = DenseMatrix.OfArray(resultMatrix);
            Matrix<double> inverseMatrixA;
            try
            {
                inverseMatrixA = matrixA.Inverse();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении обратной матрицы A: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            groupBoxCalculationResult.Text = "Результат вычисления - обратная матрице A, матрица:";
            ShowResultInDataGridView(inverseMatrixA.ToArray(), dataGridViewResult);
        }

        private void buttonTransposeMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;

            double[,] resultMatrix = new double[columnsA, rowsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[j, i] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - транспонированная матрица A:";
            ShowResultInDataGridView(resultMatrix, dataGridViewResult);
        }

        private void buttonRankMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;

            if (rowsA == 0 || columnsA == 0) return;

            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            Matrix<double> matrixA = DenseMatrix.OfArray(resultMatrix);
            int rankMatrixA = matrixA.Rank();

            groupBoxCalculationResult.Text = "Результат вычисления - ранг матрицы A равен:";
            ShowResultInDataGridView(rankMatrixA, dataGridViewResult);
        }

        private void buttonDeterminantMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;

            if (rowsA == 0 || columnsA == 0) return;

            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            double determinantMatrixA = CalculateDeterminant(resultMatrix);

            groupBoxCalculationResult.Text = "Результат вычисления - определитель матрицы A равен:";
            ShowResultInDataGridView(determinantMatrixA, dataGridViewResult);
        }

        private double CalculateDeterminant(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            if (n == 1) return matrix[0, 0];

            double determinant = 1;

            for (int i = 0; i < n; i++)
            {
                double maxElement = Math.Abs(matrix[i, i]);
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(matrix[k, i]) > maxElement)
                    {
                        maxElement = Math.Abs(matrix[k, i]);
                        maxRow = k;
                    }
                }

                if (maxRow != i)
                {
                    for (int k = i; k < n; k++)
                    {
                        double temp = matrix[maxRow, k];
                        matrix[maxRow, k] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                    determinant *= -1;
                }

                for (int j = i + 1; j < n; j++)
                {
                    double ratio = matrix[j, i] / matrix[i, i];
                    for (int k = i; k < n; k++)
                    {
                        matrix[j, k] -= ratio * matrix[i, k];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                determinant *= matrix[i, i];
            }

            return determinant;
        }

        private void buttonMinorMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;

            if (rowsA == 0 || columnsA == 0) return;

            int rowIndex = dataGridViewMatrixA.CurrentCell.RowIndex;
            int columnIndex = dataGridViewMatrixA.CurrentCell.ColumnIndex;

            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            Matrix<double> matrixA = DenseMatrix.OfArray(resultMatrix);
            Matrix<double> minorMatrix = matrixA.RemoveRow(rowIndex).RemoveColumn(columnIndex);
            double minor = minorMatrix.Determinant();

            groupBoxCalculationResult.Text = "Результат вычисления - минор элемента матрицы A равен:";
            ShowResultInDataGridView(minor, dataGridViewResult);
        }

        private void buttonMultiplyMatrixAByNumber_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    double number = form2.Number;

                    int rowsA = dataGridViewMatrixA.RowCount;
                    int columnsA = dataGridViewMatrixA.ColumnCount;

                    double[,] resultMatrix = new double[rowsA, columnsA];

                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < columnsA; j++)
                        {
                            resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                        }
                    }

                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < columnsA; j++)
                        {
                            resultMatrix[i, j] *= number;
                        }
                    }

                    groupBoxCalculationResult.Text = $"Результат вычисления - матрица A, умноженная на число {number}:";
                    ShowResultInDataGridView(resultMatrix, dataGridViewResult);
                }
            }
        }

        private void ShowResultInDataGridView<T>(T value, DataGridView destination)
        {
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double))
            {
                destination.Rows.Clear();
                destination.Columns.Clear();

                destination.RowCount = 1;
                destination.ColumnCount = 1;
                destination.Rows[0].Cells[0].Value = value;
            }
            else if (typeof(T) == typeof(double[,]))
            {
                double[,] matrix = value as double[,];

                if (matrix.Length == 0)
                {
                    groupBoxCalculationResult.Text = "Результат вычисления -";
                    destination.Rows.Clear();
                    destination.Columns.Clear();
                    return;
                }

                destination.RowCount = matrix.GetLength(0);
                destination.ColumnCount = matrix.GetLength(1);

                for (int i = 0; i < destination.RowCount; i++)
                {
                    for (int j = 0; j < destination.ColumnCount; j++)
                    {
                        destination.Rows[i].Cells[j].Value = Math.Round(matrix[i, j], 3);
                    }
                }
            }
        }

        private void dataGridViewMatrixA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string input = e.FormattedValue.ToString();

            if (input == "")
            {
                e.Cancel = false;
            }
            else if (!double.TryParse(input, out double result))
            {
                e.Cancel = true;
                MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMatrixB_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            dataGridViewMatrixA_CellValidating(sender, e);
        }
    }
}
