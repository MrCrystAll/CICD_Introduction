using System.Windows;
using System.Windows.Controls;
using App_Intro.model;

namespace App_Intro.views;

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