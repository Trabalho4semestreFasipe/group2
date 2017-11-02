using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ListaDesejos.Views;

namespace ListaDesejos.Views
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            this.Master = new ListarDesejo();
            this.Detail = new NavigationPage(new Principal());
            App.MasterPage = this;

        }
    }
}
