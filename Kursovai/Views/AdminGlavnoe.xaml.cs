using Kursovai.Models;
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
    /// Логика взаимодействия для AdminGlavnoe.xaml
    /// </summary>
    public partial class AdminGlavnoe : Window
    {
        public AdminGlavnoe()
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SozdanieKartogi sozdanieKartogi = new SozdanieKartogi();
            sozdanieKartogi.ShowDialog();
            GridUchet.ItemsSource = Classes.HelperClass.user16Entities.Задача.ToList();


        }

        private void GridUchet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {        
                    Classes.HelperClass.задача.КлючСделанойРабочим = true;
                    Classes.HelperClass.user16Entities.SaveChanges(); 
            }

        private void Ot_DP_CalendarClosed(object sender, RoutedEventArgs e)
        {
            filterDAta();
        }
        
        private void filterDAta()
            //фильтрация по дате 
        {
            if (!(string.IsNullOrEmpty(Ot_DP.Text) || string.IsNullOrEmpty(Posl_DP.Text)))
            {
                GridUchet.ItemsSource = Classes.HelperClass.user16Entities.Задача.Where(i => i.ДатаПоставленойЗадачи >= (DateTime)Ot_DP.SelectedDate && i.ДатаПоставленойЗадачи <= (DateTime)Posl_DP.SelectedDate).ToList();
            }
        }

        private void Posl_DP_CalendarClosed(object sender, RoutedEventArgs e)
        {
            filterDAta();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //сброс фильтра 
            Ot_DP.Text = "";
            Posl_DP.Text = "";
            GridUchet.ItemsSource = Classes.HelperClass.user16Entities.Задача.ToList();
        }

        private void GridUchet_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(((Задача)GridUchet.SelectedItem).КлючСделанойРабочим )
            {
                
                Classes.HelperClass.user16Entities.Задача.First(i => i.Ключ == ((Задача)GridUchet.SelectedItem).Ключ).КлючПроверки = true;
                Classes.HelperClass.user16Entities.SaveChanges();
                GridUchet.ItemsSource = Classes.HelperClass.user16Entities.Задача.ToList();
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //this.DragMove();
        }



        //    CmbKomnat.SelectedValuePath = "id"; 
        //    CmbKomnat.DisplayMemberPath = "KolKomnat"; 
        //    CmbKomnat.ItemsSource = AppData.ModelHelper.entities.Komnati.ToList(); 

        //    CmbSanuzl.SelectedValuePath = "id"; 
        //    CmbSanuzl.DisplayMemberPath = "Kolichestvo"; 
        //    CmbSanuzl.ItemsSource = AppData.ModelHelper.entities.Sanuzli.ToList(); 

        //    CmbKond.SelectedValuePath = "id"; 
        //    CmbKond.DisplayMemberPath = "Nalichie"; 
        //    CmbKond.ItemsSource = AppData.ModelHelper.entities.Kondicioner.ToList(); 

        //    CmbFiltr.SelectedValuePath = "id"; 
        //    CmbFiltr.DisplayMemberPath = "KolKomnat"; 
        //    CmbFiltr.ItemsSource = AppData.ModelHelper.entities.Komnati.ToList(); 

        //    CmbOkno.SelectedValuePath = "id"; 
        //    CmbOkno.DisplayMemberPath = "Okna"; 
        //    CmbOkno.ItemsSource = AppData.ModelHelper.entities.RaspolojenieOkna.ToList();
    }
    }
