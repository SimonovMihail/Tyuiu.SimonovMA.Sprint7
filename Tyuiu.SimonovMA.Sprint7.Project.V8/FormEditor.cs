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
    }
}
