using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void  Ingresar_Clicked(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUsuario.Text))
            {

              await  DisplayAlert("Validacion", "El nombre de usuario es requerido", "ok");
                    txtUsuario.Focus();
                return;


            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {

             await  DisplayAlert("Validacion", "La contraseña de usuario es requerido", "ok");
                txtPassword.Focus();
                return;


            }

            await Navigation.PushAsync(new views.ContenPage());




        }
    }
}