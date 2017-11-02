using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListaDesejos.Views;

namespace ListaDesejos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListarDesejo : ContentPage
	{
		public ListarDesejo ()
		{
			InitializeComponent ();
		}
        protected async void InserirDesejo(object obj, EventArgs send)
        {
            await App.NavigateMaster(new InserirDesejo());
        }
        protected async void DetalhesDesejo(object obj, EventArgs send)
        {
            await App.NavigateMaster(new DetalhesdoDesejo());
        }
    }
}