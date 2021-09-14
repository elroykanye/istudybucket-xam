using istudybucket.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace istudybucket.Views
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