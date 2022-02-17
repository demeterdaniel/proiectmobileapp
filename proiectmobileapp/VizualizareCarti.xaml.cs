using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proiectmobileapp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proiectmobileapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VizualizareCarti : ContentPage
    {
        public VizualizareCarti()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetCartiAsync();
        }
        async void CartiCitite(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartiPage
            {
                BindingContext = new Carti()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Pagina
                {
                    BindingContext = e.SelectedItem as Carti
                });
            }
        }
    }
}