using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2_4.View;
using Xamarin.Forms;

namespace Ejercicio2_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            var paginaCrear = new VideosView();

            await Navigation.PushAsync(paginaCrear);
        }

        private async void btnSwipe_Clicked(object sender, EventArgs e)
        {
            var paginaLista = new ListaDeVideo();

            await Navigation.PushAsync(paginaLista);
        }
    }
}
