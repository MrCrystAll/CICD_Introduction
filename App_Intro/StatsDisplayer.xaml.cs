using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace App_Intro;

public partial class StatsDisplayer
{

    public static readonly DependencyProperty StatsProperty = DependencyProperty.Register(
        nameof(Stats), typeof(Stats), typeof(StatsDisplayer), new PropertyMetadata(default(Stats)));
    public Stats Stats
    {
        get => (Stats)GetValue(StatsProperty);
        set => SetValue(StatsProperty, value);
    }
    
    public StatsDisplayer()
    {
        InitializeComponent();
    }
}