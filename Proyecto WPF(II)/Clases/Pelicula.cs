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
        int _idPelicula;
        public int IdPelicula
        {
            get { return _idPelicula; }
            set 
            { 
                _idPelicula = value;
                this.NotifyPropertyChanged("IdPelicula");
            }
        }
        string _titulo;
        public string Titulo 
        {
            get { return _titulo; }
            set 
            { 
                _titulo = value;
                this.NotifyPropertyChanged("Titulo");
            }
        }
        string _cartel;
        public string Cartel 
        {
            get { return _cartel; }
            set 
            { 
                _cartel = value;
                this.NotifyPropertyChanged("Cartel");
            }
        }
        int _anyo;
        public int Anyo
        {
            get { return _anyo; }
            set 
            {
                _anyo = value;
                this.NotifyPropertyChanged("Anyo");
            }
        }
        string _genero;
        public string Genero 
        {
            get { return _genero; }
            set 
            { 
                _genero = value;
                this.NotifyPropertyChanged("Genero");
            }
        }
        string _calificacion;
        public string Calificacion
        {
            get { return _calificacion; }
            set 
            { 
                _calificacion = value;
                _calificacion = value; this.NotifyPropertyChanged("Calificacion");
            }
        }
        public Pelicula() { }
        public Pelicula(int id, string titulo, string cartel, int anyo, string genero, string calificacion)
        {
            IdPelicula = id;
            Titulo = titulo;
            Cartel = cartel;
            Anyo = anyo;
            Genero = genero;
            Calificacion = calificacion;
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
