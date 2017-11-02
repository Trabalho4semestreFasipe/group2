using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDesejos.Interfaces
{
    interface IConfiguration
    {
        string DiretorioDataBase { get; }
        ISQLitePlatform Platform { get; }
    }
}
