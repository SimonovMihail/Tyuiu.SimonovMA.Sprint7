using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SimonovMA.Sprint7.Project.V8.Lib;

namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    public partial class FormFuelCalculate : Form
    {
        DataService ds = new DataService();

        public FormFuelCalculate()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxFuelConsumed_SMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFuelConsumed_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void textBoxKilometersRode_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void textBoxFuelPrice_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void buttonCalculate_SMA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFuelPrice_SMA.Text))
                {
                    textBoxResult_SMA.Text = Convert.ToString(ds.FuelConsuptionCalculate(Convert.ToDouble(textBoxFuelConsumed_SMA.Text), Convert.ToDouble(textBoxKilometersRode_SMA.Text)));
                    textBoxResultPrice_SMA.Text = "-";
                }
                else
                {
                    textBoxResult_SMA.Text = Convert.ToString(ds.FuelConsuptionCalculate(Convert.ToDouble(textBoxFuelConsumed_SMA.Text), Convert.ToDouble(textBoxKilometersRode_SMA.Text)));
                    textBoxResultPrice_SMA.Text = Convert.ToString(ds.FuelPriceCalculate(Convert.ToDouble(textBoxFuelConsumed_SMA.Text), Convert.ToDouble(textBoxFuelPrice_SMA.Text)));
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
