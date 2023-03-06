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
    /// Логика взаимодействия для RabogiGlavnoe.xaml
    /// </summary>
    public partial class RabogiGlavnoe : Window
    {
        public RabogiGlavnoe()
        {
            InitializeComponent();
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
    }
}
