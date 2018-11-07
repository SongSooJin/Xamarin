using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//  ListView 심플 데이터 바인딩, 컬렉션 바인딩(Collection Binding), ListView에서 
// 클릭시 새창 띄우면서 데이터 넘기기

namespace DataBinding3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listView.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                var emp = e.SelectedItem as Emp;

                //await DisplayAlert("Tapped!", e.SelectedItem + " was tapped.", "OK"); 
                var nextPage = new NextPage();
                nextPage.BindingContext = emp;
                await Navigation.PushAsync(nextPage);
            };
        }
    }
}
