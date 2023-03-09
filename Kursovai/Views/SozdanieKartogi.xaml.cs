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
    /// Логика взаимодействия для SozdanieKartogi.xaml
    /// </summary>
    public partial class SozdanieKartogi : Window
    {
        public SozdanieKartogi()
        {
            
            InitializeComponent();
            Naprovlenie_TB.SelectedValuePath = "Ключ";
            Naprovlenie_TB.DisplayMemberPath = "Название";
            Naprovlenie_TB.ItemsSource = Classes.HelperClass.user16Entities.Направление.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(Naznagenie_TB.Text) || string.IsNullOrEmpty(Naprovlenie_TB.Text) /*|| string.IsNullOrEmpty(Data_DP.Text)*/ || string.IsNullOrEmpty(Opisanie_TB.Text)))
            {
                Models.Задача задача = new Models.Задача()

                {
                    НазваниеЗадачи = Naznagenie_TB.Text,
                    Направление = Naprovlenie_TB.SelectedItem as Models.Направление,
                    ДатаПоставленойЗадачи = DateTime.Now,
                    /*Data_DP.SelectedDate.Value,*/
                    Описание = Opisanie_TB.Text,
                    КлючСделанойРабочим = false,
                    КлючПроверки = false,
                };
                Classes.HelperClass.user16Entities.Задача.Add(задача);
                Classes.HelperClass.user16Entities.SaveChanges();
                MessageBox.Show("Задача создана");
                Naznagenie_TB.Text = "";
                Naprovlenie_TB.Text = "";
                //Data_DP.Text = "";
                Opisanie_TB.Text = "";
                Close();
               
            }
        }
    }    
}
