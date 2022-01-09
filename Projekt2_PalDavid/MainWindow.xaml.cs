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

namespace Projekt2_PalDavid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer idozito;
        int hatar = 13;
        int hatar2 = 23;

        public MainWindow()
        {
            InitializeComponent();
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(1);
            idozito.Tick += new EventHandler(Csigahaladas);
        }

        private void Csigahaladas(object sender, EventArgs e)
        {
            Random rnd = new Random();
            csiga1.Margin = new Thickness(hatar += rnd.Next(10, 30), 54, 0, 0);
            csiga2.Margin = new Thickness(hatar += rnd.Next(10, 30), 232, 0, 0);
            csiga3.Margin = new Thickness(hatar2 += rnd.Next(10, 30), 417, 0, 0);

        }
        private void start_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
        }
    }
}
