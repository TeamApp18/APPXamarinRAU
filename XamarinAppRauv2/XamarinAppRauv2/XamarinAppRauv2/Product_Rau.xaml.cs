using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppRauv2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Product_Rau : ContentPage
	{
        public List<Data> rau = new List<Data>()
        {
            new Data{Name = "Rau xanh", Cost=15000 , ContactImage="rau7.jpg" },
        };

		public Product_Rau ()
		{
			InitializeComponent ();
            ListOfVegetableProducts.ItemsSource = rau;

        }

        private void ClickDetail_Rau(object sender, ItemTappedEventArgs e)
        {
            var Rau = e.Item as Data;
            Navigation.PushAsync(new Detail_Rau(Rau.ContactImage, Rau.Name, Rau.Cost));
        }
    }
}