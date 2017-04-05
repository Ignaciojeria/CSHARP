using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine
{
    class Salas
    {
        private Pelicula[] _Peliculas = new Pelicula[16];
        private int numsala = 1;
        private int j=1;
        private int opcion = 666;
        private bool ok;

        

        public void MenuPeliculas()
        {
            Console.WriteLine("Elija una opción");
            Console.WriteLine("1) Agregar pelicula");
            Console.WriteLine("2) Salir");
            Console.WriteLine("3) Listar Peliculas");
            Console.WriteLine("4) Eliminar titulo ");

            try
            {
                ok = int.TryParse(Console.ReadLine(), out opcion);
                if (!ok)
                {
                    throw new Exception("Ingrese un numero para la opción");
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese el titulo de la pelicula");
                        string titulo = Console.ReadLine();
                        int duracion;
                        Console.WriteLine("Ingrese la duración de la pelicula");
                        ok = int.TryParse(Console.ReadLine(), out duracion);
                        if (!ok)
                        {
                            throw new Exception("por favor Ingrese un numero en la duración");
                        }
                        Console.WriteLine("Ingrese el género de la pelicula");
                        string genero = Console.ReadLine();
                        BuscarPeliculaRepetidaPorTitulo(titulo);
                        AgregarPelicula(new Pelicula(titulo, duracion, genero, j));
                        
                        Console.WriteLine("");
                        
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.Clear();
                        MenuPeliculas();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("----Fin del proceso----");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        ListarPeliculas();
                        Console.ReadLine();
                        MenuPeliculas();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingresa El titulo");
                        EliminarPeliculaRepetidaPorTitulo(Console.ReadLine());
                        Console.ReadLine();
                        MenuPeliculas();
                        break;


                    default:
                        Console.Clear();
                        throw new Exception("Escoja una opción correcta");
                        
                }

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                MenuPeliculas();
            }



        }

        private void AgregarPelicula(Pelicula pelicula)
        {
            for (int i = 0; i < 16; i++)
            {
                if (_Peliculas[i]==null)
                {
                    
                    _Peliculas[i] = pelicula;
                    numsala++;
                    j = numsala;
                    Console.WriteLine("-------Pelicula Agregada------");
                    return;
                }
            }

        }

        private void BuscarPeliculaRepetidaPorTitulo(String titulo)
        {
            
            if (numsala > 1)
            {
                for  (int i = 0; i < _Peliculas.Length; i++)
                {
                    if (_Peliculas[i] == null)
                    {
                        return;
                    }

                    if (titulo.Equals(_Peliculas[i]._Titulo))
                    {
                        throw new Exception("Esta pelicula ya existe");
                    }
                }
                
            }
        }

        private void EliminarPeliculaRepetidaPorTitulo(String titulo)
        {

            if (numsala > 0)
            {

                for (int i = 0; i < _Peliculas.Length; i++)
                {
                    if (_Peliculas[i] == null)
                    {
                     throw new Exception("Asignar titulo a sala numero "+ j+ " antes de borrar");
                    }

                    if (_Peliculas[i]._Titulo.Equals(titulo))
                    {
                        j = _Peliculas[i]._NumeroDeSala;
                        _Peliculas[i] = null;
                        Console.WriteLine("Pelicula Eliminada");
                        numsala--;
                        
                        return;
                    }
                }
            }
            throw new Exception("no hay peliculas");
        }

        public void ListarPeliculas()
        {
            if (numsala > 1)
            {
                for (int i = 0; i < _Peliculas.Length; i++)
                {
                    
                    if (_Peliculas[i]!=null)
                    {
                    Console.WriteLine(_Peliculas[i].ToString());
                    }
                    

                }
            }
            else
            {
                throw new Exception("No hay peliculas que listar");
            }

        }
    }
}
