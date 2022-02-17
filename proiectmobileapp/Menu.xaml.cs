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
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        async void OnC(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartiPage
            {
                BindingContext = new Carti()
            });
        }
        async void Vizualizare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VizualizareCarti
            {
                BindingContext = new Carti()
            });
        }
    }
}