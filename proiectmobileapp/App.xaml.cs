using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using proiectmobileapp.Data;
using System.IO;
namespace proiectmobileapp
{
    public partial class App : Application
    {
        static CartiDB database;
        public static CartiDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   CartiDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "CartiDB.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Menu());
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
