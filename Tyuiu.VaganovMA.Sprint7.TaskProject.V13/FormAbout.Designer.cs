namespace Tyuiu.VaganovMA.Sprint7.TaskProject.V13
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
            buttonCl = new Button();
            labelInfo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCl
            // 
            buttonCl.Location = new Point(686, 353);
            buttonCl.Margin = new Padding(3, 2, 3, 2);
            buttonCl.Name = "buttonCl";
            buttonCl.Size = new Size(94, 30);
            buttonCl.TabIndex = 11;
            buttonCl.Text = "Ok";
            buttonCl.UseVisualStyleBackColor = true;
            buttonCl.Click += buttonCl_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 12F);
            labelInfo.Location = new Point(516, 9);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(422, 252);
            labelInfo.TabIndex = 10;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 403);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 419);
            Controls.Add(buttonCl);
            Controls.Add(labelInfo);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCl;
        private Label labelInfo;
        private PictureBox pictureBox1;
    }
}