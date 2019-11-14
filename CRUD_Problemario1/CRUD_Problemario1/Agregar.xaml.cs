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
using CRUD_Problemario1.Biblioteca;
using SQLite;

namespace CRUD_Problemario1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca_De_Musica biblioteca = new Biblioteca_De_Musica()
            {
                Cancion = txtBoxCancion.Text,
                Artista = txtBoxArtista.Text,
                Genero = txtBoxGenero.Text
            };
            using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
            {
                conexion.CreateTable<Biblioteca_De_Musica>();
                conexion.Insert(biblioteca);
            }
            Close();
        }
    }
}
