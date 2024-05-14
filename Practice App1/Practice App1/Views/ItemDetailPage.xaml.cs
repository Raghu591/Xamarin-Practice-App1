using System.ComponentModel;
using Xamarin.Forms;
using Practice_App1.ViewModels;

namespace Practice_App1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}