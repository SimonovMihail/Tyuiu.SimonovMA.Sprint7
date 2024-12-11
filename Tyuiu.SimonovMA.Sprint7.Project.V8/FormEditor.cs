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

            // Если пользователь выбрал файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Чтение всех строк из файла
                    string[] lines = File.ReadAllLines(filePath);

                    // Убедимся, что файл не пуст
                    if (lines.Length > 0)
                    {
                        // Отключаем добавление новой строки перед очисткой
                        bool previousAllowUserToAddRows = dataGridView_SMA.AllowUserToAddRows;
                        dataGridView_SMA.AllowUserToAddRows = false;

                        // Очистка всех строк ниже заголовков
                        while (dataGridView_SMA.Rows.Count > 0)
                        {
                            dataGridView_SMA.Rows.RemoveAt(0); // Удаляем строки, начиная со второй
                        }

                        // Заполнение данными из файла
                        foreach (string line in lines)
                        {
                            // Разделение строки на ячейки (используем разделитель запятая)
                            string[] values = line.Split(';');

                            // Добавляем новую строку
                            dataGridView_SMA.Rows.Add(values);
                        }

                        // Восстанавливаем настройку добавления строки
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
            // Создание диалога сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Сохранение таблицы",
                DefaultExt = "csv"
            };

            // Если пользователь выбрал файл
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Список строк для записи в файл
                    List<string> lines = new List<string>();

                    // Перебор строк DataGridView, начиная с индекса 1 (пропускаем первую строку)
                    for (int i = 0; i < dataGridView_SMA.Rows.Count; i++)
                    {
                        DataGridViewRow row = dataGridView_SMA.Rows[i];

                        // Игнорируем новую строку, если она есть
                        if (row.IsNewRow)
                            continue;

                        // Собираем данные из ячеек строки, разделяя их точкой с запятой
                        string line = string.Join(";", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                        lines.Add(line);
                    }

                    // Запись всех строк в файл
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
            // Получаем текст для поиска
            string searchText = textBoxSearch_SMA.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Определяем индекс столбца для поиска
            int searchColumnIndex = 0; // По умолчанию ищем в первом столбце
            if (!string.IsNullOrEmpty(textBoxSearchColumn_SMA.Text.Trim()))
            {
                if (!int.TryParse(textBoxSearchColumn_SMA.Text.Trim(), out searchColumnIndex))
                {
                    MessageBox.Show("Укажите корректный номер столбца для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Преобразуем номер столбца (начиная с 1) в индекс (начиная с 0)
                searchColumnIndex -= 1;

                // Проверяем, чтобы индекс столбца был в пределах допустимых значений
                if (searchColumnIndex < 0 || searchColumnIndex >= dataGridView_SMA.ColumnCount)
                {
                    MessageBox.Show("Указан некорректный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Выполняем поиск
            List<string> foundRows = new List<string>();
            foreach (DataGridViewRow row in dataGridView_SMA.Rows)
            {
                // Игнорируем новую строку
                if (row.IsNewRow)
                    continue;

                // Получаем значение в указанном столбце
                string cellValue = row.Cells[searchColumnIndex].Value?.ToString() ?? "";

                // Сравниваем значение с искомым текстом
                if (cellValue.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // Формируем строку с данными всей строки
                    string rowData = string.Join(" | ", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? ""));
                    foundRows.Add(rowData);
                }
            }

            // Отображаем результат
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

    }
}
