using System.ComponentModel;
using Xamarin.Forms;
using MyPaisa.ViewModels;

namespace MyPaisa.Views
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
