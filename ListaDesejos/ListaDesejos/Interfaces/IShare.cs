using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace ListaDesejos.Interfaces
{
    interface IShare
    {
        Task Show(string Title, string Message);
    }
}
