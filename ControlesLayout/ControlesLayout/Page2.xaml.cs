﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            this.controlslider.ValueChanged += Controlslider_ValueChanged;
            List<string> data = new List<string>
            {
                "Leche", "Cacao", "Avellanas", "Azucar"
            };
            foreach (string d in data)
            {
                this.controlpicker.Items.Add(d);
            }
            this.controlpicker.SelectedIndexChanged += (sender, args) =>
            {
                this.lblvalor.Text = this.controlpicker.SelectedItem.ToString();
            };
            this.stepper1.ValueChanged += (sender, args) =>
            {
                this.lblvalor.Text = "Stepper: " + args.NewValue;
            };

        }

        private void Controlslider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblvalor.Text = "Valor: " + e.NewValue;
        }
    }
}