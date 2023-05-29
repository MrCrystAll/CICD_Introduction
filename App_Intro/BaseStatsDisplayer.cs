using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace App_Intro;

public abstract class BaseStatsDisplayer : UserControl
{
    public static readonly DependencyProperty StatsProperty = DependencyProperty.Register(
        nameof(Stats), typeof(Stats), typeof(BaseStatsDisplayer), new PropertyMetadata(default(Stats)));
    public Stats Stats
    {
        get => (Stats)GetValue(StatsProperty);
        set => SetValue(StatsProperty, value);
    }
}