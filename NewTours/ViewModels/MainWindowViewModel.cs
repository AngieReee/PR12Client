using System.Net.Http.Json;
using Avalonia.Controls;
using ReactiveUI;
using Newtonsoft.Json;
using System.Net.Http;
using System;

namespace NewTours.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        UserControl uc = new ToursView();

        public UserControl Uc { get => uc; set => this.RaiseAndSetIfChanged(ref uc, value); }

        public static MainWindowViewModel Instance;

        public MainWindowViewModel() {
            HttpClient client = new HttpClient(); //поле для обащения к клиенту
            client.BaseAddress = new Uri("https://localhost:7065");
            Instance = this;
        }
        
    }
}
