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

namespace CRUD_Problemario1
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        List<Biblioteca.Biblioteca_De_Musica> bibliotecas;
        public Principal()
        {
            InitializeComponent();
            bibliotecas = new List<Biblioteca.Biblioteca_De_Musica>();
            LeerBaseDatos();
        }
        void LeerBaseDatos()
        {
            using (SQLite.SQLiteConnection conn =
                new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Biblioteca.Biblioteca_De_Musica>();
                bibliotecas = (conn.Table<Biblioteca.Biblioteca_De_Musica>().ToList()).
                    OrderBy(c => c.Cancion).ToList();
            }
            if (bibliotecas != null)
            {
                lvBiblioteca.ItemsSource = bibliotecas;
            }
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            CRUD_Problemario1.MainWindow form = new CRUD_Problemario1.MainWindow();
            form.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            EliminarDatos form = new CRUD_Problemario1.EliminarDatos();
            form.ShowDialog();
        }
    }
}
