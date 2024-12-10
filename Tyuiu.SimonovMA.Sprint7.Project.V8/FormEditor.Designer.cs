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
            buttonDataSearch_SMA = new Button();
            textBoxSearch_SMA = new TextBox();
            dataGridView_SMA = new DataGridView();
            buttonClearSearch_SMA = new Button();
            labelSearchColumn_SMA = new Label();
            textBoxSearchColumn_SMA = new TextBox();
            groupBoxControls_SMA.SuspendLayout();
            groupBoxWorkSpace_SMA.SuspendLayout();
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
            // buttonClearSearch_SMA
            // 
            buttonClearSearch_SMA.Location = new Point(210, 14);
            buttonClearSearch_SMA.Name = "buttonClearSearch_SMA";
            buttonClearSearch_SMA.Size = new Size(23, 23);
            buttonClearSearch_SMA.TabIndex = 5;
            buttonClearSearch_SMA.Text = "X";
            buttonClearSearch_SMA.UseVisualStyleBackColor = true;
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
            // textBoxSearchColumn_SMA
            // 
            textBoxSearchColumn_SMA.Location = new Point(437, 15);
            textBoxSearchColumn_SMA.Name = "textBoxSearchColumn_SMA";
            textBoxSearchColumn_SMA.Size = new Size(23, 23);
            textBoxSearchColumn_SMA.TabIndex = 7;
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
    }
}