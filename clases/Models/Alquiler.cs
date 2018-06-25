using System;
using System.Linq;
using System.Collections.Generic;

namespace clases.Models

{
    public partial class Alquiler
    {
        public int Id {get; set;}
        public int Id_bicicleta {get; set;}
        public int Id_cliente {get; set;}
        public int Id_vendedor {get; set;}
        public int Id_precios {get; set;}

        public int Tiempo {get; set;}
        public int Numero_bicicletas {get; set;}
        public DateTime Fecha {get; set;}
        public double Cobrar {get; set;}
        
            

        public void Calcular()
        {
            if (Pct_descuento > 0)
            {
                Cobrar = Tiempo * precio.Precio * Numero_bicicletas * Pct_descuento;
            }
            else
            {
                Cobrar = Tiempo * precio.Precio * Numero_bicicletas;
            }
        }
    }      
    public partial class Alquiler
        {
            public Bicicleta bicicleta {get; set;}
            public Cliente cliente {get; set;}
            public Vendedor vendedor {get; set;}
            public Precios precio {get; set;}

            public double Pct_descuento {get; set;}
            
        }
}