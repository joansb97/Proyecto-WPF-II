using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_WPF_II_.Clases
{
    class Cine:INotifyPropertyChanged
    {
        string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set 
            { 
                _nombre = value;
                Properties.Settings.Default.Nombre = value;
            }
        }
        string _imagen;
        public string Imagen
        {
            get { return _imagen; }
            set 
            { 
                _imagen = value;
                Properties.Settings.Default.Imagen = value;
            }
        }
        System.Drawing.Color _color;
        public System.Drawing.Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                Properties.Settings.Default.Color = value;
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
