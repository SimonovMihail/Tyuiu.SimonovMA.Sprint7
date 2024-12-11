namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    partial class FormInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstructions));
            pictureBoxDataIns_SMA = new PictureBox();
            buttonOk_SMA = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDataIns_SMA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDataIns_SMA
            // 
            pictureBoxDataIns_SMA.Image = Properties.Resources.instructions_databases;
            pictureBoxDataIns_SMA.Location = new Point(12, 280);
            pictureBoxDataIns_SMA.Name = "pictureBoxDataIns_SMA";
            pictureBoxDataIns_SMA.Size = new Size(412, 150);
            pictureBoxDataIns_SMA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDataIns_SMA.TabIndex = 0;
            pictureBoxDataIns_SMA.TabStop = false;
            // 
            // buttonOk_SMA
            // 
            buttonOk_SMA.Location = new Point(165, 441);
            buttonOk_SMA.Name = "buttonOk_SMA";
            buttonOk_SMA.Size = new Size(116, 41);
            buttonOk_SMA.TabIndex = 1;
            buttonOk_SMA.Text = "Ок";
            buttonOk_SMA.UseVisualStyleBackColor = true;
            buttonOk_SMA.Click += buttonOk_SMA_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(412, 262);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormInstructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 489);
            Controls.Add(textBox1);
            Controls.Add(buttonOk_SMA);
            Controls.Add(pictureBoxDataIns_SMA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormInstructions";
            Text = "Инструкция";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDataIns_SMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDataIns_SMA;
        private Button buttonOk_SMA;
        private TextBox textBox1;
    }
}