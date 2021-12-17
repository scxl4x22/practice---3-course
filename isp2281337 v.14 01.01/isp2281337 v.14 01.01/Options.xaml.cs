﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace isp2281337_v._14_01._01
{
    /// <summary>
    /// Логика взаимодействия для Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MatrixSizeContainer.RowCount = Int32.Parse(newRowCount.Text);
                MatrixSizeContainer.ColumnCount = Int32.Parse(newColumnCount.Text);
                Close();
            }
            catch
            {
                MessageBox.Show("Проверьте ввыеденные значения", "Ошибка");
            }
           
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            currentRowCount.Text = MatrixSizeContainer.RowCount.ToString();
            currentColumnCount.Text = MatrixSizeContainer.ColumnCount.ToString();
        }
    }
}
