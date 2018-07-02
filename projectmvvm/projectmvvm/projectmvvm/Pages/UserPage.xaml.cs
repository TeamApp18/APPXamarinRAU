using projectmvvm.Page_ListProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectmvvm.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserPage : ContentPage
	{
		public UserPage ()
		{
			InitializeComponent ();
		}

        private async void tap_Tubers(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tubers());
        }

        private async void tap_Vegetables(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vegetables());
        }

        private async void tap_Fruit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Fruit());
        }
    }
}