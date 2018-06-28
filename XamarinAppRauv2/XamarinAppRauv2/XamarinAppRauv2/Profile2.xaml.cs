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
	public partial class Profile2 : ContentPage
	{
        public Profile2(string message)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
        }
    }
}