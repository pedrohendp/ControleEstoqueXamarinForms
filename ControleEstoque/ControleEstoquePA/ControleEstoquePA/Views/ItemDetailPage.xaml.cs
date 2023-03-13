using ControleEstoquePA.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ControleEstoquePA.Views
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