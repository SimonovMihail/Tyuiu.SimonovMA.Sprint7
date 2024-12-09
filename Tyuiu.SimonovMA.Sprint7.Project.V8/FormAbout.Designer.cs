namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            buttonOk_SMA = new Button();
            textBoxAbout_SMA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonOk_SMA
            // 
            buttonOk_SMA.Location = new Point(340, 176);
            buttonOk_SMA.Name = "buttonOk_SMA";
            buttonOk_SMA.Size = new Size(75, 23);
            buttonOk_SMA.TabIndex = 1;
            buttonOk_SMA.Text = "Ок";
            buttonOk_SMA.UseVisualStyleBackColor = true;
            buttonOk_SMA.Click += buttonOk_SMA_Click;
            // 
            // textBoxAbout_SMA
            // 
            textBoxAbout_SMA.BorderStyle = BorderStyle.None;
            textBoxAbout_SMA.Location = new Point(164, 12);
            textBoxAbout_SMA.Multiline = true;
            textBoxAbout_SMA.Name = "textBoxAbout_SMA";
            textBoxAbout_SMA.ReadOnly = true;
            textBoxAbout_SMA.Size = new Size(251, 158);
            textBoxAbout_SMA.TabIndex = 2;
            textBoxAbout_SMA.Text = resources.GetString("textBoxAbout_SMA.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 211);
            Controls.Add(textBoxAbout_SMA);
            Controls.Add(buttonOk_SMA);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonOk_SMA;
        private TextBox textBoxAbout_SMA;
    }
}