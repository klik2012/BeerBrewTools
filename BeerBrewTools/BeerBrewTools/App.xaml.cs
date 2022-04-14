using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BeerBrewTools.Services;
using BeerBrewTools.Views;
using BeerBrewTools.Data;
using System.IO;

namespace BeerBrewTools
{
    public partial class App : Application
    {
        static LogDatabase database;
        public static LogDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new LogDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
