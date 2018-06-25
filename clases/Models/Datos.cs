using System;
using System.Linq;
using System.Collections.Generic;

namespace clases.Models
{
    public class Datos {
         public static IDictionary<int, Bicicleta> bicicleta;
         public static IDictionary<int, Cliente> cliente;
         public static IDictionary<int, Vendedor> vendedor;

         public static IDictionary<int, Precios> precios;
         public static IDictionary<int, Promocion> promocion;
         public static IDictionary<int, Alquiler> alquiler;
        static  Datos() {         
            bicicleta = new Dictionary<int, Bicicleta>();
            bicicleta.Add(0, new Bicicleta { Id = 0, Serial = "1111", Color = "Rojo", Rin = "24",Fecha_compra = new DateTime(2017,1,1,0,0,0)});
            bicicleta.Add(1, new Bicicleta { Id = 1, Serial = "2222", Color = "Azul", Rin = "23",Fecha_compra = new DateTime(2018,4,15,0,0,0)});
            bicicleta.Add(2, new Bicicleta { Id = 2, Serial = "3333", Color = "Verde", Rin = "22",Fecha_compra = new DateTime(2017,6,7,0,0,0)});
            bicicleta.Add(3, new Bicicleta { Id = 3, Serial = "4444", Color = "Amarillo", Rin = "27",Fecha_compra = new DateTime(2016,1,1,0,0,0)});
            
            cliente = new Dictionary<int, Cliente>();
            cliente.Add(0, new Cliente { Id = 0, Dni_cliente = "95123456", Nombre_cliente = "Sergio", Direccion_cliente = "Av Cordoba 875", Telefono_cliente = "11223344"});
            cliente.Add(1, new Cliente { Id = 1, Dni_cliente = "94222444", Nombre_cliente = "Daniel", Direccion_cliente = "Av Cordoba 600", Telefono_cliente = "11223344"});
            cliente.Add(2, new Cliente { Id = 2, Dni_cliente = "93555666", Nombre_cliente = "Pedro", Direccion_cliente = "Av Maipu 610", Telefono_cliente = "2233445566"});
            cliente.Add(3, new Cliente { Id = 3, Dni_cliente = "93111222", Nombre_cliente = "Juan", Direccion_cliente = "Av 9 Julio 510", Telefono_cliente = "7785793"});

            vendedor = new Dictionary<int, Vendedor>();
            vendedor.Add(0, new Vendedor { Id = 0, Dni_vendedor = "97111333", Nombre_vendedor = "Maria - vendedor"});
            vendedor.Add(1, new Vendedor { Id = 1, Dni_vendedor = "95234567", Nombre_vendedor = "Teresa - vendedor"});

            alquiler = new Dictionary<int, Alquiler>();
            alquiler.Add(0,  new Alquiler { Id = 0, Id_bicicleta = 0, Id_cliente = 0, Id_vendedor = 0, Id_precios = 0, Tiempo = 1, Numero_bicicletas = 1, Fecha = new DateTime(2018,1,7,0,0,0) });
            alquiler.Add(1,  new Alquiler { Id = 1, Id_bicicleta = 1, Id_cliente = 1, Id_vendedor = 1,Id_precios = 1,  Tiempo = 1, Numero_bicicletas = 1, Fecha = new DateTime(2018,1,8,0,0,0) });
            alquiler.Add(2,  new Alquiler { Id = 2, Id_bicicleta = 2, Id_cliente = 2, Id_vendedor = 0,Id_precios = 2,  Tiempo = 1, Numero_bicicletas = 1, Fecha = new DateTime(2018,2,4,0,0,0) });
            alquiler.Add(3,  new Alquiler { Id = 3, Id_bicicleta = 3, Id_cliente = 3, Id_vendedor = 1,Id_precios = 0,  Tiempo = 2, Numero_bicicletas = 1, Fecha = new DateTime(2018,2,4,0,0,0) });
            alquiler.Add(4,  new Alquiler { Id = 4, Id_bicicleta = 1, Id_cliente = 0, Id_vendedor = 0,Id_precios = 1,  Tiempo = 2, Numero_bicicletas = 1, Fecha = new DateTime(2018,3,15,0,0,0) });
            alquiler.Add(5,  new Alquiler { Id = 5, Id_bicicleta = 1, Id_cliente = 1, Id_vendedor = 1,Id_precios = 2,  Tiempo = 2, Numero_bicicletas = 1, Fecha = new DateTime(2018,3,17,0,0,0) });
            alquiler.Add(6,  new Alquiler { Id = 6, Id_bicicleta = 2, Id_cliente = 2, Id_vendedor = 0,Id_precios = 0,  Tiempo = 1, Numero_bicicletas = 3, Fecha = new DateTime(2018,4,7,0,0,0) });
            alquiler.Add(7,  new Alquiler { Id = 7, Id_bicicleta = 3, Id_cliente = 3, Id_vendedor = 1,Id_precios = 1,  Tiempo = 1, Numero_bicicletas = 4, Fecha = new DateTime(2018,5,7,0,0,0) });
            alquiler.Add(8,  new Alquiler { Id = 8, Id_bicicleta = 2, Id_cliente = 0, Id_vendedor = 0,Id_precios = 2,  Tiempo = 1, Numero_bicicletas = 5, Fecha = new DateTime(2018,6,7,0,0,0) });
            alquiler.Add(9,  new Alquiler { Id = 9, Id_bicicleta = 1, Id_cliente = 1, Id_vendedor = 1,Id_precios = 0,  Tiempo = 1, Numero_bicicletas = 6, Fecha = new DateTime(2018,6,7,0,0,0) });
            alquiler.Add(10,  new Alquiler { Id = 10, Id_bicicleta = 2, Id_cliente = 2, Id_vendedor = 0,Id_precios = 1, Tiempo = 1, Numero_bicicletas = 7, Fecha = new DateTime(2018,6,7,0,0,0) });
            alquiler.Add(11,  new Alquiler { Id = 11, Id_bicicleta = 3, Id_cliente = 3, Id_vendedor = 1,Id_precios = 2, Tiempo = 1, Numero_bicicletas = 8, Fecha = new DateTime(2018,6,7,0,0,0) });
                    
            precios = new Dictionary<int, Precios>();
            precios.Add(0, new Precios { Id = 0, Tipo_alquiler = "HORA", Precio = 5});
            precios.Add(1, new Precios { Id = 1, Tipo_alquiler = "DIA", Precio = 20});
            precios.Add(2, new Precios { Id = 2, Tipo_alquiler = "SEMANA", Precio = 60});

            promocion = new Dictionary<int, Promocion>();
            promocion.Add(1, new Promocion { Id = 1, Numero_bicicletas = 3, Pct_descuento = 0.7});
            promocion.Add(2, new Promocion { Id = 2, Numero_bicicletas = 4, Pct_descuento = 0.7});
            promocion.Add(3, new Promocion { Id = 3, Numero_bicicletas = 5, Pct_descuento = 0.7});
        }
        
        public static IList<Alquiler> Cargar_Alquileres() {
            var result = alquiler.Values.ToList();
            var resulta = Datos.Completar(result);
            return resulta;         
         }

        public static IList<Cliente> Buscar_clientes() {
            var result = cliente.Values.ToList();
            return result;
        }
        public static IList<Alquiler> Buscar_cliente_alquileres(int Id_cliente) {
            var result = new List<Alquiler>();
            if (alquiler.ContainsKey(Id_cliente)) {
                result = alquiler.Values.Where(l => l.Id_cliente == Id_cliente).ToList();
                var resulta = Datos.Completar(result);
                return resulta;
            }
            return result;
        }

        public static IList<Vendedor> Buscar_vendedores() {
            var result = vendedor.Values.ToList();
            return result;
        }
        public static IList<Alquiler> Buscar_vendedor_alquileres(int Id_vendedor) {
            var result = new List<Alquiler>();
            if (alquiler.ContainsKey(Id_vendedor)) {
                result = alquiler.Values.Where(l => l.Id_vendedor == Id_vendedor).ToList();
                var resulta = Datos.Completar(result);
                return resulta;
            }
            return result;
        }

        public static IList<Alquiler> Completar(List<Alquiler>  alquiler)
        {
                alquiler.ForEach(b => b.bicicleta = bicicleta[b.Id_bicicleta]);
                alquiler.ForEach(c => c.cliente = cliente[c.Id_cliente]);
                alquiler.ForEach(v => v.vendedor = vendedor[v.Id_vendedor]);
                alquiler.ForEach(p => p.precio = precios[p.Id_precios]);
                alquiler.ForEach(ca => ca.Calcular());
                return alquiler;        
        }

        public static IList<Alquiler> Bus_promocion()
        {
            var pro =  promocion.Values.ToList();
            var result = new List<Alquiler>();
            foreach(var p in pro)
            {              
                     result = alquiler.Values.Where(l => l.Numero_bicicletas == p.Numero_bicicletas).ToList(); 
                     result.ForEach(d => d.Pct_descuento = p.Pct_descuento);                                  
                    foreach(var act_pro in result)
                    {
                        Datos.Act_descuento(act_pro.Id, act_pro);
                    }
            }
            var res = alquiler.Values.ToList();
            return res;     
        }
        public static bool Act_descuento(int id, Alquiler alq) {
            if (alquiler.ContainsKey(id)) {
                alquiler[id] = alq;
                return true;
            }

            return false;
        }
    }
}