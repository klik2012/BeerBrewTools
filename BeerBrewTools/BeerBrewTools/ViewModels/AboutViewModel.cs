using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BeerBrewTools.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            
              Title = "About";
              OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.vsezapivo.si/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}