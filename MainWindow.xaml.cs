using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace WpfMontoConIva
{
    
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double SubTotal;
              
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Clear(); 
            txtApellido.Clear();
            txtSubtotal.Clear();
            lblResultado.Content = "";
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double TotalIva;
            string Nombre = this.txtNombre.Text;
            string Apellido = this.txtApellido.Text;
            string strSubtotal = this.txtSubtotal.Text;
            double.TryParse(strSubtotal, out SubTotal);
            TotalIva = SubTotal * 1.19;
            this.lblResultado.Content = Nombre +" "+ Apellido + " el monto a pagar es de $ " + TotalIva;
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, TextChangedEventArgs e)<<
        {

        }

        private void txtSubtotal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
