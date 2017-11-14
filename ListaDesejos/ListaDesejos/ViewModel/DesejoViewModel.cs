using ListaDesejos.Models;
using ListaDesejos.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using Xamarin.Forms;

namespace ListaDesejos.ViewModel
{
    public class DesejoViewModel : INotifyPropertyChanged
    {
        public Command Share { get; set; }
        private Conexao _conexao;
        public IEnumerable<Desejo> Desejos
        {
            get { return _desejos; }
            set { _desejos = value; OnPropertyChanged(); }
        }
        public IEnumerable<Desejo> _desejos { get; set; }
        public Desejo _desejo { get; set; }
        public Desejo Desejo { get { return _desejo; } set { _desejo = value; OnPropertyChanged(); } }
        public Command ButtonCommand { get; set; }
        public Command MLCommand { get; set; }

        public DesejoViewModel()
        {
            _conexao = new Conexao();
            IniciaDados();
            MLCommand = new Command(ML);
            ButtonCommand = new Command(ExecuteButton, CanExecuteButton);
            Share = new Command(ShareCommand);
        }

        void ShareCommand()
        {
            if ((Desejo.Id < 1) || (Desejo.Id == 0))
            {
                App.Current.MainPage.DisplayAlert("Messagem", "Selecione um cadastro para compartilhar", "OK");
            }
            else
            {
                var share = DependencyService.Get<IShare>();
                var texto = String.Format("Descrição do desejo: {0}, Loja: {1}, Categoria: {2}, Valor: {3}, Valor Minimo: {4}, Valor Máximo: {5}",
                    Desejo.Descricao, Desejo.Loja, Desejo.Categoria, Desejo.Valor, Desejo.ValorMinimo, Desejo.ValorMaximo);
                share.Show("Deseja Realmente Compartilhar isso?", texto);
            }

        }

        public void IniciaDados()
        {
            Desejos = _conexao.GetAll();
            Desejo = new Desejo();
        }

        public void Excluir(Desejo desejo)
        {
            _conexao.Delete(desejo);
        }

        private void ExecuteButton()
        {
            if (Desejo.Id >= 1)
            {
                _conexao.Update(Desejo);
                IniciaDados();
                App.Current.MainPage.DisplayAlert("Messagem", "Alterado com sucesso", "OK");
            }
            else
            {
                _conexao.Add(Desejo);
                IniciaDados();
                App.Current.MainPage.DisplayAlert("Messagem", "Cadastrado com Sucesso", "OK");
            }

            IniciaDados();
        }

        private bool CanExecuteButton()
        {
            return true;
        }

        public void ML()
        {
            var browser = new WebView
            {
                Source = "https://lista.mercadolivre.com.br/"
            };
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
