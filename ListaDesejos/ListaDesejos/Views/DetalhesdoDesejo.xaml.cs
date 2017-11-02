using System;
using ListaDesejos.Models;
using ListaDesejos.ViewModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaDesejos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalhesdoDesejo : ContentPage
	{
		public DetalhesdoDesejo ()
		{
			InitializeComponent ();
            DesejoViewModel desejoViewModel = new DesejoViewModel();
            this.BindingContext = desejoViewModel;
            this.listDesejos.ItemTapped += async (sender, e) =>
            {
                var message = await DisplayAlert("Message", "Qual operação deseja Realizar", "Excluir", "Editar");
                if (message)
                {
                   desejoViewModel.Excluir(e.Item as Models.Desejo);
                   desejoViewModel.IniciaDados();
                   desejoViewModel.Desejos = desejoViewModel.Desejos;
                }
                else
                {
                    desejoViewModel.Desejo = e.Item as Models.Desejo;
                    await App.NavigateMaster(new AlterarDesejo(desejoViewModel));
                }
            };
           
        }
    }
}