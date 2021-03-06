﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proyecto_WPF_II_.Clases
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand addPelicula = new RoutedUICommand(
            "Añadir Pelicula",
            "Añadir Pelicula",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.P, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand modifyPelicula = new RoutedUICommand(
            "Modificar Pelicula",
            "Modificar Pelicula",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.E, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand deletePelicula = new RoutedUICommand(
            "Eliminar Pelicula",
            "Eliminar Pelicula",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.L, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand addSesion = new RoutedUICommand(
            "Añadir Sesion",
            "Añadir Sesion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.S, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand modifySesion = new RoutedUICommand(
            "Modificar Sesion",
            "Modificar Sesion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.I, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand deleteSesion = new RoutedUICommand(
            "Eliminar Sesion",
            "Eliminar Sesion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.O, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand addSala = new RoutedUICommand(
            "Añadir Sala",
            "Añadir Sala",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.A, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand modifySala = new RoutedUICommand(
            "Modificar Sala",
            "Modificar Sala",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.L, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand modifyCine = new RoutedUICommand(
            "Modificar Cine",
            "Modificar Cine",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.C, ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand Salir = new RoutedUICommand(
            "Salir",
            "Salir",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.A, ModifierKeys.Control)
            }
            );
    }
}
