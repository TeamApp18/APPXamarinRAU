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
    public partial class Product_Cu : ContentPage
    {
        public List<Data> Cu = new List<Data>()
        {
            new Data{Name="Củ cà rốt", Cost=5000, ContactImage="rau2.jpg"},
        };
		public Product_Cu ()
		{
			InitializeComponent ();
            ListOfTubersProducts.ItemsSource = Cu;

        }

        private void ClickDetail_Cu(object sender, ItemTappedEventArgs e)
        {
            var Cu = e.Item as Data;
            Navigation.PushAsync(new Detail_Cu(Cu.ContactImage, Cu.Name, Cu.Cost));
        }
    }
}