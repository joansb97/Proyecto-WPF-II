using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF_II_.Clases
{
    class Sala : INotifyPropertyChanged
    {
        int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        int _capacidad;
        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }

        public Sala() { }
        public Sala(int numero, int capacidad)
        {
            Numero = numero;
            Capacidad = capacidad;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
