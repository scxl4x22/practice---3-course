using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace isp2281337_v._12_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        TwoDigitNumber twoDigit = new();
        Parallelepiped parallelepiped = new();

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Content = d.ToString("HH:mm");
            date.Content = d.ToString("dd.MM.yyyy");
        }
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key < Key.D0 || e.Key > Key.D9)
            {
                if (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
                    e.Handled = true;
            }
            else e.Handled = false;
        }

        private void input_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void getVolume_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Int32.Parse(inputSideA.Text);
                double b = Int32.Parse(inputSideB.Text);
                double c = Int32.Parse(inputSideC.Text);
                outputVolume.Text = parallelepiped.Volume(a, b, c).ToString();
            }
            catch
            {

                MessageBox.Show("Проверьте данные", "Ошибка");
            }
        }

        private void getArea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Int32.Parse(inputSideA.Text);
                double b = Int32.Parse(inputSideB.Text);
                double c = Int32.Parse(inputSideC.Text);
                outputArea.Text = parallelepiped.Area(a, b, c).ToString();
            }
            catch
            {

                MessageBox.Show("Проверьте данные", "Ошибка");
            }
        }

        private void getSum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(inputTwoDigitNumber.Text);
                outputSum.Text = twoDigit.NumbersSum(x).ToString();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Скорее всего введено не двузначное число, проверьте", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Проверьте введенное число", "Ошибка");
            }
        }

        private void getProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = Int32.Parse(inputTwoDigitNumber.Text);
                outputProduct.Text = twoDigit.NumbersProduct(x).ToString();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Скорее всего введено не двузначное число, проверьте", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Проверьте введенное число", "Ошибка");
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12\n" +
                "Галстян ВЛадимир ИСП-34\n" +
                "Реализовать расчет задачи:\n" +
                "Даны длины ребер a, b, c прямоугольного параллелепипеда.Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).\n" +
                "Дано двузначное число.Найти сумму и произведение его цифр.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void firstTabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstTabItem.IsFocused)
                taskNumber.Content = firstTabItem.Header;
        }

        private void secondTabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            if (secondTabItem.IsFocused)
                taskNumber.Content = secondTabItem.Header;
        }
    }
}
