using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicio2_4.View;
using Ejercicio2_4.Models;
using System.IO;

namespace Ejercicio2_4

{
    public partial class App : Application
    {

        static BaseDatos database;
        public static BaseDatos BaseDatos
        {
            get
            {
                if (database == null)
                {
                    database = new BaseDatos (Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Mydatabase.db3"));
                }

                return database;
            }


        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
