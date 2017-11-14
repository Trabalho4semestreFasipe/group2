using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;
using Xamarin.Forms;

namespace ListaDesejos.Models
{
    public class Desejo
    {
            [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public  string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Loja { get; set; }
        public double ValorMinimo { get; set; }
        public double ValorMaximo { get; set; }
        public double Valor { get; set; }

        

    }
    

}
