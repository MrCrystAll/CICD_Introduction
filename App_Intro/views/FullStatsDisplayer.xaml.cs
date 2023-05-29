using App_Intro.model;

namespace App_Intro.views;

public partial class FullStatsDisplayer : BaseStatsDisplayer
{
    public Stats Level25 { get; set; }
    public Stats Level50 { get; set; }
    public Stats Level75 { get; set; }
    public Stats Level100 { get; set; }
    public Stats Level200 { get; set; }
    public FullStatsDisplayer()
    {
        InitializeComponent();
    }
}