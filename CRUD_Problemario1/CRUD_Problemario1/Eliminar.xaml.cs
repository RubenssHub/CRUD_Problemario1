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
using SQLite;

namespace CRUD_Problemario1
{
    /// <summary>
    /// Lógica de interacción para Eliminar.xaml
    /// </summary>
    public partial class Eliminar : Window
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
            {
                string sentenciaSQL = "delete from contactos where Nombre='"
                    + txtBoxEliminar.Text + "'";
                conexion.Execute(sentenciaSQL);
            }
            Close();
        }
    }
}
