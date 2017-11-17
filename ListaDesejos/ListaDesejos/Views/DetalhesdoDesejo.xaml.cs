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
        public bool Mlatv { get; set; }
		public DetalhesdoDesejo ()
		{
			InitializeComponent ();
            DesejoViewModel desejoViewModel = new DesejoViewModel();
            this.BindingContext = desejoViewModel;
            this.listDesejos.ItemTapped += async (sender, e) =>
            {
                var message = await DisplayActionSheet("Qual operação deseja Realizar","Editar", "Excluir", "Buscar ML" );
               // await DisplayAlert("teste", message, "ok");
                if (message=="Excluir")
                {
                    desejoViewModel.Excluir(e.Item as Models.Desejo);
                    desejoViewModel.IniciaDados();
                    desejoViewModel.Desejos = desejoViewModel.Desejos;
                }
                if (message == "Buscar ML")
                {
                    await App.NavigateMaster(new ML(e.Item as Models.Desejo));
                }
                if (message == "Editar")
                {
                    desejoViewModel.Desejo = e.Item as Models.Desejo;
                    await App.NavigateMaster(new AlterarDesejo(desejoViewModel));
                }
            };
        }
        //public void MercadoLivre(object obj, EventArgs send)
        //{
        //    this.listDesejos.ItemSelected += async (sender, e) =>
        //    {
           
                    
                
        //    };
        //}

    }
}