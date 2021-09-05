using Gamebanana_Android_Client.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Gamebanana_Android_Client.Views
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