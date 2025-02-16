using System.Net.Http.Json;
using Avalonia.Controls;
using ReactiveUI;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using NewTours.Models;

namespace NewTours.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        UserControl uc = new ToursView();

        public static PostgresContext myConnection = new PostgresContext();
        private static HttpClient client;

        public UserControl Uc { get => uc; set => this.RaiseAndSetIfChanged(ref uc, value); }
        public static HttpClient Client { get
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7065/");
                return client;
            }
        }

        public static MainWindowViewModel Instance;

        public MainWindowViewModel() {
            Instance = this;
        }
        
    }
}
