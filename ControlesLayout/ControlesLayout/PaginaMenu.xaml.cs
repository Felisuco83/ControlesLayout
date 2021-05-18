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
    public partial class PaginaMenu : ContentPage
    {
        public PaginaMenu()
        {
            InitializeComponent();
            this.botonframe.Clicked += Botonframe_Clicked;
            this.botonlayout.Clicked += Botonlayout_CLicked;
        }

        private async void Botonlayout_CLicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutView());
        }

        private async void Botonframe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}