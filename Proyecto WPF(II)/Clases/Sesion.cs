using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_WPF_II_.Clases
{
    class Sesion:INotifyPropertyChanged
    {
        int _idSesion;
        public int IdSesion
        {
            get { return _idSesion; }
            set
            {
                _idSesion = value;
                this.NotifyPropertyChanged("IdSesion");
            }
        }
        int _pelicula;
        public int pelicula
        {
            get { return _pelicula; }
            set
            {
                _pelicula = value;
                this.NotifyPropertyChanged("Pelicula");
            }
        }
        int _sala;
        public int sala
        {
            get { return _sala; }
            set
            {
                _sala = value;
                this.NotifyPropertyChanged("Sala");
            }
        }
        string _hora;
        public string Hora
        {
            get { return _hora; }
            set
            {
                _hora = value;
                this.NotifyPropertyChanged("Hora");
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
