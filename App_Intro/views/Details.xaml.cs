using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using App_Intro.model;

namespace App_Intro.views;

public partial class Details : Window
{
    
    public Details()
    {
        
        InitializeComponent();
        var pokemon = (Application.Current as App).Manager.SelectedPokemon;
        DataContext = pokemon;
        
        pokemon.BaseStats.EVs.CollectionChanged += OnCollectionChanged;
        pokemon.BaseStats.IVs.CollectionChanged += OnCollectionChanged;
        pokemon.BaseStats.PropertyChanged += BaseStatsOnPropertyChanged;
    }

    private void BaseStatsOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        NewStats.Stats = (DataContext as Pokemon).BaseStats.CalculateStats();
    }

    private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        NewStats.Stats = (DataContext as Pokemon).BaseStats.CalculateStats();
    }
}