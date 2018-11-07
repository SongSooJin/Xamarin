using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DataBinding3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // PushAsync is not supported globally on Android, please use
            // a NavigationPage 오류 발생을 방지하기 위해 NavigationPage를 사용
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
