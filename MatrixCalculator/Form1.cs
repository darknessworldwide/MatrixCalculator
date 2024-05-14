using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
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

            if (rowsA == 0 || columnsA == 0 || rowsB == 0 || columnsB == 0) return;
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
            ShowResultInDataGridView(resultMatrix);
        }

        private void buttonSubtractMatrices_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;
            int rowsB = dataGridViewMatrixB.RowCount;
            int columnsB = dataGridViewMatrixB.ColumnCount;

            if (rowsA == 0 || columnsA == 0 || rowsB == 0 || columnsB == 0) return;
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
            ShowResultInDataGridView(resultMatrix);
        }

        private void buttonMultiplyMatrices_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;
            int rowsB = dataGridViewMatrixB.RowCount;
            int columnsB = dataGridViewMatrixB.ColumnCount;

            if (rowsA == 0 || columnsA == 0 || rowsB == 0 || columnsB == 0) return;
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
            ShowResultInDataGridView(resultMatrix);
        }

        private void buttonInverseMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;

            if (rowsA == 0 || columnsA == 0) return;
            if (rowsA != columnsA)
            {
                MessageBox.Show("Матрица должна быть квадратной!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            double[,] inverseMatrixA;
            try
            {
                inverseMatrixA = CalculateInverse(resultMatrix, rowsA);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении обратной матрицы A: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            groupBoxCalculationResult.Text = "Результат вычисления - обратная матрице A, матрица:";
            ShowResultInDataGridView(inverseMatrixA);
        }

        private double[,] CalculateInverse(double[,] matrix, int n)
        {
            double determinant = CalculateDeterminant(matrix, n);
            if (determinant == 0) throw new InvalidOperationException("Определитель матрицы равен нулю - обратной матрицы не существует");

            double[,] minorMatrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    minorMatrix[i, j] = CalculateMinor(matrix, n, n, i, j);
                }
            }

            double[,] adjugate = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    adjugate[i, j] = minorMatrix[i, j] * Math.Pow(-1, i + j); /*CalculateMinor(minorMatrix, n, n, i, j);*/
                }
            }

            double[,] resultMatrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resultMatrix[j, i] = adjugate[i, j] * 1 / determinant;
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        resultMatrix[i, j] *= 1 / determinant;
            //    }
            //}

            MessageBox.Show($"Определитель = {determinant} \nМатрица миноров = {minorMatrix[0, 0]} {minorMatrix[0, 1]} \n{minorMatrix[1, 0]} {minorMatrix[1, 1]} \nМатрица алгебраических дополнений = {adjugate[0, 0]} {adjugate[0, 1]} \n{adjugate[1, 0]} {adjugate[1, 1]} \nОбратная матрица = {resultMatrix[0, 0]} {adjugate[1, 0]} \n{resultMatrix[1, 0]} {adjugate[1, 1]}");
            return resultMatrix;
        }

        private void buttonTransposeMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;

            if (rowsA == 0 || columnsA == 0) return;

            double[,] resultMatrix = new double[columnsA, rowsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[j, i] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            groupBoxCalculationResult.Text = "Результат вычисления - транспонированная матрица A:";
            ShowResultInDataGridView(resultMatrix);
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

            int rankMatrixA = CalculateRank(resultMatrix, rowsA, columnsA);

            groupBoxCalculationResult.Text = "Результат вычисления - ранг матрицы A равен:";
            ShowResultInDataGridView(rankMatrixA);
        }

        private int CalculateRank(double[,] matrix, int rows, int columns)
        {
            int rank = 0;

            for (int i = 0; i < rows; i++)
            {
                bool foundPivot = false;
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        foundPivot = true;
                        rank++;

                        for (int k = i + 1; k < rows; k++)
                        {
                            double ratio = matrix[k, j] / matrix[i, j];
                            for (int l = j; l < columns; l++)
                            {
                                matrix[k, l] -= matrix[i, l] * ratio;
                            }
                        }
                        break;
                    }
                }
                if (!foundPivot) continue;
            }

            return rank;
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

            double determinantMatrixA = CalculateDeterminant(resultMatrix, rowsA);

            groupBoxCalculationResult.Text = "Результат вычисления - определитель матрицы A равен:";
            ShowResultInDataGridView(determinantMatrixA);
        }

        private double CalculateDeterminant(double[,] matrix, int n)
        {
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

            double[,] resultMatrix = new double[rowsA, columnsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value);
                }
            }

            int rowIndex = dataGridViewMatrixA.CurrentCell.RowIndex;
            int columnIndex = dataGridViewMatrixA.CurrentCell.ColumnIndex;

            double minor = CalculateMinor(resultMatrix, rowsA, columnsA, rowIndex, columnIndex);

            groupBoxCalculationResult.Text = "Результат вычисления - минор элемента матрицы A равен:";
            ShowResultInDataGridView(minor);
        }

        private double CalculateMinor(double[,] matrix, int rows, int columns, int rowIndex, int columnIndex)
        {
            double[,] minorMatrix = new double[rows - 1, columns - 1];

            int minorRow = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i == rowIndex) continue;

                int minorColumn = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (j == columnIndex) continue;

                    minorMatrix[minorRow, minorColumn] = matrix[i, j];
                    minorColumn++;
                }
                minorRow++;
            }

            double minorDeterminant = CalculateDeterminant(minorMatrix, minorMatrix.GetLength(0));
            return minorDeterminant;
        }

        private void buttonMultiplyMatrixAByNumber_Click(object sender, EventArgs e)
        {
            int rowsA = dataGridViewMatrixA.RowCount;
            int columnsA = dataGridViewMatrixA.ColumnCount;

            if (rowsA == 0 || columnsA == 0) return;

            using (var form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    double number = form2.Number;

                    double[,] resultMatrix = new double[rowsA, columnsA];

                    for (int i = 0; i < rowsA; i++)
                    {
                        for (int j = 0; j < columnsA; j++)
                        {
                            resultMatrix[i, j] = Convert.ToDouble(dataGridViewMatrixA.Rows[i].Cells[j].Value) * number;
                        }
                    }

                    groupBoxCalculationResult.Text = $"Результат вычисления - матрица A, умноженная на число {number}:";
                    ShowResultInDataGridView(resultMatrix);
                }
            }
        }

        private void ShowResultInDataGridView<T>(T value)
        {
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double))
            {
                dataGridViewResult.Rows.Clear();
                dataGridViewResult.Columns.Clear();

                dataGridViewResult.RowCount = 1;
                dataGridViewResult.ColumnCount = 1;
                dataGridViewResult.Rows[0].Cells[0].Value = value;
            }
            else if (typeof(T) == typeof(double[,]))
            {
                double[,] matrix = value as double[,];

                if (matrix.Length == 0)
                {
                    groupBoxCalculationResult.Text = "Результат вычисления";
                    dataGridViewResult.Rows.Clear();
                    dataGridViewResult.Columns.Clear();
                    return;
                }

                dataGridViewResult.RowCount = matrix.GetLength(0);
                dataGridViewResult.ColumnCount = matrix.GetLength(1);

                for (int i = 0; i < dataGridViewResult.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewResult.ColumnCount; j++)
                    {
                        dataGridViewResult.Rows[i].Cells[j].Value = Math.Round(matrix[i, j], 3);
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
