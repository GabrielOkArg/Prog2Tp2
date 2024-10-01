using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP2.BE;
using TP2.BLL;

namespace TP2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void AltaTrabajador_Click(object sender, RoutedEventArgs e)
        {
            AltaTrabajador altaTrabajador = new AltaTrabajador();
            altaTrabajador.ShowDialog();
        }
        public void LlenarGrilla()
        {
            trabajadoresDataGrid.ItemsSource = null;
            CRUDtrabajador crud = new CRUDtrabajador();
            trabajadoresDataGrid.ItemsSource = crud.GetAll();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var trabajadorSeleccionado = trabajadoresDataGrid.SelectedItem as Trabajador;

            if (trabajadorSeleccionado != null)
            {
                // Abrir la ventana de CargarHoras y pasar el trabajador seleccionado
                CargarHorasSueldo cargarHorasWindow = new CargarHorasSueldo(trabajadorSeleccionado);
                cargarHorasWindow.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un trabajador.");
            }
        }
    }
}
