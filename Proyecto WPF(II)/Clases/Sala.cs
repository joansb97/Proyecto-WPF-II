using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_WPF_II_.Clases
{
    class Sala : INotifyPropertyChanged
    {
        int _idSala;
        public int IdSala
        {
            get { return _idSala; }
            set 
            { 
                _idSala = value;
                this.NotifyPropertyChanged("IdSala");
            }
        }
        string _numero;
        public string Numero
        {
            get { return _numero; }
            set 
            { 
                _numero = value;
                this.NotifyPropertyChanged("Numero");
            }
        }
        int _capacidad;
        public int Capacidad
        {
            get { return _capacidad; }
            set 
            {
                _capacidad = value;
                this.NotifyPropertyChanged("Capacidad");
            }
        }
        bool _disponible;
        public bool Disponible
        {
            get { return _disponible; }
            set 
            { 
                _disponible = value;
                this.NotifyPropertyChanged("Disponible");
            }
        }
        public Sala() { }
        public Sala(int id,string numero, int capacidad, bool disponible)
        {
            IdSala = id;
            Numero = numero;
            Capacidad = capacidad;
            Disponible = disponible;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
