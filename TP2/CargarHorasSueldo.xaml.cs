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
using System.Windows.Shapes;
using TP2.BE;
using TP2.BLL;

namespace TP2
{
    /// <summary>
    /// Lógica de interacción para CargarHorasSueldo.xaml
    /// </summary>
    public partial class CargarHorasSueldo : Window
    {
        private Trabajador _trabajador;
        public CargarHorasSueldo(Trabajador trabajador)
        {
            this._trabajador = trabajador;
            InitializeComponent();
            CargarDatosTrabajador();
        }



        private void CargarDatosTrabajador()
        {
            // Datos de la clase Persona
            NombreTextBlock.Text = _trabajador.Nombre;
            ApellidoTextBlock.Text = _trabajador.Apellido;
            DomicilioTextBlock.Text = _trabajador.Domicilio;
            LocalidadTextBlock.Text = _trabajador.Localidad;
            ProvinciaTextBlock.Text = _trabajador.Provincia;
            NroCelularTextBlock.Text = _trabajador.NroCelular.ToString();

            // Datos de la clase Trabajador
            CategoriaTextBlock.Text = _trabajador.Categoria.Nombre;
            RangoTextBlock.Text = _trabajador.Rango.Nombre;
            AreaTrabajoTextBlock.Text = _trabajador.AreaTrabajo;
            CantidadHorasTextBox.Text = _trabajador.CantidadHoras.ToString();
            ValorHoraTextBox.Text = _trabajador.ValorHora.ToString();
            SueldoTextBox.Text = CalcularSueldo.Calcular(_trabajador).ToString();
            FechaIngresoTextBlock.Text = _trabajador.FechaIngreso.ToShortDateString();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                CRUDtrabajador crud = new CRUDtrabajador();
                crud.Update(_trabajador);
               MessageBox.Show("Datos actualizados correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar los datos.");
                throw;
            }
            finally
            {
                CallMainWindows();
                this.Close();

            }

        }

        private void CantidadHorasTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _trabajador.CantidadHoras = int.Parse(CantidadHorasTextBox.Text);
            SueldoTextBox.Text = CalcularSueldo.Calcular(_trabajador).ToString();

        }

        private void ValorHoraTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _trabajador.ValorHora = decimal.Parse(ValorHoraTextBox.Text);
            SueldoTextBox.Text = CalcularSueldo.Calcular(_trabajador).ToString();
        }

        private void CallMainWindows()
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.LlenarGrilla();
            }
        }
    }
}
