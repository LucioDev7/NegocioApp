using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NegocioApp.Class;

namespace NegocioApp.ViewModels
{
    public class InicioSesionViewModel : ObjectNotification
    {
        private string _usuario;
        public string Usuario
        {
            get { return _usuario; }
            set
            {
                _usuario = value;
                OnPropertyChanged();
            }
        }

        private string _contrasenia;
        public string Contrasenia
        {
            get { return _contrasenia; }
            set
            {
                _contrasenia = value;
                OnPropertyChanged();
            }
        }

        private bool _recordarContrasenia;
        public bool RecordarContrasenia
        {
            get { return _recordarContrasenia; }
            set
            {
                _recordarContrasenia = value;
                OnPropertyChanged();
            }
        }
    }
}
