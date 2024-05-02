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

namespace calendar2
{
    /// <summary>
    /// Логика взаимодействия для KushatPage.xaml
    /// </summary>
    public partial class KushatPage : Page
    {
        public KushatPage()
        {
            InitializeComponent();
            Kushat Fructy = new Kushat();
            Fructy.ImageKushat.Source = new BitmapImage(new Uri("/image/Fructy.png", UriKind.Relative));
            Fructy.Edaname.Text = "Фрукты";
            Kushat pasta = new Kushat();
            pasta.ImageKushat.Source = new BitmapImage(new Uri("/image/pasta.png", UriKind.Relative));
            pasta.Edaname.Text = "Паста";
            Kushat shashlik = new Kushat();
            shashlik.ImageKushat.Source = new BitmapImage(new Uri("/image/Shashlik.png", UriKind.Relative));
            shashlik.Edaname.Text = "Шашлык";
            Kushat kvas = new Kushat();
            kvas.ImageKushat.Source = new BitmapImage(new Uri("/image/Kvas.png", UriKind.Relative));
            kvas.Edaname.Text = "Квас";

            List<Kushat> alcos = new List<Kushat>() { Fructy, pasta, shashlik, kvas };
            EdaList.ItemsSource = alcos;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new Chisla();
        }
    }
}
