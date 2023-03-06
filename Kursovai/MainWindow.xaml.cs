using Kursovai.Views;
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

namespace Kursovai
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(Log_TB.Text) || string.IsNullOrEmpty(Pass_TB.Text)))
            {
                //первичный вход
                var user = Classes.HelperClass.user16Entities.Сотрудник.FirstOrDefault(i => i.Логин == Log_TB.Text && i.Пароль == Pass_TB.Text );
                //пользователь
               
                if   (user != null)
                {
                    Classes.HelperClass.сотрудник = user;

                }

                else
                {
                    MessageBox.Show("данные введины не верно");
                    return;
                }
                if (Classes.HelperClass.сотрудник.ПервыйВход == false )
                {
                    // MessageBox.Show("первичный вход");
                    PervaiSmenaPass pervaiSmenaPass = new PervaiSmenaPass();
                    pervaiSmenaPass.ShowDialog();
                    //Close();
                }
                if (Classes.HelperClass.сотрудник.КлючРоль == 1)
                {
                    PolizovateliGlavnoe polizovateliGlavnoe = new PolizovateliGlavnoe();
                    polizovateliGlavnoe.Show();
                    Close();
                }
                if (Classes.HelperClass.сотрудник.КлючРоль == 2)
                {
                    RabogiGlavnoe rabogiGlavnoe = new RabogiGlavnoe();
                    rabogiGlavnoe.Show();
                    Close();
                }
                if (Classes.HelperClass.сотрудник.КлючРоль == 3)
                {
                    AdminGlavnoe adminGlavnoe = new AdminGlavnoe();
                    adminGlavnoe.Show();
                    Close();
                }
              

            }
            else
            {
                MessageBox.Show("введите поля");
            }

        }

        
    }
}
