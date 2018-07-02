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
	public partial class RegistrationPages : ContentPage
	{
        public NavigationService navigationService;
        public RegistrationPages ()
		{
			InitializeComponent ();
            navigationService = new NavigationService();
        }

        private void ClickAcesstCreate(object sender, EventArgs e)
        {
            navigationService.SetAcesstCreate();
        }
    }
}