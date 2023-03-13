using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleEstoquePA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void OnRegisterButtonClicked (object sender, EventArgs e)
        {
            //logica se necessario ir para uma prox pagina
        }
    }
}