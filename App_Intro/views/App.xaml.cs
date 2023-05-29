using System.Windows;

namespace App_Intro.views
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager Manager { get; set; } = new Manager();
    }
}
