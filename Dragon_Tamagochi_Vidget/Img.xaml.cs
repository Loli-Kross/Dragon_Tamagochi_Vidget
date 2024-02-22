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


namespace Dragon_Tamagochi_Vidget
{
    /// <summary>
    /// Логика взаимодействия для Img.xaml
    /// </summary>
    public partial class Img : Page
    {
        public Img()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.MainWindow.Close();
        }
        

    }
}
