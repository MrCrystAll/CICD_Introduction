using System.Windows;
using System.Windows.Controls;
using App_Intro.model;

namespace App_Intro.views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = (Application.Current as App).Manager.Pokemons;
        }

        private void OnPokemonClicked(object sender, SelectionChangedEventArgs e)
        {
            (Application.Current as App).Manager.SelectedPokemon = (sender as ListBox).SelectedItem as Pokemon;
            new Details().ShowDialog();
        }
    }
}
