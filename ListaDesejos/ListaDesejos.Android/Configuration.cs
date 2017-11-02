using System;
using ListaDesejos.Interfaces;
using SQLite.Net.Interop;
using Xamarin.Forms.Platform.Android;
using SQLite.Net.Platform.XamarinAndroid;

[assembly : Xamarin.Forms.Dependency(typeof(ListaDesejos.Droid.Configuration))] 

namespace ListaDesejos.Droid
{
    public class Configuration : IConfiguration
    {
        public Configuration() { }
        private string _diretorioDataBase;
        public string DiretorioDataBase
        {
            get
            {
                if (String.IsNullOrEmpty(_diretorioDataBase))
                {
                    _diretorioDataBase = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return _diretorioDataBase;
            }
        }
        private ISQLitePlatform _plataform;

        public ISQLitePlatform Platform
        {
            get
            {
                if (_plataform==null)
                {
                    _plataform = new SQLitePlatformAndroid();
                }
                return _plataform;
            }
        }
    }
}