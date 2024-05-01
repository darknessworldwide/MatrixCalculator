namespace MatrixCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxMatrixA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixA = new System.Windows.Forms.DataGridView();
            this.buttonFillMatrixA = new System.Windows.Forms.Button();
            this.numericUpDownColumnsA = new System.Windows.Forms.NumericUpDown();
            this.labelColumnsA = new System.Windows.Forms.Label();
            this.numericUpDownRowsA = new System.Windows.Forms.NumericUpDown();
            this.labelRowsA = new System.Windows.Forms.Label();
            this.groupBoxMatrixB = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixB = new System.Windows.Forms.DataGridView();
            this.buttonFillMatrixB = new System.Windows.Forms.Button();
            this.numericUpDownColumnsB = new System.Windows.Forms.NumericUpDown();
            this.labelColumnsB = new System.Windows.Forms.Label();
            this.numericUpDownRowsB = new System.Windows.Forms.NumericUpDown();
            this.labelRowsB = new System.Windows.Forms.Label();
            this.groupBoxMatrixOperations = new System.Windows.Forms.GroupBox();
            this.buttonMultiplyMatrices = new System.Windows.Forms.Button();
            this.buttonSubtractMatrices = new System.Windows.Forms.Button();
            this.buttonAddMatrices = new System.Windows.Forms.Button();
            this.groupBoxMatrixAOperations = new System.Windows.Forms.GroupBox();
            this.buttonMultiplyMatrixAByNumber = new System.Windows.Forms.Button();
            this.buttonMinorMatrixA = new System.Windows.Forms.Button();
            this.buttonDeterminantMatrixA = new System.Windows.Forms.Button();
            this.buttonRankMatrixA = new System.Windows.Forms.Button();
            this.buttonTransposeMatrixA = new System.Windows.Forms.Button();
            this.buttonInverseMatrixA = new System.Windows.Forms.Button();
            this.groupBoxCalculationResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxMatrixA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnsA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsA)).BeginInit();
            this.groupBoxMatrixB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnsB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsB)).BeginInit();
            this.groupBoxMatrixOperations.SuspendLayout();
            this.groupBoxMatrixAOperations.SuspendLayout();
            this.groupBoxCalculationResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMatrixA
            // 
            this.groupBoxMatrixA.Controls.Add(this.dataGridViewMatrixA);
            this.groupBoxMatrixA.Controls.Add(this.buttonFillMatrixA);
            this.groupBoxMatrixA.Controls.Add(this.numericUpDownColumnsA);
            this.groupBoxMatrixA.Controls.Add(this.labelColumnsA);
            this.groupBoxMatrixA.Controls.Add(this.numericUpDownRowsA);
            this.groupBoxMatrixA.Controls.Add(this.labelRowsA);
            this.groupBoxMatrixA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMatrixA.Name = "groupBoxMatrixA";
            this.groupBoxMatrixA.Size = new System.Drawing.Size(374, 209);
            this.groupBoxMatrixA.TabIndex = 0;
            this.groupBoxMatrixA.TabStop = false;
            this.groupBoxMatrixA.Text = "Матрица A:";
            // 
            // dataGridViewMatrixA
            // 
            this.dataGridViewMatrixA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMatrixA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixA.Location = new System.Drawing.Point(6, 40);
            this.dataGridViewMatrixA.Name = "dataGridViewMatrixA";
            this.dataGridViewMatrixA.Size = new System.Drawing.Size(359, 153);
            this.dataGridViewMatrixA.TabIndex = 1;
            // 
            // buttonFillMatrixA
            // 
            this.buttonFillMatrixA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFillMatrixA.Location = new System.Drawing.Point(290, 14);
            this.buttonFillMatrixA.Name = "buttonFillMatrixA";
            this.buttonFillMatrixA.Size = new System.Drawing.Size(75, 20);
            this.buttonFillMatrixA.TabIndex = 1;
            this.buttonFillMatrixA.Text = "Заполнить";
            this.buttonFillMatrixA.UseVisualStyleBackColor = true;
            // 
            // numericUpDownColumnsA
            // 
            this.numericUpDownColumnsA.Location = new System.Drawing.Point(242, 14);
            this.numericUpDownColumnsA.Name = "numericUpDownColumnsA";
            this.numericUpDownColumnsA.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownColumnsA.TabIndex = 4;
            this.numericUpDownColumnsA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelColumnsA
            // 
            this.labelColumnsA.AutoSize = true;
            this.labelColumnsA.Location = new System.Drawing.Point(187, 16);
            this.labelColumnsA.Name = "labelColumnsA";
            this.labelColumnsA.Size = new System.Drawing.Size(58, 13);
            this.labelColumnsA.TabIndex = 3;
            this.labelColumnsA.Text = "Столбцов:";
            // 
            // numericUpDownRowsA
            // 
            this.numericUpDownRowsA.Location = new System.Drawing.Point(139, 14);
            this.numericUpDownRowsA.Name = "numericUpDownRowsA";
            this.numericUpDownRowsA.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownRowsA.TabIndex = 2;
            this.numericUpDownRowsA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelRowsA
            // 
            this.labelRowsA.AutoSize = true;
            this.labelRowsA.Location = new System.Drawing.Point(102, 16);
            this.labelRowsA.Name = "labelRowsA";
            this.labelRowsA.Size = new System.Drawing.Size(40, 13);
            this.labelRowsA.TabIndex = 1;
            this.labelRowsA.Text = "Строк:";
            // 
            // groupBoxMatrixB
            // 
            this.groupBoxMatrixB.Controls.Add(this.dataGridViewMatrixB);
            this.groupBoxMatrixB.Controls.Add(this.buttonFillMatrixB);
            this.groupBoxMatrixB.Controls.Add(this.numericUpDownColumnsB);
            this.groupBoxMatrixB.Controls.Add(this.labelColumnsB);
            this.groupBoxMatrixB.Controls.Add(this.numericUpDownRowsB);
            this.groupBoxMatrixB.Controls.Add(this.labelRowsB);
            this.groupBoxMatrixB.Location = new System.Drawing.Point(12, 254);
            this.groupBoxMatrixB.Name = "groupBoxMatrixB";
            this.groupBoxMatrixB.Size = new System.Drawing.Size(374, 209);
            this.groupBoxMatrixB.TabIndex = 1;
            this.groupBoxMatrixB.TabStop = false;
            this.groupBoxMatrixB.Text = "Матрица B:";
            // 
            // dataGridViewMatrixB
            // 
            this.dataGridViewMatrixB.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMatrixB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixB.Location = new System.Drawing.Point(6, 40);
            this.dataGridViewMatrixB.Name = "dataGridViewMatrixB";
            this.dataGridViewMatrixB.Size = new System.Drawing.Size(359, 153);
            this.dataGridViewMatrixB.TabIndex = 1;
            // 
            // buttonFillMatrixB
            // 
            this.buttonFillMatrixB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFillMatrixB.Location = new System.Drawing.Point(290, 14);
            this.buttonFillMatrixB.Name = "buttonFillMatrixB";
            this.buttonFillMatrixB.Size = new System.Drawing.Size(75, 20);
            this.buttonFillMatrixB.TabIndex = 1;
            this.buttonFillMatrixB.Text = "Заполнить";
            this.buttonFillMatrixB.UseVisualStyleBackColor = true;
            // 
            // numericUpDownColumnsB
            // 
            this.numericUpDownColumnsB.Location = new System.Drawing.Point(242, 14);
            this.numericUpDownColumnsB.Name = "numericUpDownColumnsB";
            this.numericUpDownColumnsB.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownColumnsB.TabIndex = 4;
            this.numericUpDownColumnsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelColumnsB
            // 
            this.labelColumnsB.AutoSize = true;
            this.labelColumnsB.Location = new System.Drawing.Point(187, 16);
            this.labelColumnsB.Name = "labelColumnsB";
            this.labelColumnsB.Size = new System.Drawing.Size(58, 13);
            this.labelColumnsB.TabIndex = 3;
            this.labelColumnsB.Text = "Столбцов:";
            // 
            // numericUpDownRowsB
            // 
            this.numericUpDownRowsB.Location = new System.Drawing.Point(139, 14);
            this.numericUpDownRowsB.Name = "numericUpDownRowsB";
            this.numericUpDownRowsB.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownRowsB.TabIndex = 2;
            this.numericUpDownRowsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelRowsB
            // 
            this.labelRowsB.AutoSize = true;
            this.labelRowsB.Location = new System.Drawing.Point(102, 16);
            this.labelRowsB.Name = "labelRowsB";
            this.labelRowsB.Size = new System.Drawing.Size(40, 13);
            this.labelRowsB.TabIndex = 1;
            this.labelRowsB.Text = "Строк:";
            // 
            // groupBoxMatrixOperations
            // 
            this.groupBoxMatrixOperations.Controls.Add(this.buttonMultiplyMatrices);
            this.groupBoxMatrixOperations.Controls.Add(this.buttonSubtractMatrices);
            this.groupBoxMatrixOperations.Controls.Add(this.buttonAddMatrices);
            this.groupBoxMatrixOperations.Location = new System.Drawing.Point(392, 12);
            this.groupBoxMatrixOperations.Name = "groupBoxMatrixOperations";
            this.groupBoxMatrixOperations.Size = new System.Drawing.Size(401, 50);
            this.groupBoxMatrixOperations.TabIndex = 2;
            this.groupBoxMatrixOperations.TabStop = false;
            this.groupBoxMatrixOperations.Text = "Операции над матрицами A и B:";
            // 
            // buttonMultiplyMatrices
            // 
            this.buttonMultiplyMatrices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplyMatrices.Location = new System.Drawing.Point(268, 19);
            this.buttonMultiplyMatrices.Name = "buttonMultiplyMatrices";
            this.buttonMultiplyMatrices.Size = new System.Drawing.Size(125, 23);
            this.buttonMultiplyMatrices.TabIndex = 4;
            this.buttonMultiplyMatrices.Text = "Умножение матриц";
            this.buttonMultiplyMatrices.UseVisualStyleBackColor = true;
            // 
            // buttonSubtractMatrices
            // 
            this.buttonSubtractMatrices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubtractMatrices.Location = new System.Drawing.Point(137, 19);
            this.buttonSubtractMatrices.Name = "buttonSubtractMatrices";
            this.buttonSubtractMatrices.Size = new System.Drawing.Size(125, 23);
            this.buttonSubtractMatrices.TabIndex = 4;
            this.buttonSubtractMatrices.Text = "Вычитание матриц";
            this.buttonSubtractMatrices.UseVisualStyleBackColor = true;
            // 
            // buttonAddMatrices
            // 
            this.buttonAddMatrices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMatrices.Location = new System.Drawing.Point(6, 19);
            this.buttonAddMatrices.Name = "buttonAddMatrices";
            this.buttonAddMatrices.Size = new System.Drawing.Size(125, 23);
            this.buttonAddMatrices.TabIndex = 3;
            this.buttonAddMatrices.Text = "Сложение матриц";
            this.buttonAddMatrices.UseVisualStyleBackColor = true;
            // 
            // groupBoxMatrixAOperations
            // 
            this.groupBoxMatrixAOperations.Controls.Add(this.buttonMultiplyMatrixAByNumber);
            this.groupBoxMatrixAOperations.Controls.Add(this.buttonMinorMatrixA);
            this.groupBoxMatrixAOperations.Controls.Add(this.buttonDeterminantMatrixA);
            this.groupBoxMatrixAOperations.Controls.Add(this.buttonRankMatrixA);
            this.groupBoxMatrixAOperations.Controls.Add(this.buttonTransposeMatrixA);
            this.groupBoxMatrixAOperations.Controls.Add(this.buttonInverseMatrixA);
            this.groupBoxMatrixAOperations.Location = new System.Drawing.Point(392, 82);
            this.groupBoxMatrixAOperations.Name = "groupBoxMatrixAOperations";
            this.groupBoxMatrixAOperations.Size = new System.Drawing.Size(401, 82);
            this.groupBoxMatrixAOperations.TabIndex = 3;
            this.groupBoxMatrixAOperations.TabStop = false;
            this.groupBoxMatrixAOperations.Text = "Операции над матрицей A:";
            // 
            // buttonMultiplyMatrixAByNumber
            // 
            this.buttonMultiplyMatrixAByNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplyMatrixAByNumber.Location = new System.Drawing.Point(268, 48);
            this.buttonMultiplyMatrixAByNumber.Name = "buttonMultiplyMatrixAByNumber";
            this.buttonMultiplyMatrixAByNumber.Size = new System.Drawing.Size(125, 23);
            this.buttonMultiplyMatrixAByNumber.TabIndex = 4;
            this.buttonMultiplyMatrixAByNumber.Text = "Умножить на число";
            this.buttonMultiplyMatrixAByNumber.UseVisualStyleBackColor = true;
            // 
            // buttonMinorMatrixA
            // 
            this.buttonMinorMatrixA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinorMatrixA.Location = new System.Drawing.Point(137, 48);
            this.buttonMinorMatrixA.Name = "buttonMinorMatrixA";
            this.buttonMinorMatrixA.Size = new System.Drawing.Size(125, 23);
            this.buttonMinorMatrixA.TabIndex = 4;
            this.buttonMinorMatrixA.Text = "Минор элемента";
            this.buttonMinorMatrixA.UseVisualStyleBackColor = true;
            // 
            // buttonDeterminantMatrixA
            // 
            this.buttonDeterminantMatrixA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeterminantMatrixA.Location = new System.Drawing.Point(6, 48);
            this.buttonDeterminantMatrixA.Name = "buttonDeterminantMatrixA";
            this.buttonDeterminantMatrixA.Size = new System.Drawing.Size(125, 23);
            this.buttonDeterminantMatrixA.TabIndex = 4;
            this.buttonDeterminantMatrixA.Text = "Определитель";
            this.buttonDeterminantMatrixA.UseVisualStyleBackColor = true;
            // 
            // buttonRankMatrixA
            // 
            this.buttonRankMatrixA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRankMatrixA.Location = new System.Drawing.Point(268, 19);
            this.buttonRankMatrixA.Name = "buttonRankMatrixA";
            this.buttonRankMatrixA.Size = new System.Drawing.Size(125, 23);
            this.buttonRankMatrixA.TabIndex = 4;
            this.buttonRankMatrixA.Text = "Ранг матрицы";
            this.buttonRankMatrixA.UseVisualStyleBackColor = true;
            // 
            // buttonTransposeMatrixA
            // 
            this.buttonTransposeMatrixA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransposeMatrixA.Location = new System.Drawing.Point(137, 19);
            this.buttonTransposeMatrixA.Name = "buttonTransposeMatrixA";
            this.buttonTransposeMatrixA.Size = new System.Drawing.Size(125, 23);
            this.buttonTransposeMatrixA.TabIndex = 4;
            this.buttonTransposeMatrixA.Text = "Транспонирование";
            this.buttonTransposeMatrixA.UseVisualStyleBackColor = true;
            // 
            // buttonInverseMatrixA
            // 
            this.buttonInverseMatrixA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInverseMatrixA.Location = new System.Drawing.Point(6, 19);
            this.buttonInverseMatrixA.Name = "buttonInverseMatrixA";
            this.buttonInverseMatrixA.Size = new System.Drawing.Size(125, 23);
            this.buttonInverseMatrixA.TabIndex = 4;
            this.buttonInverseMatrixA.Text = "Обратная матрица";
            this.buttonInverseMatrixA.UseVisualStyleBackColor = true;
            // 
            // groupBoxCalculationResult
            // 
            this.groupBoxCalculationResult.Controls.Add(this.dataGridViewResult);
            this.groupBoxCalculationResult.Location = new System.Drawing.Point(411, 207);
            this.groupBoxCalculationResult.Name = "groupBoxCalculationResult";
            this.groupBoxCalculationResult.Size = new System.Drawing.Size(374, 209);
            this.groupBoxCalculationResult.TabIndex = 4;
            this.groupBoxCalculationResult.TabStop = false;
            this.groupBoxCalculationResult.Text = "Результат вычисления:";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(359, 174);
            this.dataGridViewResult.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Image = global::MatrixCalculator.Properties.Resources.exit_icon;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(727, 437);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(66, 29);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::MatrixCalculator.Properties.Resources.arrow_down;
            this.button1.Location = new System.Drawing.Point(168, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::MatrixCalculator.Properties.Resources.arrow_up;
            this.button2.Location = new System.Drawing.Point(202, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::MatrixCalculator.Properties.Resources.arrow_left;
            this.button3.Location = new System.Drawing.Point(386, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 478);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxCalculationResult);
            this.Controls.Add(this.groupBoxMatrixAOperations);
            this.Controls.Add(this.groupBoxMatrixOperations);
            this.Controls.Add(this.groupBoxMatrixB);
            this.Controls.Add(this.groupBoxMatrixA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Матричный калькулятор";
            this.groupBoxMatrixA.ResumeLayout(false);
            this.groupBoxMatrixA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnsA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsA)).EndInit();
            this.groupBoxMatrixB.ResumeLayout(false);
            this.groupBoxMatrixB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnsB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRowsB)).EndInit();
            this.groupBoxMatrixOperations.ResumeLayout(false);
            this.groupBoxMatrixAOperations.ResumeLayout(false);
            this.groupBoxCalculationResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMatrixA;
        private System.Windows.Forms.Button buttonFillMatrixA;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnsA;
        private System.Windows.Forms.Label labelColumnsA;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsA;
        private System.Windows.Forms.Label labelRowsA;
        private System.Windows.Forms.DataGridView dataGridViewMatrixA;
        private System.Windows.Forms.GroupBox groupBoxMatrixB;
        private System.Windows.Forms.DataGridView dataGridViewMatrixB;
        private System.Windows.Forms.Button buttonFillMatrixB;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnsB;
        private System.Windows.Forms.Label labelColumnsB;
        private System.Windows.Forms.NumericUpDown numericUpDownRowsB;
        private System.Windows.Forms.Label labelRowsB;
        private System.Windows.Forms.GroupBox groupBoxMatrixOperations;
        private System.Windows.Forms.Button buttonAddMatrices;
        private System.Windows.Forms.Button buttonMultiplyMatrices;
        private System.Windows.Forms.Button buttonSubtractMatrices;
        private System.Windows.Forms.GroupBox groupBoxMatrixAOperations;
        private System.Windows.Forms.Button buttonMultiplyMatrixAByNumber;
        private System.Windows.Forms.Button buttonMinorMatrixA;
        private System.Windows.Forms.Button buttonDeterminantMatrixA;
        private System.Windows.Forms.Button buttonRankMatrixA;
        private System.Windows.Forms.Button buttonTransposeMatrixA;
        private System.Windows.Forms.Button buttonInverseMatrixA;
        private System.Windows.Forms.GroupBox groupBoxCalculationResult;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

