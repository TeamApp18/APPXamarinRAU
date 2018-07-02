using projectmvvm.Service;
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
	public partial class LoginPages : ContentPage
	{
		public LoginPages ()
		{
			InitializeComponent ();
            navigationService = new NavigationService();
		}

        public NavigationService navigationService;
        private async void ClickLogin(object sender, EventArgs e)
        {
            navigationService.SetLoign();
        }

        private void ClickCreate(object sender, EventArgs e)
        {
            navigationService.setCreate();
        }
    }
}