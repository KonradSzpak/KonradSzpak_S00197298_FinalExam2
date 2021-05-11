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
        //loads in the data into the listbox
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        select g;

            lbGames.ItemsSource = query.ToList();
        }
        //selection changed changes the image and price
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = lbGames.SelectedItem as Game;

            if (selectedGame != null)
            {
                imgGame.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                tbPrice.Text = $"{selectedGame.Price:C}";
                tbName.Text = $"{selectedGame.Name}";
                tbCS.Text = $"{selectedGame.CriticScore}";
                tbDesc.Text = $"{selectedGame.Description}";
            }
        }
        //filters the data
        private void r_Click(object sender, RoutedEventArgs e)
        {
            

            if (rPS.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "PS"
                            select g;

                lbGames.ItemsSource = query.ToList();
            }
            if(rNS.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "Switch"
                            select g;

                lbGames.ItemsSource = query.ToList();
            }
            if(rXB.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "Xbox"
                            select g;
                lbGames.ItemsSource = query.ToList();
            }
            if(rPC.IsChecked == true)
            {
                var query = from g in db.Games
                            where g.Platform == "PC, Xbox, PS, Switch"
                            select g;

                lbGames.ItemsSource = query.ToList();
            }
        }
    }
}
