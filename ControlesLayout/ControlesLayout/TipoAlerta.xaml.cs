using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoAlerta : ContentPage
    {
        public TipoAlerta()
        {
            InitializeComponent();
            this.botonsimple.Clicked += (sender, args) =>
            {
                DisplayAlert("Titulo", "Mensaje simple", "OK");
            };

            this.botonokcancel.Clicked += Botonokcancel_Clicked;
            this.botonopciones.Clicked += Botonoopciones_Clicked;
            this.botonmodal.Clicked += Botonmodal_Clicked;
        }

        private async void Botonmodal_Clicked(object sender, EventArgs e)
        {
            PaginaModal modal = new PaginaModal();
            await Navigation.PushModalAsync(modal);
        }

        private async void Botonokcancel_Clicked(object sender, EventArgs e)
        {
            bool respuesta = await DisplayAlert("Pregunta...", "Real Madrid campeón de liga??", "Si", "No");
            if (respuesta)
            {
                this.lblrespuesta.Text = "Tu si que sabes...";
            }
            else
            {
                this.lblrespuesta.Text = "No tienes ni idea...";
            }
        }

        private async void Botonoopciones_Clicked(object sender, EventArgs e)
        {
            string opcion = await DisplayActionSheet("Que empresa quereis?", "Cancelar", "MacDonalds", "Empresa1", "Empresa2");
            this.lblrespuesta.Text = opcion;
        }
    }
}