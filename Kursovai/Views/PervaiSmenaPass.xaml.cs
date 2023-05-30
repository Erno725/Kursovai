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
    /// Логика взаимодействия для PervaiSmenaPass.xaml
    /// </summary>
    public partial class PervaiSmenaPass : Window
    {
        public PervaiSmenaPass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //перичная смена пароля 
            if (!(  string.IsNullOrEmpty(Pass1.Text) || string.IsNullOrEmpty(Pass2.Text)))
            {
              if( Pass1.Text == Pass2.Text )
                {
                    Classes.HelperClass.сотрудник.Пароль = Pass1.Text;
                    Classes.HelperClass.сотрудник.ПервыйВход = true;
                    Classes.HelperClass.user16Entities.SaveChanges();
                    Close();
                  }
              else
                {
                    MessageBox.Show("пороли не совпадают");
                }
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
