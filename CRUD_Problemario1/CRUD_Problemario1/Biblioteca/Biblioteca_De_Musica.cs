using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CRUD_Problemario1.Biblioteca
{
    class Biblioteca_De_Musica
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Cancion{ get; set; }
        public string Artista { get; set; }
        public string Genero { get; set; }

        public override string ToString()
        {
            return $"{Cancion} - {Artista} - {Genero}";
        }
    }
}
