using System;
using ListaDesejos;
using ListaDesejos.Models;
using ListaDesejos.ViewModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaDesejos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlterarDesejo : ContentPage
	{
		public AlterarDesejo(DesejoViewModel desejoViewModel)
		{
            InitializeComponent();
            this.BindingContext = desejoViewModel;
        }
	}
}