using ControleEstoquePA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleEstoquePA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();

        }

        private async void OnRegisterLabel_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage()
            {
                BindingContext = new RegisterPageViewModel()
            });
        }

        public ImageSource ImageSourceTelaInicial { get; set; }

    }
}