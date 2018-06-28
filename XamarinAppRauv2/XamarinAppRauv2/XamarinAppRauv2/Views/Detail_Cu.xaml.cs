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
	public partial class Detail_Cu : ContentPage
	{
		public Detail_Cu (string ContactImage, string Name, double Cost)
		{
			InitializeComponent ();
            imgtubers.Source = ContactImage;
            NameEntry.Text = Name;
            CostEntry.Text = Cost.ToString();
		}
	}
}