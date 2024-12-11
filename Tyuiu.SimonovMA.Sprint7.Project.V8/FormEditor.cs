using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    public partial class FormEditor : Form
    {
        public FormEditor()
        {
            InitializeComponent();
        }

        private void buttonLoad_SMA_Click(object sender, EventArgs e)
        {
            // Создание диалога выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Выберите файл для загрузки"
            };

            // если пользователь выбрал файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // чтение всех строк из файла
                    string[] lines = File.ReadAllLines(filePath);

                    // убедимся что файл не пуст
                    if (lines.Length > 0)
                    {
                        // отключаем добвление новой строки перед очисткой
                        bool previousAllowUserToAddRows = dataGridView_SMA.AllowUserToAddRows;
                        dataGridView_SMA.AllowUserToAddRows = false;

                        // очистка всех строк ниже заголовков
                        while (dataGridView_SMA.Rows.Count > 0)
                        {
                            dataGridView_SMA.Rows.RemoveAt(0); // Удаляем строки, начиная со второй
                        }

                        // заполнение из файла
                        foreach (string line in lines)
                        {
                            // разделение строки на ячейки
                            string[] values = line.Split(';');

                            // добавляем новую строку
                            dataGridView_SMA.Rows.Add(values);
                        }

                        // восстанавливаем настройку добавления строки
                        dataGridView_SMA.AllowUserToAddRows = previousAllowUserToAddRows;

                        MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Файл пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_SMA_Click(object sender, EventArgs e)
        {
            // создание диалога сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Сохранение таблицы",
                DefaultExt = "csv"
            };

            // если пользователь выбрал файл
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // список стрк для записи в файл
                    List<string> lines = new List<string>();

                    // перебор строк, начиная с индекса 1
                    for (int i = 0; i < dataGridView_SMA.Rows.Count; i++)
                    {
                        DataGridViewRow row = dataGridView_SMA.Rows[i];

                        // игнорируем новую строку, если она есть
                        if (row.IsNewRow)
                            continue;

                        // собираем данные из ячеек строки, разделяя их точкой с запятой
                        string line = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        lines.Add(line);
                    }

                    // запись всех строк в файл
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDataSearch_SMA_Click(object sender, EventArgs e)
        {
            // получаем текст для поиска
            string searchText = textBoxSearch_SMA.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // определяем индекс столбца для поиска
            int searchColumnIndex = 0; // по умолчанию ищем в первом столбце
            if (!string.IsNullOrEmpty(textBoxSearchColumn_SMA.Text.Trim()))
            {
                if (!int.TryParse(textBoxSearchColumn_SMA.Text.Trim(), out searchColumnIndex))
                {
                    MessageBox.Show("Укажите корректный номер столбца для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // преобразуем номер столбца (начиная с 1) в индекс (начиная с 0)
                searchColumnIndex -= 1;

                // проверяем чтобы индекс столбца был в пределах допустимых значений
                if (searchColumnIndex < 0 || searchColumnIndex >= dataGridView_SMA.ColumnCount)
                {
                    MessageBox.Show("Указан некорректный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // выполняем поиск
            List<string> foundRows = new List<string>();
            foreach (DataGridViewRow row in dataGridView_SMA.Rows)
            {
                // игнорируем новую строку
                if (row.IsNewRow)
                    continue;

                // получаем значение в указанном столбце
                string cellValue = row.Cells[searchColumnIndex].Value?.ToString() ?? "";

                // сравниваем значение с искомым текстом
                if (cellValue.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // формируем строку с данными всей строки
                    string rowData = string.Join(" | ", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                    foundRows.Add(rowData);
                }
            }

            // отображаем результат
            if (foundRows.Count > 0)
            {
                MessageBox.Show("Найдены следующие строки:\n" + string.Join("\n", foundRows), "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Совпадения не найдены.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClearSearch_SMA_Click(object sender, EventArgs e)
        {
            textBoxSearch_SMA.Clear();
            textBoxSearchColumn_SMA.Clear();
        }

        private void buttonSortDescending_SMA_Click(object sender, EventArgs e)
        {
            // получаем номер столбца для сортировки
            int sortColumnIndex = 0; // по умолчанию сортируем по первому столбцу
            if (!string.IsNullOrEmpty(textBoxSortWhichColumn_SMA.Text.Trim()))
            {
                if (!int.TryParse(textBoxSortWhichColumn_SMA.Text.Trim(), out sortColumnIndex))
                {
                    MessageBox.Show("Укажите корректный номер столбца для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // преобразуем номер столбца (начиная с 1) в индекс (начиная с 0)
                sortColumnIndex -= 1;

                // проверяем, чтобы индекс столбца был в пределах допустимых значений
                if (sortColumnIndex < 0 || sortColumnIndex >= dataGridView_SMA.ColumnCount)
                {
                    MessageBox.Show("Указан некорректный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // сортируем по убыванию
            dataGridView_SMA.Sort(dataGridView_SMA.Columns[sortColumnIndex], System.ComponentModel.ListSortDirection.Descending);
        }

        private void buttonSortAscending_SMA_Click(object sender, EventArgs e)
        {
            // получаем номер столбца для сортировки
            int sortColumnIndex = 0; // по умолчанию сортируем по первому столбцу
            if (!string.IsNullOrEmpty(textBoxSortWhichColumn_SMA.Text.Trim()))
            {
                if (!int.TryParse(textBoxSortWhichColumn_SMA.Text.Trim(), out sortColumnIndex))
                {
                    MessageBox.Show("Укажите корректный номер столбца для сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // преобразуем номер столбца (начиная с 1) в индекс (начиная с 0)
                sortColumnIndex -= 1;

                // проверяем чтобы индекс столбца был в пределах допустимых значений
                if (sortColumnIndex < 0 || sortColumnIndex >= dataGridView_SMA.ColumnCount)
                {
                    MessageBox.Show("Указан некорректный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // сортируем по возрастанию
            dataGridView_SMA.Sort(dataGridView_SMA.Columns[sortColumnIndex], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void buttonSortDefaultColumn_SMA_Click(object sender, EventArgs e)
        {
            textBoxSortWhichColumn_SMA.Clear();
        }
    }
}
