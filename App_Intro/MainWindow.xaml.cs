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

namespace App_Intro
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

        private void Click_ShowHide(object sender, RoutedEventArgs e)
        {
            TextToShowHide.Visibility = TextToShowHide.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }

        private void OnPokemonClicked(object sender, SelectionChangedEventArgs e)
        {
            (Application.Current as App).Manager.SelectedPokemon = (sender as ListBox).SelectedItem as Pokemon;
            new Details().ShowDialog();
        }
    }
}
