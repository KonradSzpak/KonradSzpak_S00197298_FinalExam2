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

namespace KonradSzpak_S00197298_FinalExam2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from g in db.Games
                        select g;


            lbGames.ItemsSource = query.ToList();

        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



            Game selectedGame = lbGames.SelectedItem as Game;

            if (selectedGame != null)
            {
                imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                tbPrice.Text = $"{selectedGame.Price:C}";
            }



            

        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            if(rPC.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "PC"
                            select g;

                lbGames.ItemsSource = query.ToList();

            }
        }
    }
}
