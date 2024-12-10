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
            textBoxSearchColumn_SMA = new TextBox();
            labelSearchColumn_SMA = new Label();
            buttonClearSearch_SMA = new Button();
            buttonDataSearch_SMA = new Button();
            textBoxSearch_SMA = new TextBox();
            dataGridView_SMA = new DataGridView();
            buttonSortDescending_SMA = new Button();
            buttonSortAscending_SMA = new Button();
            labelSortWhichColumn_SMA = new Label();
            textBoxSortWhichColumn_SMA = new TextBox();
            buttonSortDefaultColumn_SMA = new Button();
            groupBoxSorting_SMA = new GroupBox();
            groupBoxStatistics_SMA = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBoxControls_SMA.SuspendLayout();
            groupBoxWorkSpace_SMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).BeginInit();
            groupBoxSorting_SMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxControls_SMA
            // 
            groupBoxControls_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxControls_SMA.Controls.Add(buttonSave_SMA);
            groupBoxControls_SMA.Controls.Add(buttonLoad_SMA);
            groupBoxControls_SMA.Location = new Point(2, -3);
            groupBoxControls_SMA.Name = "groupBoxControls_SMA";
            groupBoxControls_SMA.Size = new Size(796, 59);
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
            // 
            // buttonLoad_SMA
            // 
            buttonLoad_SMA.Location = new Point(6, 15);
            buttonLoad_SMA.Name = "buttonLoad_SMA";
            buttonLoad_SMA.Size = new Size(98, 38);
            buttonLoad_SMA.TabIndex = 2;
            buttonLoad_SMA.Text = "Загрузить";
            buttonLoad_SMA.UseVisualStyleBackColor = true;
            // 
            // groupBoxWorkSpace_SMA
            // 
            groupBoxWorkSpace_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxWorkSpace_SMA.Controls.Add(label5);
            groupBoxWorkSpace_SMA.Controls.Add(label4);
            groupBoxWorkSpace_SMA.Controls.Add(label3);
            groupBoxWorkSpace_SMA.Controls.Add(label2);
            groupBoxWorkSpace_SMA.Controls.Add(label1);
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
            groupBoxWorkSpace_SMA.Size = new Size(796, 463);
            groupBoxWorkSpace_SMA.TabIndex = 1;
            groupBoxWorkSpace_SMA.TabStop = false;
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
            // 
            // buttonDataSearch_SMA
            // 
            buttonDataSearch_SMA.Location = new Point(239, 13);
            buttonDataSearch_SMA.Name = "buttonDataSearch_SMA";
            buttonDataSearch_SMA.Size = new Size(75, 23);
            buttonDataSearch_SMA.TabIndex = 4;
            buttonDataSearch_SMA.Text = "Поиск";
            buttonDataSearch_SMA.UseVisualStyleBackColor = true;
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
            dataGridView_SMA.Location = new Point(6, 43);
            dataGridView_SMA.Name = "dataGridView_SMA";
            dataGridView_SMA.Size = new Size(308, 410);
            dataGridView_SMA.TabIndex = 2;
            // 
            // buttonSortDescending_SMA
            // 
            buttonSortDescending_SMA.Location = new Point(6, 22);
            buttonSortDescending_SMA.Name = "buttonSortDescending_SMA";
            buttonSortDescending_SMA.Size = new Size(105, 36);
            buttonSortDescending_SMA.TabIndex = 2;
            buttonSortDescending_SMA.Text = "По убыванию";
            buttonSortDescending_SMA.UseVisualStyleBackColor = true;
            // 
            // buttonSortAscending_SMA
            // 
            buttonSortAscending_SMA.Location = new Point(113, 22);
            buttonSortAscending_SMA.Name = "buttonSortAscending_SMA";
            buttonSortAscending_SMA.Size = new Size(107, 36);
            buttonSortAscending_SMA.TabIndex = 3;
            buttonSortAscending_SMA.Text = "По возрастанию";
            buttonSortAscending_SMA.UseVisualStyleBackColor = true;
            // 
            // labelSortWhichColumn_SMA
            // 
            labelSortWhichColumn_SMA.AutoSize = true;
            labelSortWhichColumn_SMA.Location = new Point(6, 64);
            labelSortWhichColumn_SMA.Name = "labelSortWhichColumn_SMA";
            labelSortWhichColumn_SMA.Size = new Size(135, 15);
            labelSortWhichColumn_SMA.TabIndex = 4;
            labelSortWhichColumn_SMA.Text = "По убыванию столбца:";
            // 
            // textBoxSortWhichColumn_SMA
            // 
            textBoxSortWhichColumn_SMA.Location = new Point(141, 61);
            textBoxSortWhichColumn_SMA.Name = "textBoxSortWhichColumn_SMA";
            textBoxSortWhichColumn_SMA.Size = new Size(23, 23);
            textBoxSortWhichColumn_SMA.TabIndex = 9;
            // 
            // buttonSortDefaultColumn_SMA
            // 
            buttonSortDefaultColumn_SMA.Location = new Point(6, 82);
            buttonSortDefaultColumn_SMA.Name = "buttonSortDefaultColumn_SMA";
            buttonSortDefaultColumn_SMA.Size = new Size(103, 24);
            buttonSortDefaultColumn_SMA.TabIndex = 10;
            buttonSortDefaultColumn_SMA.Text = "По умолчанию";
            buttonSortDefaultColumn_SMA.UseVisualStyleBackColor = true;
            // 
            // groupBoxSorting_SMA
            // 
            groupBoxSorting_SMA.Controls.Add(buttonSortDefaultColumn_SMA);
            groupBoxSorting_SMA.Controls.Add(textBoxSortWhichColumn_SMA);
            groupBoxSorting_SMA.Controls.Add(labelSortWhichColumn_SMA);
            groupBoxSorting_SMA.Controls.Add(buttonSortAscending_SMA);
            groupBoxSorting_SMA.Controls.Add(buttonSortDescending_SMA);
            groupBoxSorting_SMA.Location = new Point(320, 43);
            groupBoxSorting_SMA.Name = "groupBoxSorting_SMA";
            groupBoxSorting_SMA.Size = new Size(228, 113);
            groupBoxSorting_SMA.TabIndex = 8;
            groupBoxSorting_SMA.TabStop = false;
            groupBoxSorting_SMA.Text = "Сортировка";
            // 
            // groupBoxStatistics_SMA
            // 
            groupBoxStatistics_SMA.Location = new Point(320, 162);
            groupBoxStatistics_SMA.Name = "groupBoxStatistics_SMA";
            groupBoxStatistics_SMA.Size = new Size(470, 291);
            groupBoxStatistics_SMA.TabIndex = 11;
            groupBoxStatistics_SMA.TabStop = false;
            groupBoxStatistics_SMA.Text = "Элементы статистики";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(686, 112);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(698, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(698, 27);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 14;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(636, 43);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 65);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // FormEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(groupBoxWorkSpace_SMA);
            Controls.Add(groupBoxControls_SMA);
            MinimumSize = new Size(816, 556);
            Name = "FormEditor";
            Text = "Редактор баз";
            groupBoxControls_SMA.ResumeLayout(false);
            groupBoxWorkSpace_SMA.ResumeLayout(false);
            groupBoxWorkSpace_SMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).EndInit();
            groupBoxSorting_SMA.ResumeLayout(false);
            groupBoxSorting_SMA.PerformLayout();
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}