using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Proyecto_WPF_II_.Clases
{
    class Venta:INotifyPropertyChanged
    {
        int _idVenta;
        public int IdVenta
        {
            get { return _idVenta; }
            set
            {
                _idVenta = value;
                NotifyPropertyChanged("IdVenta");
            }
        }
        int _sesion;
        public int Sesion
        {
            get { return _sesion; }
            set
            {
                _sesion = value;
                NotifyPropertyChanged("Sesion");
            }
        }
        int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                _cantidad = value;
                NotifyPropertyChanged("Cantidad");
            }
        }
        string _pago;
        public string Pago
        {
            get { return _pago; }
            set
            {
                _pago = value;
                NotifyPropertyChanged("Pago");
            }
        }

        public Venta(int id, int sesion, int cantidad, string pago)
        {
            IdVenta = id;
            Sesion = sesion;
            Cantidad = cantidad;
            Pago = pago;
        }

        public void VentaEntradas(int entradas)
        {
            int aux = Cantidad + entradas;
            if (Cantidad <= aux)
            {
                MessageBox.Show("No hay suficiente capacidad para vender tantas entradas", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Cantidad = aux;
                MessageBox.Show("Venta realizada", "Todo correcto", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
