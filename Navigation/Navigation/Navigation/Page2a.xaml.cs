using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2a : ContentPage
    {
        public Page2a()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}