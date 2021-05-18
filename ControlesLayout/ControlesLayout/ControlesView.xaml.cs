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
    public partial class ControlesView : ContentPage
    {
        public ControlesView()
        {
            InitializeComponent();
            this.botongenerar.Clicked += Botongenerar_Clicked;
        }

        private void Botongenerar_Clicked(object sender, EventArgs e)
        {
            int botones = int.Parse(this.cajabotones.Text);
            for (int i= 0; i<botones;i++)
            {
                Button boton = new Button();
                boton.Text = "Boton" + i;
                boton.HorizontalOptions = LayoutOptions.Center;
                this.contenedor.Children.Add(boton);
            }
        }
    }
}