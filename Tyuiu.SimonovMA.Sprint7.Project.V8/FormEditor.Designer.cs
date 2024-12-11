namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    partial class FormEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxControls_SMA = new GroupBox();
            buttonSave_SMA = new Button();
            buttonLoad_SMA = new Button();
            groupBoxWorkSpace_SMA = new GroupBox();
            groupBoxStatistics_SMA = new GroupBox();
            labelMaxWhichColumn_SMA = new Label();
            textBoxMaxWhichColumn_SMA = new TextBox();
            buttonMaxCalculate_SMA = new Button();
            textBoxMax_SMA = new TextBox();
            labelMax_SMA = new Label();
            labelMinWhichColumn_SMA = new Label();
            textBoxMinWhichColumn_SMA = new TextBox();
            buttonMinCalculate_SMA = new Button();
            textBoxMin_SMA = new TextBox();
            labelMin_SMA = new Label();
            labelMeanWhichColumn_SMA = new Label();
            textBoxMeanWhichColumn_SMA = new TextBox();
            buttonMeanCalculate_SMA = new Button();
            textBoxMean_SMA = new TextBox();
            textBoxSumWhichColumn_SMA = new TextBox();
            labelMean_SMA = new Label();
            buttonSumCalculate_SMA = new Button();
            textBoxSum_SMA = new TextBox();
            labelSumWhichColumn_SMA = new Label();
            buttonCountCalculate_SMA = new Button();
            textBoxCount_SMA = new TextBox();
            labelCount_SMA = new Label();
            labelSum_SMA = new Label();
            groupBoxSorting_SMA = new GroupBox();
            buttonSortDefaultColumn_SMA = new Button();
            textBoxSortWhichColumn_SMA = new TextBox();
            labelSortWhichColumn_SMA = new Label();
            buttonSortAscending_SMA = new Button();
            buttonSortDescending_SMA = new Button();
            textBoxSearchColumn_SMA = new TextBox();
            labelSearchColumn_SMA = new Label();
            buttonClearSearch_SMA = new Button();
            buttonDataSearch_SMA = new Button();
            textBoxSearch_SMA = new TextBox();
            dataGridView_SMA = new DataGridView();
            CarBrand = new DataGridViewTextBoxColumn();
            CarModel = new DataGridViewTextBoxColumn();
            CarWeight = new DataGridViewTextBoxColumn();
            CarPower = new DataGridViewTextBoxColumn();
            CarFuelConsuption = new DataGridViewTextBoxColumn();
            buttonStatisticsClear_SMA = new Button();
            groupBoxControls_SMA.SuspendLayout();
            groupBoxWorkSpace_SMA.SuspendLayout();
            groupBoxStatistics_SMA.SuspendLayout();
            groupBoxSorting_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxControls_SMA
            // 
            groupBoxControls_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxControls_SMA.Controls.Add(buttonSave_SMA);
            groupBoxControls_SMA.Controls.Add(buttonLoad_SMA);
            groupBoxControls_SMA.Location = new Point(2, -3);
            groupBoxControls_SMA.Name = "groupBoxControls_SMA";
            groupBoxControls_SMA.Size = new Size(836, 59);
            groupBoxControls_SMA.TabIndex = 0;
            groupBoxControls_SMA.TabStop = false;
            // 
            // buttonSave_SMA
            // 
            buttonSave_SMA.Location = new Point(110, 15);
            buttonSave_SMA.Name = "buttonSave_SMA";
            buttonSave_SMA.Size = new Size(98, 38);
            buttonSave_SMA.TabIndex = 3;
            buttonSave_SMA.Text = "Сохранить";
            buttonSave_SMA.UseVisualStyleBackColor = true;
            buttonSave_SMA.Click += buttonSave_SMA_Click;
            // 
            // buttonLoad_SMA
            // 
            buttonLoad_SMA.Location = new Point(6, 15);
            buttonLoad_SMA.Name = "buttonLoad_SMA";
            buttonLoad_SMA.Size = new Size(98, 38);
            buttonLoad_SMA.TabIndex = 2;
            buttonLoad_SMA.Text = "Загрузить";
            buttonLoad_SMA.UseVisualStyleBackColor = true;
            buttonLoad_SMA.Click += buttonLoad_SMA_Click;
            // 
            // groupBoxWorkSpace_SMA
            // 
            groupBoxWorkSpace_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxWorkSpace_SMA.Controls.Add(groupBoxStatistics_SMA);
            groupBoxWorkSpace_SMA.Controls.Add(groupBoxSorting_SMA);
            groupBoxWorkSpace_SMA.Controls.Add(textBoxSearchColumn_SMA);
            groupBoxWorkSpace_SMA.Controls.Add(labelSearchColumn_SMA);
            groupBoxWorkSpace_SMA.Controls.Add(buttonClearSearch_SMA);
            groupBoxWorkSpace_SMA.Controls.Add(buttonDataSearch_SMA);
            groupBoxWorkSpace_SMA.Controls.Add(textBoxSearch_SMA);
            groupBoxWorkSpace_SMA.Controls.Add(dataGridView_SMA);
            groupBoxWorkSpace_SMA.Location = new Point(2, 52);
            groupBoxWorkSpace_SMA.Name = "groupBoxWorkSpace_SMA";
            groupBoxWorkSpace_SMA.Size = new Size(836, 463);
            groupBoxWorkSpace_SMA.TabIndex = 1;
            groupBoxWorkSpace_SMA.TabStop = false;
            // 
            // groupBoxStatistics_SMA
            // 
            groupBoxStatistics_SMA.Controls.Add(buttonStatisticsClear_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelMaxWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxMaxWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(buttonMaxCalculate_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxMax_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelMax_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelMinWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxMinWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(buttonMinCalculate_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxMin_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelMin_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelMeanWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxMeanWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(buttonMeanCalculate_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxMean_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxSumWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelMean_SMA);
            groupBoxStatistics_SMA.Controls.Add(buttonSumCalculate_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxSum_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelSumWhichColumn_SMA);
            groupBoxStatistics_SMA.Controls.Add(buttonCountCalculate_SMA);
            groupBoxStatistics_SMA.Controls.Add(textBoxCount_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelCount_SMA);
            groupBoxStatistics_SMA.Controls.Add(labelSum_SMA);
            groupBoxStatistics_SMA.Location = new Point(486, 162);
            groupBoxStatistics_SMA.Name = "groupBoxStatistics_SMA";
            groupBoxStatistics_SMA.Size = new Size(350, 291);
            groupBoxStatistics_SMA.TabIndex = 11;
            groupBoxStatistics_SMA.TabStop = false;
            groupBoxStatistics_SMA.Text = "Элементы статистики";
            // 
            // labelMaxWhichColumn_SMA
            // 
            labelMaxWhichColumn_SMA.AutoSize = true;
            labelMaxWhichColumn_SMA.Location = new Point(173, 268);
            labelMaxWhichColumn_SMA.Name = "labelMaxWhichColumn_SMA";
            labelMaxWhichColumn_SMA.Size = new Size(57, 15);
            labelMaxWhichColumn_SMA.TabIndex = 32;
            labelMaxWhichColumn_SMA.Text = "Столбца:";
            // 
            // textBoxMaxWhichColumn_SMA
            // 
            textBoxMaxWhichColumn_SMA.Location = new Point(235, 265);
            textBoxMaxWhichColumn_SMA.Name = "textBoxMaxWhichColumn_SMA";
            textBoxMaxWhichColumn_SMA.Size = new Size(23, 23);
            textBoxMaxWhichColumn_SMA.TabIndex = 31;
            // 
            // buttonMaxCalculate_SMA
            // 
            buttonMaxCalculate_SMA.Location = new Point(264, 236);
            buttonMaxCalculate_SMA.Name = "buttonMaxCalculate_SMA";
            buttonMaxCalculate_SMA.Size = new Size(75, 23);
            buttonMaxCalculate_SMA.TabIndex = 30;
            buttonMaxCalculate_SMA.Text = "Посчитать";
            buttonMaxCalculate_SMA.UseVisualStyleBackColor = true;
            buttonMaxCalculate_SMA.Click += buttonMaxCalculate_SMA_Click;
            // 
            // textBoxMax_SMA
            // 
            textBoxMax_SMA.Location = new Point(180, 236);
            textBoxMax_SMA.Name = "textBoxMax_SMA";
            textBoxMax_SMA.ReadOnly = true;
            textBoxMax_SMA.Size = new Size(78, 23);
            textBoxMax_SMA.TabIndex = 29;
            textBoxMax_SMA.TextChanged += textBoxMax_SMA_TextChanged;
            // 
            // labelMax_SMA
            // 
            labelMax_SMA.AutoSize = true;
            labelMax_SMA.Location = new Point(32, 240);
            labelMax_SMA.Name = "labelMax_SMA";
            labelMax_SMA.Size = new Size(148, 15);
            labelMax_SMA.TabIndex = 28;
            labelMax_SMA.Text = "Максимальное значение:";
            // 
            // labelMinWhichColumn_SMA
            // 
            labelMinWhichColumn_SMA.AutoSize = true;
            labelMinWhichColumn_SMA.Location = new Point(173, 211);
            labelMinWhichColumn_SMA.Name = "labelMinWhichColumn_SMA";
            labelMinWhichColumn_SMA.Size = new Size(57, 15);
            labelMinWhichColumn_SMA.TabIndex = 27;
            labelMinWhichColumn_SMA.Text = "Столбца:";
            // 
            // textBoxMinWhichColumn_SMA
            // 
            textBoxMinWhichColumn_SMA.Location = new Point(235, 208);
            textBoxMinWhichColumn_SMA.Name = "textBoxMinWhichColumn_SMA";
            textBoxMinWhichColumn_SMA.Size = new Size(23, 23);
            textBoxMinWhichColumn_SMA.TabIndex = 26;
            // 
            // buttonMinCalculate_SMA
            // 
            buttonMinCalculate_SMA.Location = new Point(264, 179);
            buttonMinCalculate_SMA.Name = "buttonMinCalculate_SMA";
            buttonMinCalculate_SMA.Size = new Size(75, 23);
            buttonMinCalculate_SMA.TabIndex = 25;
            buttonMinCalculate_SMA.Text = "Посчитать";
            buttonMinCalculate_SMA.UseVisualStyleBackColor = true;
            buttonMinCalculate_SMA.Click += buttonMinCalculate_SMA_Click;
            // 
            // textBoxMin_SMA
            // 
            textBoxMin_SMA.Location = new Point(180, 179);
            textBoxMin_SMA.Name = "textBoxMin_SMA";
            textBoxMin_SMA.ReadOnly = true;
            textBoxMin_SMA.Size = new Size(78, 23);
            textBoxMin_SMA.TabIndex = 24;
            textBoxMin_SMA.TextChanged += textBoxMin_SMA_TextChanged;
            // 
            // labelMin_SMA
            // 
            labelMin_SMA.AutoSize = true;
            labelMin_SMA.Location = new Point(36, 183);
            labelMin_SMA.Name = "labelMin_SMA";
            labelMin_SMA.Size = new Size(144, 15);
            labelMin_SMA.TabIndex = 23;
            labelMin_SMA.Text = "Минимальное значение:";
            // 
            // labelMeanWhichColumn_SMA
            // 
            labelMeanWhichColumn_SMA.AutoSize = true;
            labelMeanWhichColumn_SMA.Location = new Point(173, 153);
            labelMeanWhichColumn_SMA.Name = "labelMeanWhichColumn_SMA";
            labelMeanWhichColumn_SMA.Size = new Size(57, 15);
            labelMeanWhichColumn_SMA.TabIndex = 22;
            labelMeanWhichColumn_SMA.Text = "Столбца:";
            // 
            // textBoxMeanWhichColumn_SMA
            // 
            textBoxMeanWhichColumn_SMA.Location = new Point(235, 150);
            textBoxMeanWhichColumn_SMA.Name = "textBoxMeanWhichColumn_SMA";
            textBoxMeanWhichColumn_SMA.Size = new Size(23, 23);
            textBoxMeanWhichColumn_SMA.TabIndex = 21;
            // 
            // buttonMeanCalculate_SMA
            // 
            buttonMeanCalculate_SMA.Location = new Point(264, 121);
            buttonMeanCalculate_SMA.Name = "buttonMeanCalculate_SMA";
            buttonMeanCalculate_SMA.Size = new Size(75, 23);
            buttonMeanCalculate_SMA.TabIndex = 20;
            buttonMeanCalculate_SMA.Text = "Посчитать";
            buttonMeanCalculate_SMA.UseVisualStyleBackColor = true;
            buttonMeanCalculate_SMA.Click += buttonMeanCalculate_SMA_Click;
            // 
            // textBoxMean_SMA
            // 
            textBoxMean_SMA.Location = new Point(178, 121);
            textBoxMean_SMA.Name = "textBoxMean_SMA";
            textBoxMean_SMA.ReadOnly = true;
            textBoxMean_SMA.Size = new Size(80, 23);
            textBoxMean_SMA.TabIndex = 18;
            textBoxMean_SMA.TextChanged += textBoxMean_SMA_TextChanged;
            // 
            // textBoxSumWhichColumn_SMA
            // 
            textBoxSumWhichColumn_SMA.Location = new Point(235, 91);
            textBoxSumWhichColumn_SMA.Name = "textBoxSumWhichColumn_SMA";
            textBoxSumWhichColumn_SMA.Size = new Size(23, 23);
            textBoxSumWhichColumn_SMA.TabIndex = 17;
            // 
            // labelMean_SMA
            // 
            labelMean_SMA.AutoSize = true;
            labelMean_SMA.Location = new Point(62, 125);
            labelMean_SMA.Name = "labelMean_SMA";
            labelMean_SMA.Size = new Size(110, 15);
            labelMean_SMA.TabIndex = 15;
            labelMean_SMA.Text = "Среднее значение:";
            // 
            // buttonSumCalculate_SMA
            // 
            buttonSumCalculate_SMA.Location = new Point(264, 62);
            buttonSumCalculate_SMA.Name = "buttonSumCalculate_SMA";
            buttonSumCalculate_SMA.Size = new Size(75, 23);
            buttonSumCalculate_SMA.TabIndex = 15;
            buttonSumCalculate_SMA.Text = "Посчитать";
            buttonSumCalculate_SMA.UseVisualStyleBackColor = true;
            buttonSumCalculate_SMA.Click += buttonSumCalculate_SMA_Click;
            // 
            // textBoxSum_SMA
            // 
            textBoxSum_SMA.Location = new Point(178, 62);
            textBoxSum_SMA.Name = "textBoxSum_SMA";
            textBoxSum_SMA.ReadOnly = true;
            textBoxSum_SMA.Size = new Size(80, 23);
            textBoxSum_SMA.TabIndex = 14;
            textBoxSum_SMA.TextChanged += textBoxSum_SMA_TextChanged;
            // 
            // labelSumWhichColumn_SMA
            // 
            labelSumWhichColumn_SMA.AutoSize = true;
            labelSumWhichColumn_SMA.Location = new Point(178, 94);
            labelSumWhichColumn_SMA.Name = "labelSumWhichColumn_SMA";
            labelSumWhichColumn_SMA.Size = new Size(57, 15);
            labelSumWhichColumn_SMA.TabIndex = 14;
            labelSumWhichColumn_SMA.Text = "Столбца:";
            // 
            // buttonCountCalculate_SMA
            // 
            buttonCountCalculate_SMA.Location = new Point(264, 25);
            buttonCountCalculate_SMA.Name = "buttonCountCalculate_SMA";
            buttonCountCalculate_SMA.Size = new Size(75, 24);
            buttonCountCalculate_SMA.TabIndex = 13;
            buttonCountCalculate_SMA.Text = "Посчитать";
            buttonCountCalculate_SMA.UseVisualStyleBackColor = true;
            buttonCountCalculate_SMA.Click += buttonCountCalculate_SMA_Click;
            // 
            // textBoxCount_SMA
            // 
            textBoxCount_SMA.Location = new Point(235, 26);
            textBoxCount_SMA.Name = "textBoxCount_SMA";
            textBoxCount_SMA.ReadOnly = true;
            textBoxCount_SMA.Size = new Size(23, 23);
            textBoxCount_SMA.TabIndex = 11;
            textBoxCount_SMA.TextChanged += textBoxCount_SMA_TextChanged;
            // 
            // labelCount_SMA
            // 
            labelCount_SMA.AutoSize = true;
            labelCount_SMA.Location = new Point(100, 29);
            labelCount_SMA.Name = "labelCount_SMA";
            labelCount_SMA.Size = new Size(137, 15);
            labelCount_SMA.TabIndex = 12;
            labelCount_SMA.Text = "Количество элементов:";
            // 
            // labelSum_SMA
            // 
            labelSum_SMA.AutoSize = true;
            labelSum_SMA.Location = new Point(124, 66);
            labelSum_SMA.Name = "labelSum_SMA";
            labelSum_SMA.Size = new Size(48, 15);
            labelSum_SMA.TabIndex = 13;
            labelSum_SMA.Text = "Сумма:";
            // 
            // groupBoxSorting_SMA
            // 
            groupBoxSorting_SMA.Controls.Add(buttonSortDefaultColumn_SMA);
            groupBoxSorting_SMA.Controls.Add(textBoxSortWhichColumn_SMA);
            groupBoxSorting_SMA.Controls.Add(labelSortWhichColumn_SMA);
            groupBoxSorting_SMA.Controls.Add(buttonSortAscending_SMA);
            groupBoxSorting_SMA.Controls.Add(buttonSortDescending_SMA);
            groupBoxSorting_SMA.Location = new Point(486, 43);
            groupBoxSorting_SMA.Name = "groupBoxSorting_SMA";
            groupBoxSorting_SMA.Size = new Size(350, 113);
            groupBoxSorting_SMA.TabIndex = 8;
            groupBoxSorting_SMA.TabStop = false;
            groupBoxSorting_SMA.Text = "Сортировка";
            // 
            // buttonSortDefaultColumn_SMA
            // 
            buttonSortDefaultColumn_SMA.Location = new Point(181, 84);
            buttonSortDefaultColumn_SMA.Name = "buttonSortDefaultColumn_SMA";
            buttonSortDefaultColumn_SMA.Size = new Size(158, 24);
            buttonSortDefaultColumn_SMA.TabIndex = 10;
            buttonSortDefaultColumn_SMA.Text = "Столбец о умолчанию";
            buttonSortDefaultColumn_SMA.UseVisualStyleBackColor = true;
            buttonSortDefaultColumn_SMA.Click += buttonSortDefaultColumn_SMA_Click;
            // 
            // textBoxSortWhichColumn_SMA
            // 
            textBoxSortWhichColumn_SMA.Location = new Point(317, 60);
            textBoxSortWhichColumn_SMA.Name = "textBoxSortWhichColumn_SMA";
            textBoxSortWhichColumn_SMA.Size = new Size(23, 23);
            textBoxSortWhichColumn_SMA.TabIndex = 9;
            // 
            // labelSortWhichColumn_SMA
            // 
            labelSortWhichColumn_SMA.AutoSize = true;
            labelSortWhichColumn_SMA.Location = new Point(182, 63);
            labelSortWhichColumn_SMA.Name = "labelSortWhichColumn_SMA";
            labelSortWhichColumn_SMA.Size = new Size(135, 15);
            labelSortWhichColumn_SMA.TabIndex = 4;
            labelSortWhichColumn_SMA.Text = "По убыванию столбца:";
            // 
            // buttonSortAscending_SMA
            // 
            buttonSortAscending_SMA.Location = new Point(117, 22);
            buttonSortAscending_SMA.Name = "buttonSortAscending_SMA";
            buttonSortAscending_SMA.Size = new Size(107, 36);
            buttonSortAscending_SMA.TabIndex = 3;
            buttonSortAscending_SMA.Text = "По возрастанию";
            buttonSortAscending_SMA.UseVisualStyleBackColor = true;
            buttonSortAscending_SMA.Click += buttonSortAscending_SMA_Click;
            // 
            // buttonSortDescending_SMA
            // 
            buttonSortDescending_SMA.Location = new Point(6, 22);
            buttonSortDescending_SMA.Name = "buttonSortDescending_SMA";
            buttonSortDescending_SMA.Size = new Size(105, 36);
            buttonSortDescending_SMA.TabIndex = 2;
            buttonSortDescending_SMA.Text = "По убыванию";
            buttonSortDescending_SMA.UseVisualStyleBackColor = true;
            buttonSortDescending_SMA.Click += buttonSortDescending_SMA_Click;
            // 
            // textBoxSearchColumn_SMA
            // 
            textBoxSearchColumn_SMA.Location = new Point(433, 15);
            textBoxSearchColumn_SMA.Name = "textBoxSearchColumn_SMA";
            textBoxSearchColumn_SMA.Size = new Size(23, 23);
            textBoxSearchColumn_SMA.TabIndex = 7;
            // 
            // labelSearchColumn_SMA
            // 
            labelSearchColumn_SMA.AutoSize = true;
            labelSearchColumn_SMA.Location = new Point(318, 18);
            labelSearchColumn_SMA.Name = "labelSearchColumn_SMA";
            labelSearchColumn_SMA.Size = new Size(113, 15);
            labelSearchColumn_SMA.TabIndex = 6;
            labelSearchColumn_SMA.Text = "Искать по столбцу:";
            // 
            // buttonClearSearch_SMA
            // 
            buttonClearSearch_SMA.Location = new Point(210, 14);
            buttonClearSearch_SMA.Name = "buttonClearSearch_SMA";
            buttonClearSearch_SMA.Size = new Size(23, 23);
            buttonClearSearch_SMA.TabIndex = 5;
            buttonClearSearch_SMA.Text = "X";
            buttonClearSearch_SMA.UseVisualStyleBackColor = true;
            buttonClearSearch_SMA.Click += buttonClearSearch_SMA_Click;
            // 
            // buttonDataSearch_SMA
            // 
            buttonDataSearch_SMA.Location = new Point(239, 13);
            buttonDataSearch_SMA.Name = "buttonDataSearch_SMA";
            buttonDataSearch_SMA.Size = new Size(75, 23);
            buttonDataSearch_SMA.TabIndex = 4;
            buttonDataSearch_SMA.Text = "Поиск";
            buttonDataSearch_SMA.UseVisualStyleBackColor = true;
            buttonDataSearch_SMA.Click += buttonDataSearch_SMA_Click;
            // 
            // textBoxSearch_SMA
            // 
            textBoxSearch_SMA.Location = new Point(6, 14);
            textBoxSearch_SMA.Name = "textBoxSearch_SMA";
            textBoxSearch_SMA.Size = new Size(198, 23);
            textBoxSearch_SMA.TabIndex = 3;
            // 
            // dataGridView_SMA
            // 
            dataGridView_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SMA.Columns.AddRange(new DataGridViewColumn[] { CarBrand, CarModel, CarWeight, CarPower, CarFuelConsuption });
            dataGridView_SMA.Location = new Point(6, 43);
            dataGridView_SMA.Name = "dataGridView_SMA";
            dataGridView_SMA.RowHeadersVisible = false;
            dataGridView_SMA.Size = new Size(474, 410);
            dataGridView_SMA.TabIndex = 2;
            // 
            // CarBrand
            // 
            CarBrand.HeaderText = "Марка";
            CarBrand.Name = "CarBrand";
            CarBrand.Width = 70;
            // 
            // CarModel
            // 
            CarModel.HeaderText = "Модель";
            CarModel.Name = "CarModel";
            // 
            // CarWeight
            // 
            CarWeight.HeaderText = "Вес (кг)";
            CarWeight.Name = "CarWeight";
            // 
            // CarPower
            // 
            CarPower.HeaderText = "Мощность (л.с.)";
            CarPower.Name = "CarPower";
            // 
            // CarFuelConsuption
            // 
            CarFuelConsuption.HeaderText = "Расход топлива (л. на 100 км.)";
            CarFuelConsuption.Name = "CarFuelConsuption";
            // 
            // buttonStatisticsClear_SMA
            // 
            buttonStatisticsClear_SMA.Location = new Point(8, 25);
            buttonStatisticsClear_SMA.Name = "buttonStatisticsClear_SMA";
            buttonStatisticsClear_SMA.Size = new Size(75, 23);
            buttonStatisticsClear_SMA.TabIndex = 2;
            buttonStatisticsClear_SMA.Text = "Очистить";
            buttonStatisticsClear_SMA.UseVisualStyleBackColor = true;
            buttonStatisticsClear_SMA.Click += buttonStatisticsClear_SMA_Click;
            // 
            // FormEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 517);
            Controls.Add(groupBoxWorkSpace_SMA);
            Controls.Add(groupBoxControls_SMA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormEditor";
            Text = "Редактор баз";
            groupBoxControls_SMA.ResumeLayout(false);
            groupBoxWorkSpace_SMA.ResumeLayout(false);
            groupBoxWorkSpace_SMA.PerformLayout();
            groupBoxStatistics_SMA.ResumeLayout(false);
            groupBoxStatistics_SMA.PerformLayout();
            groupBoxSorting_SMA.ResumeLayout(false);
            groupBoxSorting_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxControls_SMA;
        private Button buttonLoad_SMA;
        private GroupBox groupBoxWorkSpace_SMA;
        private Button buttonSave_SMA;
        private DataGridView dataGridView_SMA;
        private TextBox textBoxSearch_SMA;
        private Button buttonDataSearch_SMA;
        private Button buttonClearSearch_SMA;
        private Label labelSearchColumn_SMA;
        private TextBox textBoxSearchColumn_SMA;
        private GroupBox groupBoxSorting_SMA;
        private Button buttonSortDefaultColumn_SMA;
        private TextBox textBoxSortWhichColumn_SMA;
        private Label labelSortWhichColumn_SMA;
        private Button buttonSortAscending_SMA;
        private Button buttonSortDescending_SMA;
        private GroupBox groupBoxStatistics_SMA;
        private Label labelMean_SMA;
        private Label labelSumWhichColumn_SMA;
        private Label labelSum_SMA;
        private Label labelCount_SMA;
        private Button buttonSumCalculate_SMA;
        private TextBox textBoxSum_SMA;
        private Button buttonCountCalculate_SMA;
        private TextBox textBoxCount_SMA;
        private TextBox textBoxMeanWhichColumn_SMA;
        private Button buttonMeanCalculate_SMA;
        private TextBox textBoxMean_SMA;
        private TextBox textBoxSumWhichColumn_SMA;
        private Label labelMeanWhichColumn_SMA;
        private Label labelMaxWhichColumn_SMA;
        private TextBox textBoxMaxWhichColumn_SMA;
        private Button buttonMaxCalculate_SMA;
        private TextBox textBoxMax_SMA;
        private Label labelMax_SMA;
        private Label labelMinWhichColumn_SMA;
        private TextBox textBoxMinWhichColumn_SMA;
        private Button buttonMinCalculate_SMA;
        private TextBox textBoxMin_SMA;
        private Label labelMin_SMA;
        private DataGridViewTextBoxColumn CarBrand;
        private DataGridViewTextBoxColumn CarModel;
        private DataGridViewTextBoxColumn CarWeight;
        private DataGridViewTextBoxColumn CarPower;
        private DataGridViewTextBoxColumn CarFuelConsuption;
        private Button buttonStatisticsClear_SMA;
    }
}