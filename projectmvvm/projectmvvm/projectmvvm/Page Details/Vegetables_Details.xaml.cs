using projectmvvm.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectmvvm.Page_Details
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Vegetables_Details : ContentPage
	{
		public Vegetables_Details (classVegetables vegetable)
		{
			InitializeComponent ();
            Details_ImageVegetables.Source = vegetable.Vegetables_Image;
            Details_NameVegetables.Text = vegetable.Vegetables_Name;
            Details_DescribeVegetables.Text = vegetable.Vegetables_Describes;
            Details_PriceVegetables.Text = vegetable.Vegetables_Price;
            Details_PointVegetables.Text = vegetable.Vegetables_Point;
            Details_IdVegetables.Text = vegetable.Vegetables_Id;
            Details_InventoryVegetables.Text = vegetable.Vegetables_Inventory;
		}
	}
}