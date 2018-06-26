using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppRauv2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
			InitializeComponent ();
		}

        private void ClickProduct(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Product());
        }

        private void ClickIntroduction(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Introduction());
        }
    }
}