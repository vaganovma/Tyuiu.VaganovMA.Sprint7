
namespace Tyuiu.VaganovMA.Sprint7.TaskProject.V13
{
    partial class FormP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP));
            labelUserManual_VMA = new Label();
            buttonClose_VMA = new Button();
            SuspendLayout();
            // 
            // labelUserManual_VMA
            // 
            labelUserManual_VMA.Font = new Font("Segoe UI", 13F);
            labelUserManual_VMA.Location = new Point(20, 9);
            labelUserManual_VMA.Name = "labelUserManual_VMA";
            labelUserManual_VMA.Size = new Size(760, 324);
            labelUserManual_VMA.TabIndex = 4;
            labelUserManual_VMA.Text = resources.GetString("labelUserManual_VMA.Text");
            // 
            // buttonClose_VMA
            // 
            buttonClose_VMA.BackColor = SystemColors.Window;
            buttonClose_VMA.FlatStyle = FlatStyle.Popup;
            buttonClose_VMA.Location = new Point(345, 336);
            buttonClose_VMA.Name = "buttonClose_VMA";
            buttonClose_VMA.Size = new Size(97, 25);
            buttonClose_VMA.TabIndex = 3;
            buttonClose_VMA.Text = "Закрыть";
            buttonClose_VMA.UseVisualStyleBackColor = false;
            buttonClose_VMA.Click += buttonClose_VMA_Click;
            // 
            // FormP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 386);
            Controls.Add(labelUserManual_VMA);
            Controls.Add(buttonClose_VMA);
            Name = "FormP";
            Text = "Руководство пользователя";
            ResumeLayout(false);
        }

        private void buttonClose_VMA_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label labelUserManual_VMA;
        private Button buttonClose_VMA;
    }
}