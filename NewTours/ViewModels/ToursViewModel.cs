using System;
using System.Collections.Generic;
using System.Net.Http;
using NewTours.Models;
using System.Threading.Tasks;
using ReactiveUI;
using Newtonsoft.Json;
using System.Data;
using System.Linq;
using System.Diagnostics;

namespace NewTours.ViewModels
{
	public class ToursViewModel : ReactiveObject
	{
		List<Tour> tourList;
		public List<Tour> TourList { get => tourList; set => this.RaiseAndSetIfChanged(ref tourList, value); }
        List<Models.Type> typeList;
        public List<Models.Type> TypeList { get => typeList; set => this.RaiseAndSetIfChanged(ref typeList, value); }

        Models.Type selectedType = new Models.Type();
        public Models.Type SelectedType { get => selectedType; set { selectedType = value; AllFilters(); } }

        string searchLine;
		public string SearchLine { get => searchLine;
            set
            {
                searchLine = value;
                AllFilters();
            }
        }

        bool checkActual = false; // поле для хранения значения флажка для отображения только котов мужского пола (по умолчанию флажок не выбран)
        public bool CheckActual  // свойство для обращения к полю, хранящему значение флажка
        {
            get => checkActual;
            set
            {
                checkActual = value;
                AllFilters(); // вызываем метод для фильтрации списка по выбранным параметрам
            }
        }

        public ToursViewModel()
		{
			GetTours();
            GetTypes();
        }

        public async Task GetTours()
		{
			HttpResponseMessage message = await MainWindowViewModel.Client.GetAsync("tourslist");
			string str = await message.Content.ReadAsStringAsync();
            TourList = JsonConvert.DeserializeObject<List<Tour>>(str);
        }

		public async Task AllFilters()
		{
            HttpResponseMessage message = await MainWindowViewModel.Client.GetAsync("tourslist");
            string str = await message.Content.ReadAsStringAsync();
            TourList = JsonConvert.DeserializeObject<List<Tour>>(str);
            if (!string.IsNullOrWhiteSpace(SearchLine))
            {
                TourList = TourList.Where(x => x.Name.ToLower().Contains(SearchLine.ToLower())).ToList();
            }

            if (selectedType != null && selectedType.Id != 0)
            {
                TourList = TourList.Where(x => x.ToursTypes.Any(y => y.TypeId == selectedType.Id)).ToList();
            }

            if (checkActual)
            {
                TourList = TourList.Where(x => x.IsActual == 1).ToList();
            }
        }

        public async Task GetTypes()
        {
            HttpResponseMessage message = await MainWindowViewModel.Client.GetAsync("typeslist");
            string str = await message.Content.ReadAsStringAsync();
            TypeList = JsonConvert.DeserializeObject<List<Models.Type>>(str);
            TypeList = [new Models.Type() { Id = 0, Type1 = "Все типы" }, ..MainWindowViewModel.myConnection.Types.ToList()];
        }
    }
}