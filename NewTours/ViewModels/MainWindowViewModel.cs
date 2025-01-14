using Avalonia.Controls;
using ReactiveUI;

namespace NewTours.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        UserControl uc = new ToursView();

        public UserControl Uc { get => uc; set => this.RaiseAndSetIfChanged(ref uc, value); }
    }
}
