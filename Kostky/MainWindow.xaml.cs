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

namespace Kostky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Kostka[] kostky = new Kostka[];
        Kostka[] kostky = new Kostka[]{
        new Kostka(),
        new Kostka(),
        new Kostka(),
        new Kostka(),
        new Kostka(),
        new Kostka()
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ZobrazKostky()
        {
            Kostka0.Content = kostky[0].Hodnota;
            Kostka1.Content = kostky[1].Hodnota;
            Kostka2.Content = kostky[2].Hodnota;
            Kostka3.Content = kostky[3].Hodnota;
            Kostka4.Content = kostky[4].Hodnota;
            Kostka5.Content = kostky[5].Hodnota;
        }

        private void btnGandalf_Click(object sender, RoutedEventArgs e)
        {
            foreach (var kostka in kostky)
            {
                kostka.Hod();
            }
            ZobrazKostky();
        }
        private int SpocitejBody()
        {
            int body = 0;
            Dictionary<int, int> pocty = new Dictionary<int, int>();
        }
        return body;
    }
}
