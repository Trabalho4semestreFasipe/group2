using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDesejos.Models
{
    class Desejo
    {
        private int codigo1;
        private string produto1;
        private string categoria1;
        private string loja1;
        private double precominimo1;
        private double precomaximo1;

        public double Getprecomaximo()
        {
            return precomaximo1;
        }

        public void Setprecomaximo(double value)
        {
            precomaximo1 = value;
        }

        private double Getprecominimo()
        {
            return precominimo1;
        }

        private void Setprecominimo(double value)
        {
            precominimo1 = value;
        }

        public string Getloja()
        {
            return loja1;
        }

        public void Setloja(string value)
        {
            loja1 = value;
        }

        public string Getcategoria()
        {
            return categoria1;
        }

        public void Setcategoria(string value)
        {
            categoria1 = value;
        }

        public string Getproduto()
        {
            return produto1;
        }

        public void Setproduto(string value)
        {
            produto1 = value;
        }

        private int Getcodigo()
        {
            return codigo1;
        }

        private void Setcodigo(int value)
        {
            codigo1 = value;
        }
    }
}
