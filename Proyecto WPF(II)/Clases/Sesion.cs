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
        Pelicula _pelicula;
        public Pelicula pelicula
        {
            get { return _pelicula; }
            set { _pelicula = value; }
        }
        Sala _sala;
        public Sala sala
        {
            get { return _sala; }
            set { _sala = value; }
        }
        int ventas;

        public Sesion() { }
        public Sesion(Pelicula pelicula, Sala sala)
        {
            this.pelicula = pelicula;
            this.sala = sala;
            ventas = 0;
        }
        public void VentaEntradas(int entradas)
        {
            int aux = ventas + entradas;
            if(sala.Capacidad <= aux)
            {
                MessageBox.Show("No hay suficiente capacidad para vender tantas entradas","Error",MessageBoxButton.OK,MessageBoxImage.Warning);
            }else
            {
                ventas = aux;
                MessageBox.Show("Venta realizada", "Todo correcto", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
