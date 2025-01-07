using wwwwwwww;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
namespace Tyuiu.VaganovMA.Sprint7.TaskProject.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {

        }
        //dataGridViewOutData_VMA.ColumnHeaderMouseClick += dataGridViewOutData_VMA.ColumnHeaderMouseClick;
        static string JsonPath = "";

        Class1 ds = new Class1();
        public class Film
        {
            public string author { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public double price { get; set; }
            public bool see { get; set; }
            public string annotation { get; set; }
        }
              
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogSaveLib_VMA.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialogSaveLib_VMA.ShowDialog();
                string filename = saveFileDialogSaveLib_VMA.FileName;
                FileInfo fileInfo = new FileInfo(filename);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(filename);
                }
                int rows = dataGridViewOutData_VMA.RowCount;
                int columns = dataGridViewOutData_VMA.ColumnCount;
                string str = "";
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {


                        if (c != columns - 1)
                        {
                            str += dataGridViewOutData_VMA.Rows[r].Cells[c].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewOutData_VMA.Rows[r].Cells[c].Value;
                        }
                    }

                    File.AppendAllText(filename, str + Environment.NewLine, Encoding.Unicode);
                    str = "";
                }
                string path = Path.GetDirectoryName(filename) + $"/{filename}";
                MessageBox.Show($"Файл успешно сохранён.\nПуть файла: {path}", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Ошибка сохранения файла, попробуйте ещё раз", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            FormP formAbout = new FormP();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogJSON_VMA.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialogJSON_VMA.ShowDialog();
            JsonPath = openFileDialogJSON_VMA.FileName;

            FormAdd f = new FormAdd(this.openFileDialogJSON_VMA.FileName);
            List<Lib> books = ds.GetLibraries(JsonPath);
            dataGridViewOutData_VMA.AutoGenerateColumns = true;
            dataGridViewOutData_VMA.DataSource = books;
            dataGridViewOutData_VMA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOutData_VMA.Columns[0].HeaderText = "Видео код";
            dataGridViewOutData_VMA.Columns[1].HeaderText = "Время Фильма";
            dataGridViewOutData_VMA.Columns[2].HeaderText = "тема";
            dataGridViewOutData_VMA.Columns[3].HeaderText = "Стоимость фильма";
            dataGridViewOutData_VMA.Columns[4].HeaderText = "Актер";
            

            chartYearOfPublication_VMA.Series.Clear();
            chartPriceOfF_VMA.Series.Clear();

            foreach (var book in books)
            {
                var seriesYear = chartYearOfPublication_VMA.Series.Add(book.actor);
                seriesYear.Points.AddXY(book.actor, book.record_date);
                var seriesPrice = chartPriceOfF_VMA.Series.Add(book.actor);
                seriesPrice.Points.AddXY(book.actor, book.price);
            }

            chartYearOfPublication_VMA.ChartAreas[0].AxisX.Title = "Актер";
            chartYearOfPublication_VMA.ChartAreas[0].AxisY.Title = "Год издания";
            chartPriceOfF_VMA.ChartAreas[0].AxisX.Title = "Актер";
            chartPriceOfF_VMA.ChartAreas[0].AxisY.Title = "Цена";

            buttonDone.Enabled = true;
            buttonSaveFile.Enabled = true;
            buttonSearch_VMA.Enabled = true;
            pictureBoxUpdate_VMA.Enabled = true;
            textBoxSearch_VMA.Enabled = true;
            buttonDel.Enabled = true;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBoxDeleteBook_AAN.Enabled = true;
            textBoxDeleteBook_AAN.Visible = true;
            buttonDeleteChooseBook_AAN.Enabled = true;
            buttonDeleteChooseBook_AAN.Visible = true;
        }

        private void buttonSearch_VMA_Click(object sender, EventArgs e)
        {
            try
            {

               // List<Lib> books = ds.SearchFilm(JsonPath, textBoxSearch_VMA.Text);
                List<Lib> books = ds.SearchFilm(JsonPath, textBoxSearch_VMA.Text);
                foreach (var book in books)
                {
                    if (textBoxSearch_VMA.Text != book.actor)
                    {
                        throw new Exception();
                    }
                }
                dataGridViewOutData_VMA.AutoGenerateColumns = true;
                dataGridViewOutData_VMA.DataSource = books;
                chartYearOfPublication_VMA.Series.Clear();
                chartPriceOfF_VMA.Series.Clear();
                foreach (var book in books)
                {
                    var seriesYear = chartYearOfPublication_VMA.Series.Add(book.actor);
                    seriesYear.Points.AddXY(book.actor, book.record_date);
                    var seriesPrice = chartPriceOfF_VMA.Series.Add(book.actor);
                    seriesPrice.Points.AddXY(book.actor, book.price);
                }

                chartYearOfPublication_VMA.ChartAreas[0].AxisX.Title = "Актер";
                chartYearOfPublication_VMA.ChartAreas[0].AxisY.Title = "Год издания";
                chartPriceOfF_VMA.ChartAreas[0].AxisX.Title = "Актер";
                chartPriceOfF_VMA.ChartAreas[0].AxisY.Title = "Цена";
            }
            catch
            {
                MessageBox.Show("Такого фильма нет в списке, вы можете её добавить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
