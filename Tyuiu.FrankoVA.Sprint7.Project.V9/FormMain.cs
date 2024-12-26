using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using Tyuiu.FrankoVA.Sprint7.Project.V9.Lib;
using System.Reflection;
using System.DirectoryServices;

namespace Tyuiu.FrankoVA.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        private bool isEditingEnabled = false;
        public FormMain()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "z.csv");
        
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;



        //
        private void buttonDown_VA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Выберите файл CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    var lines = File.ReadAllLines(filePath);
                    dataGridGlav_VA.Rows.Clear();
                    dataGridGlav_VA.Columns.Clear();

                    if (lines.Length == 0)
                    {
                        MessageBox.Show("Файл пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var headers = lines[0].Split(';');
                    foreach (var header in headers)
                    {
                        if (!string.IsNullOrWhiteSpace(header))
                        {
                            dataGridGlav_VA.Columns.Add(header.Trim(), header.Trim());
                        }
                    }

                    // Добавить строки в грид
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var cells = lines[i].Split(';');
                        if (cells.Length == headers.Length)
                        {
                            for (int j = 0; j < cells.Length; j++)
                            {
                                cells[j] = cells[j].Trim();
                            }
                            dataGridGlav_VA.Rows.Add(cells);
                        }
                        else
                        {
                            MessageBox.Show($"Ошибка в строке {i + 1}: количество данных не соответствует заголовкам.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Заполнение ComboBox
                    PopulateComboBoxWithUniqueValues("Тема", comboBoxGenre);
                    PopulateComboBoxWithUniqueValues("Страна", comboBoxCountry);

                    MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void PopulateComboBoxWithUniqueValues(string columnName, ComboBox comboBox)
        {
            var columnIndex = dataGridGlav_VA.Columns[columnName]?.Index;
            if (columnIndex == null)
            {
                MessageBox.Show($"Столбец '{columnName}' не найден в таблице.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridGlav_VA.Rows)
            {
                if (row.IsNewRow) continue;
                var cellValue = row.Cells[columnIndex.Value].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    uniqueValues.Add(cellValue.Trim());
                }
            }

            comboBox.Items.Clear();
            comboBox.Items.Add("Все");
            comboBox.Items.AddRange(uniqueValues.ToArray());
            comboBox.SelectedIndex = 0;
        }

        // Метод для фильтрации данных
        void FilterData()
        {
            string selectedGenre = comboBoxGenre.SelectedItem?.ToString() ?? "Все";
            string selectedCountry = comboBoxCountry.SelectedItem?.ToString() ?? "Все";

            foreach (DataGridViewRow row in dataGridGlav_VA.Rows)
            {
                if (row.IsNewRow) continue;

                bool matchesGenre = selectedGenre == "Все" || row.Cells["Тема"].Value?.ToString() == selectedGenre;
                bool matchesCountry = selectedCountry == "Все" || row.Cells["Страна"].Value?.ToString() == selectedCountry;

                row.Visible = matchesGenre && matchesCountry;
            }
        }
        private void buttonSave_VA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_VA.FileName = "OutPutFileTask7.csv";
                saveFileDialogMain_VA.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialogMain_VA.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialogMain_VA.FileName;

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    int rows = dataGridGlav_VA.RowCount;
                    int columns = dataGridGlav_VA.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridGlav_VA.Rows[i].Cells[j].Value);

                            if (j != columns - 1)
                            {
                                strBuilder.Append(";");
                            }
                        }

                        strBuilder.AppendLine();
                    }

                    File.WriteAllText(path, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сохранить файл. Ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenu_VA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGuide_VA_Click(object sender, EventArgs e)
        {
            FormGuide fmen = new FormGuide();
            fmen.TopMost = true;
            fmen.ShowDialog();

        }

        private void buttonOProg_VA_Click(object sender, EventArgs e)
        {
            FormOProg fmen = new FormOProg();
            fmen.TopMost = true;
            fmen.ShowDialog();
        }

        private void buttonGraf_VA_Click(object sender, EventArgs e)
        {
            FormGraf gr = new FormGraf();
            gr.Visible = true;
            this.Visible = false;

        }


        private void buttonPoisk_VA_Click(object sender, EventArgs e)
        {
            string searchText = textBoxPoisk_VA.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                foreach (DataGridViewRow row in dataGridGlav_VA.Rows)
                {
                    row.Visible = true; // Показываем все строки
                }
                return;
            }

            searchText = searchText.ToLower().Trim(); // Приводим текст к одному формату

            foreach (DataGridViewRow row in dataGridGlav_VA.Rows)
            {
                if (row.IsNewRow) continue; // Пропускаем строку ввода

                bool isMatch = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        // Очищаем значение ячейки и приводим его к нижнему регистру
                        string cellValue = cell.Value.ToString().ToLower().Trim();
                        if (cellValue.Contains(searchText))
                        {
                            isMatch = true;
                            break;
                        }
                    }
                }

                row.Visible = isMatch; // Показываем строку, если найдено совпадение
            }
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }


        private void textBoxPoisk_VA_TextChanged(object sender, EventArgs e)
        {
            //textBoxPoisk_VA.Clear();
        }

        private void textBoxPoisk_VA_Leave(object sender, EventArgs e)
        {
            //textBoxPoisk_VA.Text = "Поиск";
        }
        private void buttonSbros_VA_Click(object sender, EventArgs e)
        {
            textBoxPoisk_VA.Clear();

            foreach (DataGridViewRow row in dataGridGlav_VA.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
                comboBoxCountry.SelectedIndex = 0;
                comboBoxGenre.SelectedIndex = 0;
            }
        }

        private void buttonEdit_VA_Click(object sender, EventArgs e)
        {
            isEditingEnabled = !isEditingEnabled;

            dataGridGlav_VA.ReadOnly = !isEditingEnabled;
            dataGridGlav_VA.AllowUserToAddRows = isEditingEnabled;
            dataGridGlav_VA.AllowUserToDeleteRows = isEditingEnabled;

            // Уведомление
            if (isEditingEnabled)
            {
                dataGridGlav_VA.BackgroundColor = Color.LightYellow;
                dataGridGlav_VA.DefaultCellStyle.BackColor = Color.LightYellow;
                dataGridGlav_VA.DefaultCellStyle.ForeColor = Color.Black;
                dataGridGlav_VA.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                MessageBox.Show("Режим редактирования включён. Вы можете изменять данные в таблице.",
                                "Редактирование включено",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                dataGridGlav_VA.BackgroundColor = Color.White;
                dataGridGlav_VA.DefaultCellStyle.BackColor = Color.White;
                dataGridGlav_VA.DefaultCellStyle.ForeColor = Color.Black;
                dataGridGlav_VA.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                MessageBox.Show("Режим редактирования выключен. Данные больше нельзя изменять.",
                                "Редактирование выключено",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        
        public ListSortDirection SortDirection { get; private set; }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonVoz_VA_CheckedChanged(object sender, EventArgs e)
        {
        // Определяем направление сортировки (по возрастанию или убыванию)
            SortDirection = radioButtonVoz_VA.Checked ? ListSortDirection.Ascending : ListSortDirection.Descending;

            // Преобразуем значения в столбце "ID" в int и сортируем
            foreach (DataGridViewRow row in dataGridGlav_VA.Rows)
            {
                // Преобразуем значение в int, если возможно
                if (int.TryParse(row.Cells["ID"].Value?.ToString(), out int id))
                {
                    row.Cells["ID"].Value = id;
                }
                else
                {
                    row.Cells["ID"].Value = 0;  // Если не получилось преобразовать, присваиваем 0
                }
            }

            // Сортируем по столбцу "ID"
            dataGridGlav_VA.Sort(dataGridGlav_VA.Columns["ID"], SortDirection);
        }
    }

}



