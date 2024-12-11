namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAbout_SMA = new Button();
            labelName_SMA = new Label();
            buttonCalculator_SMA = new Button();
            buttonEditor_SMA = new Button();
            buttonSpeedTime_SMA = new Button();
            buttonInsructions_SMA = new Button();
            SuspendLayout();
            // 
            // buttonAbout_SMA
            // 
            buttonAbout_SMA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAbout_SMA.Location = new Point(274, 286);
            buttonAbout_SMA.Name = "buttonAbout_SMA";
            buttonAbout_SMA.Size = new Size(30, 30);
            buttonAbout_SMA.TabIndex = 0;
            buttonAbout_SMA.Text = "?";
            buttonAbout_SMA.UseVisualStyleBackColor = true;
            buttonAbout_SMA.Click += buttonAbout_SMA_Click;
            // 
            // labelName_SMA
            // 
            labelName_SMA.Anchor = AnchorStyles.None;
            labelName_SMA.AutoSize = true;
            labelName_SMA.Font = new Font("Segoe UI", 20F);
            labelName_SMA.Location = new Point(61, 46);
            labelName_SMA.Name = "labelName_SMA";
            labelName_SMA.Size = new Size(196, 37);
            labelName_SMA.TabIndex = 1;
            labelName_SMA.Text = "Главное меню";
            labelName_SMA.Click += labelName_SMA_Click;
            // 
            // buttonCalculator_SMA
            // 
            buttonCalculator_SMA.Anchor = AnchorStyles.None;
            buttonCalculator_SMA.Location = new Point(61, 106);
            buttonCalculator_SMA.Name = "buttonCalculator_SMA";
            buttonCalculator_SMA.Size = new Size(196, 38);
            buttonCalculator_SMA.TabIndex = 2;
            buttonCalculator_SMA.Text = "Расчёт расхода топлива";
            buttonCalculator_SMA.UseVisualStyleBackColor = true;
            buttonCalculator_SMA.Click += button1_Click;
            // 
            // buttonEditor_SMA
            // 
            buttonEditor_SMA.Anchor = AnchorStyles.None;
            buttonEditor_SMA.Location = new Point(61, 150);
            buttonEditor_SMA.Name = "buttonEditor_SMA";
            buttonEditor_SMA.Size = new Size(196, 38);
            buttonEditor_SMA.TabIndex = 3;
            buttonEditor_SMA.Text = "Редактор автомобильной базы";
            buttonEditor_SMA.UseVisualStyleBackColor = true;
            buttonEditor_SMA.Click += button2_Click;
            // 
            // buttonSpeedTime_SMA
            // 
            buttonSpeedTime_SMA.Anchor = AnchorStyles.None;
            buttonSpeedTime_SMA.Location = new Point(61, 194);
            buttonSpeedTime_SMA.Name = "buttonSpeedTime_SMA";
            buttonSpeedTime_SMA.Size = new Size(196, 38);
            buttonSpeedTime_SMA.TabIndex = 4;
            buttonSpeedTime_SMA.Text = "График скорости/времени";
            buttonSpeedTime_SMA.UseVisualStyleBackColor = true;
            buttonSpeedTime_SMA.Click += buttonSpeedTime_SMA_Click;
            // 
            // buttonInsructions_SMA
            // 
            buttonInsructions_SMA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInsructions_SMA.Location = new Point(171, 286);
            buttonInsructions_SMA.Name = "buttonInsructions_SMA";
            buttonInsructions_SMA.Size = new Size(97, 30);
            buttonInsructions_SMA.TabIndex = 5;
            buttonInsructions_SMA.Text = "Инструкция";
            buttonInsructions_SMA.UseVisualStyleBackColor = true;
            buttonInsructions_SMA.Click += buttonInsructions_SMA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 328);
            Controls.Add(buttonInsructions_SMA);
            Controls.Add(buttonSpeedTime_SMA);
            Controls.Add(buttonEditor_SMA);
            Controls.Add(buttonCalculator_SMA);
            Controls.Add(labelName_SMA);
            Controls.Add(buttonAbout_SMA);
            MaximizeBox = false;
            MaximumSize = new Size(435, 487);
            MinimumSize = new Size(331, 367);
            Name = "FormMain";
            Text = "Автотранспортное предприятие";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAbout_SMA;
        private Label labelName_SMA;
        private Button buttonCalculator_SMA;
        private Button buttonEditor_SMA;
        private Button buttonSpeedTime_SMA;
        private Button buttonInsructions_SMA;
    }
}
