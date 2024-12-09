namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    partial class FormFuelCalculate
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
            textBoxFuelConsumed_SMA = new TextBox();
            textBoxKilometersRode_SMA = new TextBox();
            textBoxFuelPrice_SMA = new TextBox();
            labelFuelPrice_SMA = new Label();
            labelKilometersRode_SMA = new Label();
            labelFuelConsumed_SMA = new Label();
            labelProgramName_SMA = new Label();
            buttonCalculate_SMA = new Button();
            labelResult_SMA = new Label();
            labelResultPrice_SMA = new Label();
            textBoxResult_SMA = new TextBox();
            textBoxResultPrice_SMA = new TextBox();
            SuspendLayout();
            // 
            // textBoxFuelConsumed_SMA
            // 
            textBoxFuelConsumed_SMA.Anchor = AnchorStyles.Top;
            textBoxFuelConsumed_SMA.Location = new Point(12, 96);
            textBoxFuelConsumed_SMA.Name = "textBoxFuelConsumed_SMA";
            textBoxFuelConsumed_SMA.Size = new Size(274, 23);
            textBoxFuelConsumed_SMA.TabIndex = 0;
            textBoxFuelConsumed_SMA.TextChanged += textBoxFuelConsumed_SMA_TextChanged;
            textBoxFuelConsumed_SMA.KeyPress += textBoxFuelConsumed_SMA_KeyPress;
            // 
            // textBoxKilometersRode_SMA
            // 
            textBoxKilometersRode_SMA.Anchor = AnchorStyles.Top;
            textBoxKilometersRode_SMA.Location = new Point(12, 140);
            textBoxKilometersRode_SMA.Name = "textBoxKilometersRode_SMA";
            textBoxKilometersRode_SMA.Size = new Size(274, 23);
            textBoxKilometersRode_SMA.TabIndex = 1;
            textBoxKilometersRode_SMA.KeyPress += textBoxKilometersRode_SMA_KeyPress;
            // 
            // textBoxFuelPrice_SMA
            // 
            textBoxFuelPrice_SMA.Anchor = AnchorStyles.Top;
            textBoxFuelPrice_SMA.Location = new Point(12, 184);
            textBoxFuelPrice_SMA.Name = "textBoxFuelPrice_SMA";
            textBoxFuelPrice_SMA.Size = new Size(274, 23);
            textBoxFuelPrice_SMA.TabIndex = 2;
            textBoxFuelPrice_SMA.KeyPress += textBoxFuelPrice_SMA_KeyPress;
            // 
            // labelFuelPrice_SMA
            // 
            labelFuelPrice_SMA.Anchor = AnchorStyles.Top;
            labelFuelPrice_SMA.AutoSize = true;
            labelFuelPrice_SMA.Location = new Point(12, 166);
            labelFuelPrice_SMA.Name = "labelFuelPrice_SMA";
            labelFuelPrice_SMA.Size = new Size(144, 15);
            labelFuelPrice_SMA.TabIndex = 3;
            labelFuelPrice_SMA.Text = "Цена топлива (руб. за л.)";
            // 
            // labelKilometersRode_SMA
            // 
            labelKilometersRode_SMA.Anchor = AnchorStyles.Top;
            labelKilometersRode_SMA.AutoSize = true;
            labelKilometersRode_SMA.Location = new Point(12, 122);
            labelKilometersRode_SMA.Name = "labelKilometersRode_SMA";
            labelKilometersRode_SMA.Size = new Size(168, 15);
            labelKilometersRode_SMA.TabIndex = 4;
            labelKilometersRode_SMA.Text = "Пройденное расстояние (км)";
            // 
            // labelFuelConsumed_SMA
            // 
            labelFuelConsumed_SMA.Anchor = AnchorStyles.Top;
            labelFuelConsumed_SMA.AutoSize = true;
            labelFuelConsumed_SMA.Location = new Point(12, 78);
            labelFuelConsumed_SMA.Name = "labelFuelConsumed_SMA";
            labelFuelConsumed_SMA.Size = new Size(110, 15);
            labelFuelConsumed_SMA.TabIndex = 5;
            labelFuelConsumed_SMA.Text = "Израсходовано (л)";
            // 
            // labelProgramName_SMA
            // 
            labelProgramName_SMA.Anchor = AnchorStyles.Top;
            labelProgramName_SMA.AutoSize = true;
            labelProgramName_SMA.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelProgramName_SMA.Location = new Point(16, 29);
            labelProgramName_SMA.Name = "labelProgramName_SMA";
            labelProgramName_SMA.Size = new Size(273, 20);
            labelProgramName_SMA.TabIndex = 6;
            labelProgramName_SMA.Text = "Калькулятор расхода топлива на км";
            // 
            // buttonCalculate_SMA
            // 
            buttonCalculate_SMA.Anchor = AnchorStyles.Top;
            buttonCalculate_SMA.Location = new Point(12, 222);
            buttonCalculate_SMA.Name = "buttonCalculate_SMA";
            buttonCalculate_SMA.Size = new Size(274, 43);
            buttonCalculate_SMA.TabIndex = 7;
            buttonCalculate_SMA.Text = "Рассчитать расход";
            buttonCalculate_SMA.UseVisualStyleBackColor = true;
            buttonCalculate_SMA.Click += buttonCalculate_SMA_Click;
            // 
            // labelResult_SMA
            // 
            labelResult_SMA.Anchor = AnchorStyles.Bottom;
            labelResult_SMA.AutoSize = true;
            labelResult_SMA.Location = new Point(98, 282);
            labelResult_SMA.Name = "labelResult_SMA";
            labelResult_SMA.Size = new Size(96, 15);
            labelResult_SMA.TabIndex = 8;
            labelResult_SMA.Text = "Средний расход";
            // 
            // labelResultPrice_SMA
            // 
            labelResultPrice_SMA.Anchor = AnchorStyles.Bottom;
            labelResultPrice_SMA.AutoSize = true;
            labelResultPrice_SMA.Location = new Point(70, 340);
            labelResultPrice_SMA.Name = "labelResultPrice_SMA";
            labelResultPrice_SMA.Size = new Size(155, 15);
            labelResultPrice_SMA.TabIndex = 9;
            labelResultPrice_SMA.Text = "Общая стоимость топлива";
            labelResultPrice_SMA.Click += label5_Click_1;
            // 
            // textBoxResult_SMA
            // 
            textBoxResult_SMA.Anchor = AnchorStyles.Bottom;
            textBoxResult_SMA.Location = new Point(96, 300);
            textBoxResult_SMA.Name = "textBoxResult_SMA";
            textBoxResult_SMA.ReadOnly = true;
            textBoxResult_SMA.Size = new Size(100, 23);
            textBoxResult_SMA.TabIndex = 10;
            textBoxResult_SMA.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResultPrice_SMA
            // 
            textBoxResultPrice_SMA.Anchor = AnchorStyles.Bottom;
            textBoxResultPrice_SMA.Location = new Point(96, 358);
            textBoxResultPrice_SMA.Name = "textBoxResultPrice_SMA";
            textBoxResultPrice_SMA.ReadOnly = true;
            textBoxResultPrice_SMA.Size = new Size(100, 23);
            textBoxResultPrice_SMA.TabIndex = 11;
            textBoxResultPrice_SMA.TextAlign = HorizontalAlignment.Center;
            // 
            // FormFuelCalculate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 405);
            Controls.Add(textBoxResultPrice_SMA);
            Controls.Add(textBoxResult_SMA);
            Controls.Add(labelResultPrice_SMA);
            Controls.Add(labelResult_SMA);
            Controls.Add(buttonCalculate_SMA);
            Controls.Add(labelProgramName_SMA);
            Controls.Add(labelFuelConsumed_SMA);
            Controls.Add(labelKilometersRode_SMA);
            Controls.Add(labelFuelPrice_SMA);
            Controls.Add(textBoxFuelPrice_SMA);
            Controls.Add(textBoxKilometersRode_SMA);
            Controls.Add(textBoxFuelConsumed_SMA);
            MaximizeBox = false;
            MaximumSize = new Size(541, 517);
            MinimumSize = new Size(314, 444);
            Name = "FormFuelCalculate";
            Text = "Калькулятор расхода топлива";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFuelConsumed_SMA;
        private TextBox textBoxKilometersRode_SMA;
        private TextBox textBoxFuelPrice_SMA;
        private Label labelFuelPrice_SMA;
        private Label labelKilometersRode_SMA;
        private Label labelFuelConsumed_SMA;
        private Label labelProgramName_SMA;
        private Button buttonCalculate_SMA;
        private Label labelResult_SMA;
        private Label labelResultPrice_SMA;
        private TextBox textBoxResult_SMA;
        private TextBox textBoxResultPrice_SMA;
    }
}