using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace App_Intro;

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