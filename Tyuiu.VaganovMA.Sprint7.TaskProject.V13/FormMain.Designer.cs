namespace Tyuiu.VaganovMA.Sprint7.TaskProject.V13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.BackColor = Color.MediumSeaGreen;
            buttonSaveFile.Cursor = Cursors.Hand;
            buttonSaveFile.Enabled = false;
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(290, 48);
            buttonSaveFile.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(116, 64);
            buttonSaveFile.TabIndex = 19;
            buttonSaveFile.Text = "Открыть файл";
            buttonSaveFile.UseVisualStyleBackColor = false;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.MediumOrchid;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(152, 48);
            buttonDone.Margin = new Padding(3, 2, 3, 2);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 64);
            buttonDone.TabIndex = 17;
            buttonDone.Text = "Открыть файл";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.LightCoral;
            buttonOpenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(28, 48);
            buttonOpenFile.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(109, 64);
            buttonOpenFile.TabIndex = 16;
            buttonOpenFile.Text = "Выполнитель";
            buttonOpenFile.UseVisualStyleBackColor = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MistyRose;
            buttonHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp.Location = new Point(435, 48);
            buttonHelp.Margin = new Padding(3, 2, 3, 2);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(136, 64);
            buttonHelp.TabIndex = 18;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 591);
            Controls.Add(buttonSaveFile);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonHelp);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaveFile;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonHelp;
    }
}
