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
using Registro_N.Entidades;
using Registro_N.BLL;

namespace Registro_N
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {    Persona persona=new Persona();
        public MainWindow()
        {
            InitializeComponent();
            DataContext=persona;


        }
        private void Limpiar(){
            this.persona=new Persona();
            this.DataContext=persona;
             }
            
            private bool Validar(){
            bool esValido = true;

            if(NombreTextBox.Text.Length == 0){

                esValido = true;
                MessageBox.Show("Transaccion Fallida" , "Fallo", 
                MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            return esValido;
        }

          

           private void BuscarButton_Click(object sender, RoutedEventArgs e){
            var person = PersonaBLL.Buscar(Utilidades.ToInt(IDTextBox.Text));

            if(person != null){
                this.persona = person;
            }
            else{
                this.persona =new Persona();
            }
            this.DataContext= this.persona;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e){

            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e){
            
            if(!Validar()){
                return;
            }
            var paso = PersonaBLL.Guardar(persona);

            if(paso){
                Limpiar();
                MessageBox.Show("Transaccion exitosa!" , "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("Transaccion Fallida", "Fallo",  MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e){
            if(PersonaBLL.Eliminar(Utilidades.ToInt(IDTextBox.Text))){

                Limpiar();
                MessageBox.Show("Registro eliminado!" , "Exito" , MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else{
                MessageBox.Show("No fue posible eliminar", "Fallo",MessageBoxButton.OK, MessageBoxImage.Error);
            }

           
}

    }
}
