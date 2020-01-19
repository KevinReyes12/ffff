using System;
using System.Collections.Generic;
using ejemploLINQ.Clases;
using System.Linq;

namespace ejemploLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente(){Nombre="Bart",Apellidos="Simpson",Ciudad="Manta",Salario=900 },
                new Cliente(){Nombre="Marge",Apellidos="Simpson",Ciudad="MANTA", Salario=2000 },
                new Cliente(){Nombre="Lisa",Apellidos="Simpson",Ciudad="Chone", Salario=800 },
                new Cliente(){Nombre="Montogomery",Apellidos="Burns",Ciudad="Chone",Salario=3000 },
                new Cliente(){Nombre="Apu",Apellidos="Nahapeemapetilon",Ciudad="Santa Ana",Salario=5000 }
            };
            //IEnumerable<Cliente> consulta = from cliente in clientes
            //where cliente.Ciudad.ToUpper()=="Manta".ToUpper()//condicion
            //orderby cliente.Salario ascending//ordenar

            //select cliente;

            //
            var consulta = from cliente in clientes
                               //group cliente by cliente.Ciudad.ToUpper();
                           //group cliente by cliente.Salario > 1000;
                           group cliente by cliente.Nombre[0];
            foreach (var item in consulta)
            {
                Console.WriteLine(item.Key);
                foreach (var elemento in item)
                {
                    Console.WriteLine("{0} {1}",elemento.Nombre,elemento.Apellidos);
                }
            }

            //foreach (var item in consulta)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", item.Nombre,item.Apellidos,item.Ciudad,item.Salario);
            //}


            /*
            //origen de datos 
            int[] notas = {2,3,4,8,1,9,10,5 };

            //definicion de la consulta
            IEnumerable<int> consulta = from nota in notas
            where nota > 7
            select nota;

            //la ejecucion
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("El número de elementos es {0}",consulta.Count());
            Console.WriteLine("Promedio es {0}", consulta.Average());
            Console.WriteLine("Mayor es {0}", consulta.Max());
            Console.WriteLine("Primer elemento es {0}", consulta.First());
            */
            Console.ReadKey();
        }
    }
}
