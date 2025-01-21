using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using NewTours.ViewModels;

namespace NewTours;

public partial class ToursView : UserControl
{
    public ToursView()
    {
        InitializeComponent();
        DataContext = new ToursViewModel();
    }
}