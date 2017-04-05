using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    class Pelicula
    {
        private string Titulo;

        public string _Titulo{
            get
            {
                return Titulo;
            }

            set
            {
                Titulo = value;
            }

        }

        private double Duracion;

        public double _Duracion
        {
            get
            {
                return Duracion;
            }
            set
            {
                if (value>=70 && value<=240)
                {
                Duracion = value;
                }
                else
                {
                throw new Exception("La duración debe estar entre 70 y 240 minutos");
                }
                
                
            }
        }

        private string _Genero;

        private int NumeroDeSala;

        public int _NumeroDeSala
        {
            get
            {
                return NumeroDeSala;
            }
            set
            {
                NumeroDeSala = value;
            }
        }

        public Pelicula(string titulo, double duracion, string genero, int numeroDeSala)
        {
            _Titulo = titulo;

            _Duracion = duracion;

            _Genero = genero;

            _NumeroDeSala = numeroDeSala;

        }

        public override string ToString()
        {
            return "Titulo: "+ Titulo+ " Duración: "+Duracion+ " Género: "+ _Genero+ " Número de sala: "+ _NumeroDeSala;
        }
    }
}
