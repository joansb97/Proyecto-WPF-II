﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Proyecto_WPF_II_
{
    /// <summary>
    /// Lógica de interacción para CambiaCine.xaml
    /// </summary>
    public partial class CambiaCine : Window
    {
        public string nombre;
        public string imagen;
        public string color;
        public CambiaCine()
        {
            InitializeComponent();
        }
        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
