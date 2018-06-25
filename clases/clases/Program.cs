using System;
using System.Linq;
using System.Collections.Generic;

namespace clases.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Calcula los Alquileres que tienen un Descuento */
            Datos.Bus_promocion();
            
            
            Console.WriteLine("  ");
            Console.WriteLine("==== Clientes ====== ");
            /* Muestra las Bicicletas que alquiló un Cliente  */
            var buscli = Datos.Buscar_clientes();
            foreach( var c in buscli)
            {
                Console.WriteLine(" " + c.Nombre_cliente);
                var bus_cli_alq = Datos.Buscar_cliente_alquileres(c.Id);
                foreach(var ca in bus_cli_alq) 
                {
                    Console.WriteLine("       Bicicleta: " + ca.bicicleta.Serial + " Fecha: " + ca.Fecha + " Cobrar: " + ca.Cobrar);
                }

            }

            Console.WriteLine("==== Vendedores ====== ");
            /* Muestra las Bicicletas que alquiló un Vendedor */
            var busven = Datos.Buscar_vendedores();
            foreach( var c in busven)
            {
                Console.WriteLine(" " + c.Nombre_vendedor);
                var bus_ven_alq = Datos.Buscar_vendedor_alquileres(c.Id);
                foreach(var ca in bus_ven_alq) 
                {
                    Console.WriteLine("       Bicicleta: " + ca.bicicleta.Serial + " Fecha: " + ca.Fecha + " Cobrar: " + ca.Cobrar);
                }

            }

            Console.WriteLine("==== Alquileres ====== ");
           /* Muestra los Datos de los Alquileres  */
           var result = Datos.Cargar_Alquileres();
           foreach(var p in result)
           {
               Alquiler usuario = new Alquiler();
               usuario = p;
               Console.WriteLine("Fecha: " + usuario.Fecha + " Cliente: " + usuario.cliente.Nombre_cliente + " Bicicleta:" + usuario.bicicleta.Serial + " Vendedor: " + usuario.vendedor.Nombre_vendedor + " Tiempo: " + usuario.Tiempo + " Tipo Alquiler: " + usuario.precio.Tipo_alquiler + " Num.Bicicletas: " + usuario.Numero_bicicletas + " Cobrar: " + usuario.Cobrar );
           }
         }
    }
}
