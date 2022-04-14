using System;
using System.ComponentModel.Design;
using Xamarin.Forms;
using BeerBrewTools.Models;

namespace BeerBrewTools.Views
{
    

    public partial class NewItemPage : ContentPage
    {
        //public Note Note { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            /*Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };*/

            //BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            // Kontrola da so izpolnjeni vsi podatki
            if ((string.IsNullOrEmpty(note.BeerType)) || (note.FinalGravity <= 0) || (note.OrigGravity <= 0))
            {
                Application.Current.MainPage.DisplayAlert("Alert", "All fields needs to be fulfilled, or be greater than 0.0!", "Try Again");
                //  throw new Exception("test");
                await Navigation.PopAsync();
            }
            else 
            {
                note.Date = DateTime.UtcNow;
                await App.Database.SaveNoteAsync(note);
                await Navigation.PopAsync();
            }
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PopModalAsync();
            await Navigation.PopAsync();
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var note = (Note)BindingContext;
            note.NotifyChanges();
        }
    }
}



/*public partial class NewItemPage : ContentPage
{
    public Item Item { get; set; }

    public NewItemPage()
    {
        InitializeComponent();

        Item = new Item
        {
            Text = "Item name",
            Description = "This is an item description."
        };

        BindingContext = this;
    }

    async void Save_Clicked(object sender, EventArgs e)
    {
        MessagingCenter.Send(this, "AddItem", Item);
        await Navigation.PopModalAsync();
    }

    async void Cancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
}*/
