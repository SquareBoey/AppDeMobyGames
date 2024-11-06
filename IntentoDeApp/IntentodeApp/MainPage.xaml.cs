using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IntentodeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Jose")
            {
                if (txtPassword.Text == "1234")
                {
                    DisplayAlert("Success", "Bienvenido al sistema " + txtUsuario.Text, "Continue");
                }
                else
                {
                    DisplayAlert("Alert", "Error, Contraseña incorrecta para el usuario asignado", "ok");
                }
            }
            else
            {
                DisplayAlert("Alert", "Error, El usuario no existe o esta incorrecto", "Ok");
            }
        }
    }
}
