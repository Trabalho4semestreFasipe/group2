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
	public partial class InserirDesejo : ContentPage
	{
		public InserirDesejo ()
		{
			InitializeComponent ();
            DesejoViewModel desejoViewModel = new DesejoViewModel();
            this.BindingContext = desejoViewModel;
            //this.listInserirDesejo.ItemSelected += async (sender, e) =>
            //{
            //    var message = await DisplayAlert("Message", "Qual operação deseja Realizar", "Excluir", "Editar");
            //    if (message)
            //    {
            //        desejoViewModel.Excluir(e.SelectedItem as Model.Desejo);
            //        desejoViewModel.IniciaDados();
            //        desejoViewModel.Contas = desejoViewModel.Desejos;
            //    }
            //    else
            //    {
            //        desjoViewModel.Desejo = e.SelectedItem as Model.Desejo;
            //    }
            //};
        }
 
    }
}