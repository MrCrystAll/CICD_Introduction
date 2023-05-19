using System.Windows;

namespace App_Intro;

public partial class Details : Window
{
    public Details()
    {
        InitializeComponent();
        DataContext = (Application.Current as App).Manager.SelectedPokemon;
    }
}