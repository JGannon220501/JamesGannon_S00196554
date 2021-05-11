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

namespace JamesGannon_S00196554
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameData db;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new GameData();
            var query = from g in db.Games
                        select g.Name;
            GamesLbx.ItemsSource = query;
        }

        private void GamesLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = GamesLbx.SelectedItem as Game;
            if(selectedGame != null)
            {
                DetailsTblk.Text = $"Name: {selectedGame.Name}," +
                                   $"Description: {selectedGame.Description}, " +
                                   $"Platform: {selectedGame.Platform}, " +
                                   $"MetaCritic Score: {selectedGame.MetacriticScore}, " +
                                   $"Price: {selectedGame.Price}";
                image.Source = (ImageSource)(from i in db.Games
                               select i.GameImage);
            }
        }
    }
}
