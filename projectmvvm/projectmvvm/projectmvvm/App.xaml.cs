using projectmvvm.Class;
using projectmvvm.Page_Details;
using projectmvvm.Page_ListProduct;
using projectmvvm.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace projectmvvm
{
	public partial class App : Application
	{
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }

        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new LoginPages());
		}





		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
