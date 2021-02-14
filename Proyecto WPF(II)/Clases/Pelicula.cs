using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF_II_.Clases
{
    class Pelicula : INotifyPropertyChanged
    {
        string _nombre;
        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        string _imagen;
        public string Imagen 
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
        string _genero;
        public string Genero 
        {
            get { return _genero; }
            set { _genero = value; }
        }
        string _calificacion;
        public string Calificacion
        {
            get { return _calificacion; }
            set { _calificacion = value; }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
