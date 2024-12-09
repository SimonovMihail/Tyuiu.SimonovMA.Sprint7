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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(61, 106);
            button1.Name = "button1";
            button1.Size = new Size(196, 38);
            button1.TabIndex = 2;
            button1.Text = "Расчёт расхода топлива";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(61, 150);
            button2.Name = "button2";
            button2.Size = new Size(196, 38);
            button2.TabIndex = 3;
            button2.Text = "Редактор автомобильной базы";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(61, 194);
            button3.Name = "button3";
            button3.Size = new Size(196, 38);
            button3.TabIndex = 4;
            button3.Text = "Графики скорости/времени";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Location = new Point(171, 286);
            button4.Name = "button4";
            button4.Size = new Size(97, 30);
            button4.TabIndex = 5;
            button4.Text = "Инструкция";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 328);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
