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
	public partial class Detail_Qua : ContentPage
	{
		public Detail_Qua (string ContactImage, string Name, double Cost)
		{
			InitializeComponent ();
            imgfruit.Source = ContactImage;
            NameEntry.Text = Name;
            CostEntry.Text = Cost.ToString();
        }
	}
}