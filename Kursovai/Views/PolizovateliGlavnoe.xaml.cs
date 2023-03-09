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
using System.Windows.Shapes;

namespace Kursovai.Views
{
    /// <summary>
    /// Логика взаимодействия для PolizovateliGlavnoe.xaml
    /// </summary>
    public partial class PolizovateliGlavnoe : Window
    {
        public PolizovateliGlavnoe()
        {
            InitializeComponent();
            GridUchet.ItemsSource = Classes.HelperClass.user16Entities.Задача.ToList();
            //дата
            TimerX.Content = DateTime.Now.ToString("dd:MMMM:yyyy");
            TimerY.Content = DateTime.Now.ToString("HH:mm:ss");
            //время
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, e) => { TimerY.Content = DateTime.Now.ToString("HH:mm:ss"); };
            timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //переход на авторизацию
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //переход на создание карточки 
            SozdanieKartogi sozdanieKartogi = new SozdanieKartogi();
            sozdanieKartogi.ShowDialog();
            // обновление таблицы
            GridUchet.ItemsSource = Classes.HelperClass.user16Entities.Задача.ToList();
        }
    }
}
