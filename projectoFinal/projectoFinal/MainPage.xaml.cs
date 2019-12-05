using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projectoFinal
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Gracias", "Datos obtenidos satisfactoriamente", "OK");
            
            nombre.Text = String.Empty;
            primerApellido.Text = String.Empty;
            segundoApellido.Text = String.Empty;
            fechaNacimiento.Date = DateTime.Today;
            correoElectronico.Text = String.Empty;
            telefonoContacto.Keyboard = null;
            contrasena.Text = String.Empty;
            contrasenaReescritura.Text = String.Empty;
        }

        }
    }
