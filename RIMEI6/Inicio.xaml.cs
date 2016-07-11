/// <summary>
/// **********************************************
/// * Inicio.xaml.cs
/// *---------------------------------------------
/// Descripción: Vista de inicio de aplicación
///     El usuario puede interactuar con la ven-
///     tana sin sufrir bloqueos propios de la UI
/// Autor:  Fernando Gallego Fernández
/// Rev:    1.0
/// </summary>

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RIMEI6.Model;
using System.ComponentModel;

namespace RIMEI6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        // Variables globales de programa.
        // Definición de la tarea en segundo plano
        private readonly BackgroundWorker lecturaFicheros = new BackgroundWorker();


        public Inicio()
        {
            InitializeComponent();
            var vm = new ViewModel.Inicio {};
            DataContext = vm;
        }

        private void SelDirButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 1;
            da.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            gifGrid.BeginAnimation(Grid.OpacityProperty, da);
            gifGrid.Visibility = Visibility.Visible;
            Ficheros fi = new Ficheros();
            var result = fi.leeFicheros();
            if (result)
            {

            }
            else
            {
                da.From = 1;
                da.To = 0;
                da.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                gifGrid.BeginAnimation(Grid.OpacityProperty, da);
                gifGrid.Visibility = Visibility.Hidden;
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            //Esta función resetea toda la interfaz y variables como si de un hard reboot
            //se tratase para el análisis de nuevos datos.
            System.Windows.Forms.Application.Restart();
            System.Windows.Application.Current.Shutdown();
        }

        private void TerminalCSVButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void HUCSVButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
