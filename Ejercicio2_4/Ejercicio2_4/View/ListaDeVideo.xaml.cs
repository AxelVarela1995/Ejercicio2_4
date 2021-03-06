using System;
using System.Collections.Generic;
using System.Linq;
using Ejercicio2_4.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio2_4.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaDeVideo : ContentPage
    {
        public List<Video> AllVideos { get; set; }
        public string pathSelectedVideo;
        public ListaDeVideo()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarDatos();
        }

        private async void CargarDatos()
        {
            AllVideos = await App.BaseDatos.ObtenerListaVideos();
            ListVideos.ItemsSource = AllVideos;
        }


        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VerVideos(pathSelectedVideo));
            pathSelectedVideo = null;
        }

        private void ListVideos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectionData(e.PreviousSelection, e.CurrentSelection);
        }


        private void UpdateSelectionData(IEnumerable<object> previousSelectedContact, IEnumerable<object> currentSelectedContact)
        {
            var selectedContact = currentSelectedContact.FirstOrDefault() as Video;
            pathSelectedVideo = selectedContact.ruta;
            Console.WriteLine(pathSelectedVideo);
        }
    }
}