using Avalonia.Controls;
using Avalonia.Interactivity;
using BD.SteamClient.Models;

namespace BD.WTTS.UI.Views.Pages;

public partial class MainFramePage : UserControl
{
    public MainFramePage()
    {
        InitializeComponent();
        DataContext ??= new IdleAppsPageViewModel();
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);

    }
}