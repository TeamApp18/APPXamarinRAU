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
	public partial class Product_Qua : ContentPage
	{
        public List<Data> Qua = new List<Data>()
        {
            new Data{Name ="Quả táo Mỹ chà bá đỏ", Cost=25000, ContactImage="rau3.jpg" },
        };
		public Product_Qua ()
		{
			InitializeComponent ();
            ListOfFruitProducts.ItemsSource = Qua;

        }

        private void ClickDetail_Qua(object sender, ItemTappedEventArgs e)
        {
            var Qua = e.Item as Data;
            Navigation.PushAsync(new Detail_Qua(Qua.ContactImage,Qua.Name,Qua.Cost));
        }
    }
}