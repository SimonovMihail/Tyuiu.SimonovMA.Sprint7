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
    public partial class FormGraphDrawer : Form
    {
        public FormGraphDrawer()
        {
            InitializeComponent();
        }

        private void buttonLoadFile_SMA_Click(object sender, EventArgs e)
        {
            // создаем диалог для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл для загрузки данных";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // чтение данных из файла
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);

                    // очистка всех данных в DataGridView
                    dataGridView_SMA.Rows.Clear();

                    // перебор строк из файла
                    foreach (var line in lines.Skip(1)) // пропускаем первую строку т.к. это заголовки
                    {
                        var cells = line.Split(';'); // разделитель - точка с запятой, как обычно

                        if (cells.Length >= 2) // проверяем чтобы строки содержали хотя бы два значения
                        {
                            // добавляем строку в DataGridView
                            dataGridView_SMA.Rows.Add(cells);
                        }
                    }

                    MessageBox.Show("Данные успешно загружены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClear_SMA_Click(object sender, EventArgs e)
        {
            // сохраняем заголовки столбцов
            var columns = dataGridView_SMA.Columns.Cast<DataGridViewColumn>()
                             .Select(c => c.HeaderText)
                             .ToList();

            // очистка всех строк
            dataGridView_SMA.Rows.Clear();
        }

        private void buttonDrawGraph_SMA_Click(object sender, EventArgs e)
        {
            // Проверка наличия данных в таблице
            if (dataGridView_SMA.Rows.Count <= 1) // Если в таблице нет данных, кроме заголовка
            {
                MessageBox.Show("Нет данных для отображения графика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Очистить текущие данные на графике
            chartDataGraph_SMA.Series.Clear();

            // Добавить новую серию для графика
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "График скорости по времени",
                IsVisibleInLegend = false,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line // Линия
            };

            // Прочитать данные из dataGridView_SMA
            foreach (DataGridViewRow row in dataGridView_SMA.Rows)
            {
                // Проверка на пустые строки или строки с невалидными данными
                if (row.IsNewRow) continue;

                try
                {
                    // Извлекаем данные из первого столбца (Скорость) и второго столбца (Время)
                    double speed = Convert.ToDouble(row.Cells[0].Value);
                    double time = Convert.ToDouble(row.Cells[1].Value);

                    // Добавляем точку на график
                    series.Points.AddXY(time, speed);
                }
                catch (Exception)
                {
                    // В случае ошибки (например, если значения не являются числами), пропускаем строку
                    continue;
                }
            }

            // Добавление серии на график
            chartDataGraph_SMA.Series.Add(series);

            // Настройка осей
            chartDataGraph_SMA.ChartAreas[0].AxisX.Title = "Время";
            chartDataGraph_SMA.ChartAreas[0].AxisY.Title = "Скорость";

            // Отобразить сообщение о завершении
            MessageBox.Show("График успешно нарисован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
