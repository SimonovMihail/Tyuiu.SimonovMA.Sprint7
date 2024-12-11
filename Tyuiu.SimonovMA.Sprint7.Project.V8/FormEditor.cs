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

        private void buttonCountCalculate_SMA_Click(object sender, EventArgs e)
        {
            // изначально считаем все строки, кроме заголовочной
            int rowCount = dataGridView_SMA.Rows.Count;

            // исключаем новую строку, если включено AllowUserToAddRows и строка является новой
            if (dataGridView_SMA.AllowUserToAddRows && dataGridView_SMA.Rows[rowCount - 1].IsNewRow)
            {
                rowCount--;
            }

            // исключаем заголовочную строку
            rowCount--;

            // убедимся, что результат не уходит в отрицательные значения
            rowCount = Math.Max(0, rowCount) + 1;

            // записываем результат в текстовое поле
            textBoxCount_SMA.Text = rowCount.ToString();
        }


        private void textBoxCount_SMA_TextChanged(object sender, EventArgs e)
        {
            // случайно создал, не трогаю, а то ошибка вылетит
        }

        private void buttonSumCalculate_SMA_Click(object sender, EventArgs e)
        {
            // проверка на то указан ли номер столбца
            if (string.IsNullOrWhiteSpace(textBoxSumWhichColumn_SMA.Text))
            {
                MessageBox.Show("Введите номер столбца для подсчёта суммы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // попытка преобразовать ввод в номер столбца
            if (!int.TryParse(textBoxSumWhichColumn_SMA.Text, out int columnIndex) || columnIndex < 1 || columnIndex > dataGridView_SMA.ColumnCount)
            {
                MessageBox.Show("Указан неверный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // приведение индекса к системе DataGridView (с учётом начала с 0)
            columnIndex--;

            // переменная для хранения суммы
            double sum = 0;

            // флаг для проверки ошибок в данных
            bool hasInvalidData = false;

            // итерация по строкам (кроме заголовочной)
            for (int i = 1; i < dataGridView_SMA.Rows.Count; i++)
            {
                // пропуск новой строки если она активна
                if (dataGridView_SMA.AllowUserToAddRows && dataGridView_SMA.Rows[i].IsNewRow)
                {
                    continue;
                }

                // попытка получить значение из ячейки
                var cellValue = dataGridView_SMA.Rows[i].Cells[columnIndex].Value;

                if (cellValue != null && double.TryParse(cellValue.ToString(), out double cellNumber))
                {
                    sum += cellNumber; // суммирование
                }
                else if (cellValue != null) // если данные не числовые
                {
                    hasInvalidData = true; // устанавливаем флаг ошибки
                }
            }

            // если обнаружены некорректные данные
            if (hasInvalidData)
            {
                MessageBox.Show("Некоторые ячейки в указанном столбце содержат некорректные данные (не числа). Они были пропущены при подсчёте.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // вывод суммы в текстовое поле
            textBoxSum_SMA.Text = sum.ToString();
        }


        private void textBoxSum_SMA_TextChanged(object sender, EventArgs e)
        {
            // случайно создал, не трогаю, а то ошибка вылетит
        }

        private void buttonMeanCalculate_SMA_Click(object sender, EventArgs e)
        {
            // проверка на то указан ли номер столбца
            if (string.IsNullOrWhiteSpace(textBoxMeanWhichColumn_SMA.Text))
            {
                MessageBox.Show("Введите номер столбца для подсчёта среднего значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // попытка преобразовать ввод в номер столбца
            if (!int.TryParse(textBoxMeanWhichColumn_SMA.Text, out int columnIndex) || columnIndex < 1 || columnIndex > dataGridView_SMA.ColumnCount)
            {
                MessageBox.Show("Указан неверный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // приведение индекса к системе DataGridView (с учётом начала с 0)
            columnIndex--;

            // переменные для подсчёта суммы и количества числовых элементов
            double sum = 0;
            int count = 0;

            // флаг для проверки ошибок в данных
            bool hasInvalidData = false;

            // итерация по строкам (кроме заголовочной)
            for (int i = 1; i < dataGridView_SMA.Rows.Count; i++)
            {
                // пропуск новой строки, если она активна
                if (dataGridView_SMA.AllowUserToAddRows && dataGridView_SMA.Rows[i].IsNewRow)
                {
                    continue;
                }

                // попытка получить значение из ячейки
                var cellValue = dataGridView_SMA.Rows[i].Cells[columnIndex].Value;

                if (cellValue != null && double.TryParse(cellValue.ToString(), out double cellNumber))
                {
                    sum += cellNumber; // добавляем к сумме
                    count++;           // увеличиваем счётчик
                }
                else if (cellValue != null) // если данные не числовые
                {
                    hasInvalidData = true; // устанавливаем флаг ошибки
                }
            }

            // если обнаружены некорректные данные
            if (hasInvalidData)
            {
                MessageBox.Show("Некоторые ячейки в указанном столбце содержат некорректные данные (не числа). Они были пропущены при подсчёте.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // вычисление среднего значения
            double mean = count > 0 ? sum / count : 0;

            // вывод среднего значения в текстовое поле
            textBoxMean_SMA.Text = mean.ToString();
        }

        private void textBoxMean_SMA_TextChanged(object sender, EventArgs e)
        {
            // случайно создал, не трогаю, а то ошибка вылетит
        }

        private void buttonMinCalculate_SMA_Click(object sender, EventArgs e)
        {
            // проверка на то указан ли номер столбца
            if (string.IsNullOrWhiteSpace(textBoxMinWhichColumn_SMA.Text))
            {
                MessageBox.Show("Введите номер столбца для подсчёта минимального значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // попытка преобразовать ввод в номер столбца
            if (!int.TryParse(textBoxMinWhichColumn_SMA.Text, out int columnIndex) || columnIndex < 1 || columnIndex > dataGridView_SMA.ColumnCount)
            {
                MessageBox.Show("Указан неверный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // приведение индекса к системе DataGridView (с учётом начала с 0)
            columnIndex--;

            // переменная для хранения минимального значения
            double? minValue = null;

            // флаг для проверки ошибок в данных
            bool hasInvalidData = false;

            // итерация по строкам (кроме заголовочной)
            for (int i = 1; i < dataGridView_SMA.Rows.Count; i++)
            {
                // пропуск новой строки если она активна
                if (dataGridView_SMA.AllowUserToAddRows && dataGridView_SMA.Rows[i].IsNewRow)
                {
                    continue;
                }

                // поптка получить значение из ячейки
                var cellValue = dataGridView_SMA.Rows[i].Cells[columnIndex].Value;

                if (cellValue != null && double.TryParse(cellValue.ToString(), out double cellNumber))
                {
                    if (minValue == null || cellNumber < minValue)
                    {
                        minValue = cellNumber; // обновлени минимального значения
                    }
                }
                else if (cellValue != null) // если данные не числовые
                {
                    hasInvalidData = true; // устанавливаем флаг ошибки
                }
            }

            // если обнаружены некорректные данные
            if (hasInvalidData)
            {
                MessageBox.Show("Некоторые ячейки в указанном столбце содержат некорректные данные (не числа). Они были пропущены при подсчёте.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // вывод минимального значения или сообщения если столбец пуст
            if (minValue.HasValue)
            {
                textBoxMin_SMA.Text = minValue.Value.ToString();
            }
            else
            {
                MessageBox.Show("В указанном столбце нет числовых данных.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMin_SMA.Text = string.Empty;
            }
        }


        private void textBoxMin_SMA_TextChanged(object sender, EventArgs e)
        {
            // случайно создал, не трогаю, а то ошибка вылетит
        }

        private void buttonMaxCalculate_SMA_Click(object sender, EventArgs e)
        {
            // проверка на то указан ли номер столбца
            if (string.IsNullOrWhiteSpace(textBoxMaxWhichColumn_SMA.Text))
            {
                MessageBox.Show("Введите номер столбца для подсчёта максимального значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // попытка преобразовать ввод в номер столбца
            if (!int.TryParse(textBoxMaxWhichColumn_SMA.Text, out int columnIndex) || columnIndex < 1 || columnIndex > dataGridView_SMA.ColumnCount)
            {
                MessageBox.Show("Указан неверный номер столбца.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // приведение индекса к системе DataGridView (с учётом начала с 0)
            columnIndex--;

            // переменная для хранения максимального значения
            double? maxValue = null;

            // флаг для проверки ошибок в данных
            bool hasInvalidData = false;

            // итерация по строкам (кроме заголовочной)
            for (int i = 1; i < dataGridView_SMA.Rows.Count; i++)
            {
                // пропуск новой строки, если она активна
                if (dataGridView_SMA.AllowUserToAddRows && dataGridView_SMA.Rows[i].IsNewRow)
                {
                    continue;
                }

                // попытка получить значение из ячейки
                var cellValue = dataGridView_SMA.Rows[i].Cells[columnIndex].Value;

                if (cellValue != null && double.TryParse(cellValue.ToString(), out double cellNumber))
                {
                    if (maxValue == null || cellNumber > maxValue)
                    {
                        maxValue = cellNumber; // обновление максимального значения
                    }
                }
                else if (cellValue != null) // если данные не числовые
                {
                    hasInvalidData = true; // устанавливаем флаг ошибки
                }
            }

            // если обнаружены некорректные данные
            if (hasInvalidData)
            {
                MessageBox.Show("Некоторые ячейки в указанном столбце содержат некорректные данные (не числа). Они были пропущены при подсчёте.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // вывод максимального значения или сообщения если столбец пуст
            if (maxValue.HasValue)
            {
                textBoxMax_SMA.Text = maxValue.Value.ToString();
            }
            else
            {
                MessageBox.Show("В указанном столбце нет числовых данных.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMax_SMA.Text = string.Empty;
            }
        }


        private void textBoxMax_SMA_TextChanged(object sender, EventArgs e)
        {
            // случайно создал, не трогаю, а то ошибка вылетит
        }

        private void buttonStatisticsClear_SMA_Click(object sender, EventArgs e)
        {
            textBoxCount_SMA.Clear(); // чистит все поля элементов статистики
            textBoxSum_SMA.Clear();
            textBoxSumWhichColumn_SMA.Clear();
            textBoxMean_SMA.Clear();
            textBoxMeanWhichColumn_SMA.Clear();
            textBoxMin_SMA.Clear();
            textBoxMinWhichColumn_SMA.Clear();
            textBoxMax_SMA.Clear();
            textBoxMaxWhichColumn_SMA.Clear();
        }
    }
}
