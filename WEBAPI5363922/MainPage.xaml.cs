using WEBAPI5363922.Servicios;

namespace WEBAPI5363922
{
    public partial class MainPage : ContentPage
    {

        private readonly IRickAndMortyServices _rickAndMortyServices;

        public MainPage(IRickAndMortyServices service)
        {
            InitializeComponent();
            _rickAndMortyServices = service;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;

            var data = await _rickAndMortyServices.Obtener();
            listViewPersonajes.ItemsSource = data;

            loading.IsVisible = false;
        }
    }

}
