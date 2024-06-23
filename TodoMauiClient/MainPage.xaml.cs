using System.Diagnostics;
using TodoMauiClient.DataServices;
using TodoMauiClient.Models;
using TodoMauiClient.Pages;

namespace TodoMauiClient
{
    public partial class MainPage : ContentPage
    {
        private readonly IRestDataService _dataService;

        public MainPage(IRestDataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await _dataService.GetAllToDosAsync();
        }

        async void OnAddToDoClicked(object sender, EventArgs eventArgs)
        {
            Debug.WriteLine("---> Add button clicked");
            var navigationParameter = new Dictionary<string, object>
            {
                {nameof(ToDo), new ToDo() }
            };

            await Shell.Current.GoToAsync(nameof(ManageToDoPage), navigationParameter);
        }

        async void OnSelectionChanged(object sender,SelectionChangedEventArgs eventArgs)
        {
            Debug.WriteLine("---> Item changed clicked!");
            var navigationParameter = new Dictionary<string, object>
            {
                {nameof(ToDo), eventArgs.CurrentSelection.FirstOrDefault() as ToDo }
            };

            await Shell.Current.GoToAsync(nameof(ManageToDoPage), navigationParameter);
        }
    }

}
