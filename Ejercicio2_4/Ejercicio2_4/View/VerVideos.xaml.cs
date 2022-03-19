using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Forms.VideoPlayer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio2_4.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerVideos : ContentPage
    {
        public VerVideos(string rutaVideo)
        {
            InitializeComponent();

            UriVideoSource uriVideoSource = new UriVideoSource()
            {
                Uri = rutaVideo
            };

            videoPlayer.Source = uriVideoSource;
        }

        private async void CloseButton_Clicked(object sender, EventArgs e)
        {
            videoPlayer.Pause();
            await Navigation.PopAsync();
        }

        private void videoPlayer_PlayCompletion(object sender, EventArgs e)
        {

        }
    }
}