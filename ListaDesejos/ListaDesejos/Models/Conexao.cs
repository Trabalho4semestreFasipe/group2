using ListaDesejos.Interfaces;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ListaDesejos.Models
{
    public class Conexao : IDisposable
    {
        private SQLiteConnection _conexao;

        public Conexao()
        {
            var config = DependencyService.Get<IConfiguration>();
            _conexao = new SQLiteConnection(config.Platform, 
                System.IO.Path.Combine(config.DiretorioDataBase, "Desejo.db"));
            _conexao.CreateTable<Desejo>();
        }
        public void Add (Desejo desejo)
        {
            _conexao.Insert(desejo);
        }
        public void Update(Desejo desejo)
        {
            _conexao.Update(desejo);
        }
        public void Delete(Desejo desejo)
        {
            _conexao.Delete(desejo);
        }
        public Desejo GetId(int id)
        {
            return _conexao.Table<Desejo>().FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<Desejo> GetAll()
        {
            return _conexao.Table<Desejo>();
        }
        public void Dispose()
        {
            _conexao.Dispose();
        }
    }
}
