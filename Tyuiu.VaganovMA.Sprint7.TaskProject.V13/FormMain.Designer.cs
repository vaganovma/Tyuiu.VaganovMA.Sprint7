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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            dataGridViewOutData_VMA = new DataGridView();
            panelInstruments_AAN = new Panel();
            buttonDel = new Button();
            buttonS = new Button();
            buttonVMA = new Button();
            buttonDeleteChooseBook_AAN = new Button();
            textBoxDeleteBook_AAN = new TextBox();
            textBoxVMA = new TextBox();
            buttonDeleteBook_AAN = new Button();
            buttonOpenFile_AAN = new Button();
            pictureBoxUpdate_VMA = new PictureBox();
            buttonAdd_AAN = new Button();
            textBoxSearch_VMA = new TextBox();
            buttonSearch_VMA = new Button();
            buttonSaveFile_AAN = new Button();
            buttonUserManual_AAN = new Button();
            buttonAboutProgram_AAN = new Button();
            chartPriceOfF_VMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartYearOfPublication_VMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTipSaveFile_VMA = new ToolTip(components);
            toolTipOpenFile = new ToolTip(components);
            toolTipDel = new ToolTip(components);
            toolTipDone = new ToolTip(components);
            openFileDialogJSON_VMA = new OpenFileDialog();
            saveFileDialogSaveLib_VMA = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutData_VMA).BeginInit();
            panelInstruments_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdate_VMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPriceOfF_VMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartYearOfPublication_VMA).BeginInit();
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
            buttonSaveFile.Location = new Point(1022, 2);
            buttonSaveFile.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(116, 64);
            buttonSaveFile.TabIndex = 19;
            toolTipSaveFile_VMA.SetToolTip(buttonSaveFile, "Сохранить файл");
            buttonSaveFile.UseVisualStyleBackColor = false;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.MediumOrchid;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(900, 3);
            buttonDone.Margin = new Padding(3, 2, 3, 2);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 64);
            buttonDone.TabIndex = 17;
            toolTipDone.SetToolTip(buttonDone, "Добавить в  список");
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.LightCoral;
            buttonOpenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(3, 5);
            buttonOpenFile.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(109, 64);
            buttonOpenFile.TabIndex = 16;
            toolTipOpenFile.SetToolTip(buttonOpenFile, "Открыть файл");
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MistyRose;
            buttonHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp.Location = new Point(1223, 2);
            buttonHelp.Margin = new Padding(3, 2, 3, 2);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(124, 64);
            buttonHelp.TabIndex = 18;
            buttonHelp.Text = "Кто делал";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // dataGridViewOutData_VMA
            // 
            dataGridViewOutData_VMA.AllowUserToDeleteRows = false;
            dataGridViewOutData_VMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutData_VMA.Location = new Point(0, 74);
            dataGridViewOutData_VMA.Name = "dataGridViewOutData_VMA";
            dataGridViewOutData_VMA.RowHeadersVisible = false;
            dataGridViewOutData_VMA.Size = new Size(710, 562);
            dataGridViewOutData_VMA.TabIndex = 20;
            // 
            // panelInstruments_AAN
            // 
            panelInstruments_AAN.Controls.Add(buttonDel);
            panelInstruments_AAN.Controls.Add(buttonS);
            panelInstruments_AAN.Controls.Add(buttonVMA);
            panelInstruments_AAN.Controls.Add(buttonDeleteChooseBook_AAN);
            panelInstruments_AAN.Controls.Add(textBoxDeleteBook_AAN);
            panelInstruments_AAN.Controls.Add(textBoxVMA);
            panelInstruments_AAN.Controls.Add(buttonDeleteBook_AAN);
            panelInstruments_AAN.Controls.Add(buttonOpenFile_AAN);
            panelInstruments_AAN.Controls.Add(buttonOpenFile);
            panelInstruments_AAN.Controls.Add(buttonDone);
            panelInstruments_AAN.Controls.Add(buttonSaveFile);
            panelInstruments_AAN.Controls.Add(pictureBoxUpdate_VMA);
            panelInstruments_AAN.Controls.Add(buttonAdd_AAN);
            panelInstruments_AAN.Controls.Add(textBoxSearch_VMA);
            panelInstruments_AAN.Controls.Add(buttonHelp);
            panelInstruments_AAN.Controls.Add(buttonSearch_VMA);
            panelInstruments_AAN.Controls.Add(buttonSaveFile_AAN);
            panelInstruments_AAN.Controls.Add(buttonUserManual_AAN);
            panelInstruments_AAN.Controls.Add(buttonAboutProgram_AAN);
            panelInstruments_AAN.Dock = DockStyle.Top;
            panelInstruments_AAN.Location = new Point(0, 0);
            panelInstruments_AAN.Name = "panelInstruments_AAN";
            panelInstruments_AAN.Size = new Size(1350, 68);
            panelInstruments_AAN.TabIndex = 21;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.MediumPurple;
            buttonDel.Cursor = Cursors.Hand;
            buttonDel.Enabled = false;
            buttonDel.FlatStyle = FlatStyle.Flat;
            buttonDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDel.Image = (Image)resources.GetObject("buttonDel.Image");
            buttonDel.Location = new Point(778, 3);
            buttonDel.Margin = new Padding(3, 2, 3, 2);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(116, 64);
            buttonDel.TabIndex = 26;
            toolTipDel.SetToolTip(buttonDel, "Удалить из списка");
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonS
            // 
            buttonS.BackColor = Color.MistyRose;
            buttonS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonS.Location = new Point(1150, 2);
            buttonS.Margin = new Padding(3, 2, 3, 2);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(67, 64);
            buttonS.TabIndex = 25;
            buttonS.Text = "Справка";
            buttonS.UseVisualStyleBackColor = false;
            buttonS.Click += buttonS_Click;
            // 
            // buttonVMA
            // 
            buttonVMA.Anchor = AnchorStyles.Right;
            buttonVMA.BackColor = SystemColors.Window;
            buttonVMA.FlatStyle = FlatStyle.Popup;
            buttonVMA.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVMA.ForeColor = SystemColors.ControlText;
            buttonVMA.Location = new Point(433, 44);
            buttonVMA.Name = "buttonVMA";
            buttonVMA.Size = new Size(83, 23);
            buttonVMA.TabIndex = 21;
            buttonVMA.Text = "Удалить";
            buttonVMA.TextAlign = ContentAlignment.TopCenter;
            buttonVMA.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteChooseBook_AAN
            // 
            buttonDeleteChooseBook_AAN.Anchor = AnchorStyles.Right;
            buttonDeleteChooseBook_AAN.BackColor = SystemColors.Window;
            buttonDeleteChooseBook_AAN.FlatStyle = FlatStyle.Popup;
            buttonDeleteChooseBook_AAN.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteChooseBook_AAN.ForeColor = SystemColors.ControlText;
            buttonDeleteChooseBook_AAN.Location = new Point(1949, 6);
            buttonDeleteChooseBook_AAN.Name = "buttonDeleteChooseBook_AAN";
            buttonDeleteChooseBook_AAN.Size = new Size(70, 23);
            buttonDeleteChooseBook_AAN.TabIndex = 11;
            buttonDeleteChooseBook_AAN.Text = "Удалить";
            buttonDeleteChooseBook_AAN.TextAlign = ContentAlignment.TopCenter;
            buttonDeleteChooseBook_AAN.UseVisualStyleBackColor = false;
            // 
            // textBoxDeleteBook_AAN
            // 
            textBoxDeleteBook_AAN.Anchor = AnchorStyles.Right;
            textBoxDeleteBook_AAN.Location = new Point(1708, 6);
            textBoxDeleteBook_AAN.Name = "textBoxDeleteBook_AAN";
            textBoxDeleteBook_AAN.PlaceholderText = "Введите название книги для удаления";
            textBoxDeleteBook_AAN.Size = new Size(235, 23);
            textBoxDeleteBook_AAN.TabIndex = 10;
            textBoxDeleteBook_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVMA
            // 
            textBoxVMA.Anchor = AnchorStyles.Right;
            textBoxVMA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxVMA.Location = new Point(183, 43);
            textBoxVMA.Name = "textBoxVMA";
            textBoxVMA.PlaceholderText = "Введите название фильма для удаления";
            textBoxVMA.Size = new Size(235, 23);
            textBoxVMA.TabIndex = 20;
            textBoxVMA.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonDeleteBook_AAN
            // 
            buttonDeleteBook_AAN.Anchor = AnchorStyles.Right;
            buttonDeleteBook_AAN.BackColor = SystemColors.Window;
            buttonDeleteBook_AAN.BackgroundImageLayout = ImageLayout.None;
            buttonDeleteBook_AAN.FlatStyle = FlatStyle.Popup;
            buttonDeleteBook_AAN.Image = (Image)resources.GetObject("buttonDeleteBook_AAN.Image");
            buttonDeleteBook_AAN.Location = new Point(2025, -12);
            buttonDeleteBook_AAN.Name = "buttonDeleteBook_AAN";
            buttonDeleteBook_AAN.Size = new Size(60, 60);
            buttonDeleteBook_AAN.TabIndex = 9;
            buttonDeleteBook_AAN.UseVisualStyleBackColor = false;
            // 
            // buttonOpenFile_AAN
            // 
            buttonOpenFile_AAN.Anchor = AnchorStyles.Right;
            buttonOpenFile_AAN.BackColor = SystemColors.Window;
            buttonOpenFile_AAN.BackgroundImageLayout = ImageLayout.None;
            buttonOpenFile_AAN.FlatStyle = FlatStyle.Popup;
            buttonOpenFile_AAN.Image = (Image)resources.GetObject("buttonOpenFile_AAN.Image");
            buttonOpenFile_AAN.Location = new Point(2220, -12);
            buttonOpenFile_AAN.Name = "buttonOpenFile_AAN";
            buttonOpenFile_AAN.Size = new Size(60, 60);
            buttonOpenFile_AAN.TabIndex = 8;
            buttonOpenFile_AAN.UseVisualStyleBackColor = false;
            // 
            // pictureBoxUpdate_VMA
            // 
            pictureBoxUpdate_VMA.ErrorImage = (Image)resources.GetObject("pictureBoxUpdate_VMA.ErrorImage");
            pictureBoxUpdate_VMA.Image = (Image)resources.GetObject("pictureBoxUpdate_VMA.Image");
            pictureBoxUpdate_VMA.Location = new Point(118, 9);
            pictureBoxUpdate_VMA.Name = "pictureBoxUpdate_VMA";
            pictureBoxUpdate_VMA.Size = new Size(59, 57);
            pictureBoxUpdate_VMA.TabIndex = 7;
            pictureBoxUpdate_VMA.TabStop = false;
            // 
            // buttonAdd_AAN
            // 
            buttonAdd_AAN.Anchor = AnchorStyles.Right;
            buttonAdd_AAN.BackColor = SystemColors.Window;
            buttonAdd_AAN.BackgroundImageLayout = ImageLayout.None;
            buttonAdd_AAN.FlatStyle = FlatStyle.Popup;
            buttonAdd_AAN.Image = (Image)resources.GetObject("buttonAdd_AAN.Image");
            buttonAdd_AAN.Location = new Point(2090, -12);
            buttonAdd_AAN.Name = "buttonAdd_AAN";
            buttonAdd_AAN.Size = new Size(60, 60);
            buttonAdd_AAN.TabIndex = 5;
            buttonAdd_AAN.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch_VMA
            // 
            textBoxSearch_VMA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxSearch_VMA.Location = new Point(183, 12);
            textBoxSearch_VMA.Name = "textBoxSearch_VMA";
            textBoxSearch_VMA.PlaceholderText = "Введите название Фильма";
            textBoxSearch_VMA.Size = new Size(235, 23);
            textBoxSearch_VMA.TabIndex = 4;
            textBoxSearch_VMA.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonSearch_VMA
            // 
            buttonSearch_VMA.Anchor = AnchorStyles.Left;
            buttonSearch_VMA.BackColor = SystemColors.Window;
            buttonSearch_VMA.FlatStyle = FlatStyle.Popup;
            buttonSearch_VMA.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch_VMA.ForeColor = SystemColors.ControlText;
            buttonSearch_VMA.Location = new Point(433, 12);
            buttonSearch_VMA.Name = "buttonSearch_VMA";
            buttonSearch_VMA.Size = new Size(83, 23);
            buttonSearch_VMA.TabIndex = 2;
            buttonSearch_VMA.Text = "Найти";
            buttonSearch_VMA.TextAlign = ContentAlignment.TopCenter;
            buttonSearch_VMA.UseVisualStyleBackColor = false;
            buttonSearch_VMA.Click += buttonSearch_VMA_Click;
            // 
            // buttonSaveFile_AAN
            // 
            buttonSaveFile_AAN.Anchor = AnchorStyles.Right;
            buttonSaveFile_AAN.BackColor = SystemColors.Window;
            buttonSaveFile_AAN.FlatStyle = FlatStyle.Popup;
            buttonSaveFile_AAN.Image = (Image)resources.GetObject("buttonSaveFile_AAN.Image");
            buttonSaveFile_AAN.Location = new Point(2155, -12);
            buttonSaveFile_AAN.Name = "buttonSaveFile_AAN";
            buttonSaveFile_AAN.Size = new Size(60, 60);
            buttonSaveFile_AAN.TabIndex = 3;
            buttonSaveFile_AAN.UseVisualStyleBackColor = false;
            // 
            // buttonUserManual_AAN
            // 
            buttonUserManual_AAN.Anchor = AnchorStyles.Right;
            buttonUserManual_AAN.BackColor = SystemColors.Window;
            buttonUserManual_AAN.FlatStyle = FlatStyle.Popup;
            buttonUserManual_AAN.Image = (Image)resources.GetObject("buttonUserManual_AAN.Image");
            buttonUserManual_AAN.Location = new Point(2285, -12);
            buttonUserManual_AAN.Name = "buttonUserManual_AAN";
            buttonUserManual_AAN.Size = new Size(60, 60);
            buttonUserManual_AAN.TabIndex = 1;
            buttonUserManual_AAN.UseVisualStyleBackColor = false;
            // 
            // buttonAboutProgram_AAN
            // 
            buttonAboutProgram_AAN.Anchor = AnchorStyles.Right;
            buttonAboutProgram_AAN.BackColor = SystemColors.Window;
            buttonAboutProgram_AAN.FlatStyle = FlatStyle.Popup;
            buttonAboutProgram_AAN.Image = (Image)resources.GetObject("buttonAboutProgram_AAN.Image");
            buttonAboutProgram_AAN.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAboutProgram_AAN.Location = new Point(2350, -12);
            buttonAboutProgram_AAN.Name = "buttonAboutProgram_AAN";
            buttonAboutProgram_AAN.Size = new Size(60, 60);
            buttonAboutProgram_AAN.TabIndex = 0;
            buttonAboutProgram_AAN.UseVisualStyleBackColor = false;
            // 
            // chartPriceOfF_VMA
            // 
            chartArea1.Name = "ChartArea1";
            chartPriceOfF_VMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPriceOfF_VMA.Legends.Add(legend1);
            chartPriceOfF_VMA.Location = new Point(710, 74);
            chartPriceOfF_VMA.Name = "chartPriceOfF_VMA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPriceOfF_VMA.Series.Add(series1);
            chartPriceOfF_VMA.Size = new Size(637, 280);
            chartPriceOfF_VMA.TabIndex = 23;
            chartPriceOfF_VMA.Text = "Стоимость Фильма";
            // 
            // chartYearOfPublication_VMA
            // 
            chartArea2.Name = "ChartArea1";
            chartYearOfPublication_VMA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartYearOfPublication_VMA.Legends.Add(legend2);
            chartYearOfPublication_VMA.Location = new Point(710, 357);
            chartYearOfPublication_VMA.Name = "chartYearOfPublication_VMA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartYearOfPublication_VMA.Series.Add(series2);
            chartYearOfPublication_VMA.Size = new Size(640, 298);
            chartYearOfPublication_VMA.TabIndex = 22;
            chartYearOfPublication_VMA.Text = "Год издания";
            // 
            // toolTipSaveFile_VMA
            // 
            toolTipSaveFile_VMA.ToolTipIcon = ToolTipIcon.Info;
            toolTipSaveFile_VMA.ToolTipTitle = "Сохранить список";
            // 
            // toolTipOpenFile
            // 
            toolTipOpenFile.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpenFile.ToolTipTitle = "Открыть список";
            // 
            // toolTipDel
            // 
            toolTipDel.ToolTipIcon = ToolTipIcon.Info;
            toolTipDel.ToolTipTitle = "Удалить из списка";
            // 
            // toolTipDone
            // 
            toolTipDone.ToolTipIcon = ToolTipIcon.Info;
            toolTipDone.ToolTipTitle = "Добавить в  список";
            // 
            // openFileDialogJSON_VMA
            // 
            openFileDialogJSON_VMA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 636);
            Controls.Add(chartPriceOfF_VMA);
            Controls.Add(chartYearOfPublication_VMA);
            Controls.Add(panelInstruments_AAN);
            Controls.Add(dataGridViewOutData_VMA);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutData_VMA).EndInit();
            panelInstruments_AAN.ResumeLayout(false);
            panelInstruments_AAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdate_VMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPriceOfF_VMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartYearOfPublication_VMA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaveFile;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private DataGridView dataGridViewOutData_VMA;
        private Panel panelInstruments_AAN;
        private Button buttonDeleteChooseBook_AAN;
        private TextBox textBoxDeleteBook_AAN;
        private Button buttonDeleteBook_AAN;
        private Button buttonOpenFile_AAN;
        private PictureBox pictureBoxUpdate_VMA;
        private Button buttonAdd_AAN;
        private TextBox textBoxSearch_VMA;
        private Button buttonSearch_VMA;
        private Button buttonSaveFile_AAN;
        private Button buttonUserManual_AAN;
        private Button buttonAboutProgram_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPriceOfF_VMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearOfPublication_VMA;
        private Button buttonVMA;
        private TextBox textBoxVMA;
        private ToolTip toolTipSaveFile_VMA;
        private Button buttonS;
        private ToolTip toolTipOpenFile;
        private ToolTip toolTipDone;
        private Button buttonDel;
        private ToolTip toolTipDel;
        private OpenFileDialog openFileDialogJSON_VMA;
        private SaveFileDialog saveFileDialogSaveLib_VMA;
    }
}
