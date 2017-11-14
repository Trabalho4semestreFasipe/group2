using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaDesejos.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaDesejos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ML : ContentPage
	{
		public ML (Desejo desejo)
		{
			InitializeComponent ();
            this.MercadoLivre.Source = "https://lista.mercadolivre.com.br/" + desejo.Descricao;
            

        }
        public void MLw(Desejo desejo)
        {
            var browser = new WebView
            {
                Source = "https://lista.mercadolivre.com.br/"+desejo.Descricao
            };
        }

    }
}