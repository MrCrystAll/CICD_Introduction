using System.Windows;
using System.Windows.Controls;
using App_Intro.model;

namespace App_Intro.views;

public partial class OnePokemonLabel : UserControl
{

    public static readonly DependencyProperty PokemonProperty = DependencyProperty.Register(
        nameof(Pokemon), typeof(Pokemon), typeof(OnePokemonLabel), new PropertyMetadata(default(Pokemon)));

    public Pokemon Pokemon
    {
        get { return (Pokemon)GetValue(PokemonProperty); }
        set { SetValue(PokemonProperty, value); }
    }
    
    public OnePokemonLabel()
    {
        InitializeComponent();
    }
}