namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    partial class FormGraphDrawer
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonLoadFile_SMA = new Button();
            buttonDrawGraph_SMA = new Button();
            groupBox2 = new GroupBox();
            chartDataGraph_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_SMA = new DataGridView();
            Speed = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            buttonClear_SMA = new Button();
            toolTipDrawer_SMA = new ToolTip(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDataGraph_SMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).BeginInit();
            SuspendLayout();
            // 
            // buttonLoadFile_SMA
            // 
            buttonLoadFile_SMA.Location = new Point(12, 12);
            buttonLoadFile_SMA.Name = "buttonLoadFile_SMA";
            buttonLoadFile_SMA.Size = new Size(98, 38);
            buttonLoadFile_SMA.TabIndex = 0;
            buttonLoadFile_SMA.Text = "Загрузить";
            toolTipDrawer_SMA.SetToolTip(buttonLoadFile_SMA, "Загрузить файл.");
            buttonLoadFile_SMA.UseVisualStyleBackColor = true;
            buttonLoadFile_SMA.Click += buttonLoadFile_SMA_Click;
            // 
            // buttonDrawGraph_SMA
            // 
            buttonDrawGraph_SMA.Location = new Point(220, 12);
            buttonDrawGraph_SMA.Name = "buttonDrawGraph_SMA";
            buttonDrawGraph_SMA.Size = new Size(98, 38);
            buttonDrawGraph_SMA.TabIndex = 2;
            buttonDrawGraph_SMA.Text = "Нарисовать график";
            toolTipDrawer_SMA.SetToolTip(buttonDrawGraph_SMA, "Нарисовать график по данным с базы данных.");
            buttonDrawGraph_SMA.UseVisualStyleBackColor = true;
            buttonDrawGraph_SMA.Click += buttonDrawGraph_SMA_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(chartDataGraph_SMA);
            groupBox2.Controls.Add(dataGridView_SMA);
            groupBox2.Location = new Point(4, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(703, 367);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // chartDataGraph_SMA
            // 
            chartDataGraph_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartDataGraph_SMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDataGraph_SMA.Legends.Add(legend1);
            chartDataGraph_SMA.Location = new Point(216, 15);
            chartDataGraph_SMA.Name = "chartDataGraph_SMA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDataGraph_SMA.Series.Add(series1);
            chartDataGraph_SMA.Size = new Size(479, 344);
            chartDataGraph_SMA.TabIndex = 4;
            chartDataGraph_SMA.Text = "chart1";
            // 
            // dataGridView_SMA
            // 
            dataGridView_SMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_SMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SMA.Columns.AddRange(new DataGridViewColumn[] { Speed, Time });
            dataGridView_SMA.Location = new Point(6, 15);
            dataGridView_SMA.Name = "dataGridView_SMA";
            dataGridView_SMA.RowHeadersVisible = false;
            dataGridView_SMA.Size = new Size(204, 344);
            dataGridView_SMA.TabIndex = 3;
            // 
            // Speed
            // 
            Speed.HeaderText = "Скорость (км/ч)";
            Speed.Name = "Speed";
            Speed.ReadOnly = true;
            // 
            // Time
            // 
            Time.HeaderText = "Время (мин)";
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // buttonClear_SMA
            // 
            buttonClear_SMA.Location = new Point(116, 12);
            buttonClear_SMA.Name = "buttonClear_SMA";
            buttonClear_SMA.Size = new Size(98, 38);
            buttonClear_SMA.TabIndex = 1;
            buttonClear_SMA.Text = "Очистить";
            toolTipDrawer_SMA.SetToolTip(buttonClear_SMA, "Очистить базу данных.");
            buttonClear_SMA.UseVisualStyleBackColor = true;
            buttonClear_SMA.Click += buttonClear_SMA_Click;
            // 
            // FormGraphDrawer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 427);
            Controls.Add(groupBox2);
            Controls.Add(buttonDrawGraph_SMA);
            Controls.Add(buttonClear_SMA);
            Controls.Add(buttonLoadFile_SMA);
            MaximizeBox = false;
            MinimumSize = new Size(532, 368);
            Name = "FormGraphDrawer";
            Text = "График скорости/времени";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDataGraph_SMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoadFile_SMA;
        private Button buttonDrawGraph_SMA;
        private GroupBox groupBox2;
        private DataGridView dataGridView_SMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataGraph_SMA;
        private Button buttonClear_SMA;
        private DataGridViewTextBoxColumn Speed;
        private DataGridViewTextBoxColumn Time;
        private ToolTip toolTipDrawer_SMA;
    }
}