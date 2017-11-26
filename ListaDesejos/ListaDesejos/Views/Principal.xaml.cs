using System;
using ListaDesejos.Models;
using ListaDesejos.ViewModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaDesejos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                IniciaDados();
                return true;
            });
            this.listDesejos.ItemTapped += async (sender, e) =>
            {
                var message = await DisplayAlert("Message", "Deseja Exibir mais detalhes do desejo ", "Sim", "Não");
                if (message == true)
                {
                    await App.NavigateMaster(new DetalhesdoDesejo());
                }

            };


        }
        public void IniciaDados()
        {
            DesejoViewModel desejoViewModel = new DesejoViewModel();
            this.BindingContext = desejoViewModel;
        }
	}
}