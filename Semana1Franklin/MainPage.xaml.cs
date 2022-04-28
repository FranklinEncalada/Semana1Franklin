using System;
using Xamarin.Forms;

namespace Semana1Franklin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEviar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;

            DisplayAlert("mensaje de alerta", "BIENVENIDO " + nombre + "  " + apellido + "  " + " edad " + edad, "cerrar");



        }
    }
}
