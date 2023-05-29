using System.Windows;
using System.Windows.Controls;
using App_Intro.model;

namespace App_Intro.views;

public partial class DataColumn : UserControl
{
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
        nameof(Title), typeof(string), typeof(DataColumn), new PropertyMetadata(default(string)));
    
    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }

    public static readonly DependencyProperty StatProperty = DependencyProperty.Register(
        nameof(Stat), typeof(Stats), typeof(DataColumn), new PropertyMetadata(default(Stats)));

    public Stats Stat
    {
        get { return (Stats)GetValue(StatProperty); }
        set { SetValue(StatProperty, value); }
    }
    
    
    public DataColumn()
    {
        InitializeComponent();
    }
}