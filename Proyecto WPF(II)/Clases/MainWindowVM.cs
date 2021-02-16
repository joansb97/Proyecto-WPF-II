using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF_II_.Clases
{
    class MainWindowVM : INotifyPropertyChanged
    {
        string nombre;
        string color;
        string imagen;
        ObservableCollection<Venta> ventas;
        Sesion[] sesiones;
        Pelicula[] peliculas;
        Sala[] salas;

        public MainWindowVM()
        {
            nombre = Properties.Settings.Default.Nombre;
            color = Properties.Settings.Default.Color;
            imagen = Properties.Settings.Default.Imagen;
        }
        public void CambiaCine()
        {
            CambiaCine cine = new CambiaCine();
            cine.Owner = MainWindow;
            if(cine.ShowDialog() == true)
            {
                Properties.Settings.Default.Nombre = cine.nombre;
                Properties.Settings.Default.Color = cine.color;
                Properties.Settings.Default.Imagen = cine.imagen;
            }
        }

        public static ObservableCollection<Venta> GetVentas()
        {
            ObservableCollection<Venta> v = null;
            SqliteConnection conexion = new SqliteConnection("");
            conexion.Open();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = @"SELECT * FROM ventas";
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)lector["idVenta"];
                    int sesion = (int)lector["sesion"];
                    int cantidad = (int)lector["cantidad"];
                    string pago = (string)lector["pago"];
                    Venta aux = new Venta(id, sesion, cantidad, pago);
                    v.Add(aux);
                }
            }
            return v;
        }

        // public static Venta getVenta() { }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
