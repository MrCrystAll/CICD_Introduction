using System.Windows;
using System.Windows.Controls;

namespace App_Intro;

public partial class DataRow : UserControl
{
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
        nameof(Title), typeof(string), typeof(DataRow), new PropertyMetadata(default(string)));
    
    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }

    public static readonly DependencyProperty StatProperty = DependencyProperty.Register(
        nameof(Stat), typeof(Stats), typeof(DataRow), new PropertyMetadata(default(Stats)));

    public Stats Stat
    {
        get { return (Stats)GetValue(StatProperty); }
        set { SetValue(StatProperty, value); }
    }
    
    
    public DataRow()
    {
        InitializeComponent();
    }
}