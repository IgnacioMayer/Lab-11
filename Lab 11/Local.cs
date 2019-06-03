using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    [Serializable]
    public class Local
    {
        int id;
        string horario;
        string nombre;

        public Local(int id, string horario, string nombre)
        {
            this.Id = id;
            this.Horario = horario;
            this.Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Horario { get => horario; set => horario = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string Show()
        {
            return $"{Id}, {Nombre}, {Horario}";
        }
    }

    [Serializable]
    public class Cine : Local
    {
        int salas;

        public Cine(int id, string horario, string nombre, int salas)
            : base(id, horario, nombre)
        {
            this.salas = salas;
        }
    }

    [Serializable]
    public class Restaurante : Local
    {
        bool mesaExclusiva;

        public Restaurante(int id, string horario, string nombre, bool mesaExclusiva)
            : base(id, horario, nombre)
        {
            this.mesaExclusiva = mesaExclusiva;
        }
    }

    [Serializable]
    public class Recreacion : Local
    {
        string juegos;

        public Recreacion(int id, string horario, string nombre, string juegos)
            : base(id, horario, nombre)
        {
            this.juegos = juegos;
        }
    }

    [Serializable]
    public class Tienda : Local
    {
        string categoria;

        public Tienda(int id, string horario, string nombre, string categoria)
            :base(id, horario, nombre)
        {
            this.categoria = categoria;
        }
    }


}
