# Ejercicio_tecnico
Alquiler de Bicicletas
Se crearon las siguientes clases en la carpeta Models:
 - Bicicleta  - Informacion de cada Bicicleta (Id, Serial, Color, Rin, Fecha_compra).
 - Cliente    - Información de cada Cliente (Id, Dni_cliente, Nombre_cliente, Direccion_cliente, Telefono_cliente).
 - Vendedor   - Información de cada Vendedor(Id, Dni_vendedor, Nombre_vendedor).
 - Precios    - Información de cada Precio (Id, Tipo_alquiler = HORA/DIA/SEMANA, Precio).
 - Promocion  - Información de cada Promoción (Id, Numero_bicicletas, Pct_descuento = Si quiero 30% coloco 0.70 para simplificar el                                                                                              calculo o si quiero 20% coloco 0.80).
 - Alquiler   - Información de cada Alquiler 
 
                      (Id,
		      
                       Id_bicicleta,      (Apunta a la Bicicleta usada)
		       
                       Id_cliente,        (Apunta al Cliente al que se le alquiló la Bicicleta)
		       
                       Id_vendedor,       (Apunta al Vendedor que alquiló la Bicicleta)
		       
                       Id_precios,        (Apunta al Precio usado en el alquiler)
		       
                       Tiempo,            (Indica cuanto tiempo se alquiló)
		       
                       Numero_bicicletas, (Indica cuantas bicicletas se alquilaron, para poder calcular si tiene descuento)
		       
                       Fecha,             (Es la fecha del alquiler)
		       
                       Cobrar,            (Es el monto a cobrar por el alquiler, este monto se calcula)
		       
                       ============================================================================
		       
                       bicicleta          (Tiene los datos de la Bicicleta).
																							
                       cliente            (Tiene los datos del Cliente).
																							
                       vendedor           (Tiene los datos del Vendedor).
																							
                       precio             (Tiene los datos del precio que se vá a usar).
																							
                       Pct_descuento      (Es es descuento a aplicar, este descuento lo calcula el sistema).
																							
                       ===============================================================================
		       
                       . Calcular           (Efectua el calculo de monto a cobrar
                       
 - Datos       - Aquí creamos una clase static del tipo IDictionary para guardar la información del Modelo donde:
 
                 . bicicleta                  - Tiene datos de la Bicicletas.
		 
                 . cliente                    - Tiene datos de los Clientes.
		 
                 . vendedor                   - Tiene datos de los Vendedores.
		 
                 . precios                    - Tiene datos de los Precios.
		 
                 . promocion                  - Tiene datos con las Promociones.
		 
                 . alquiler                   - Tiene datos de los Alquileres de las Bicicletas.
		 
                 . Cargar_Alquileres          - Crea una lista de todos los Alquileres.
		 
                 . Buscar_clientes            - Busca todos los Clientes.
		 
                 . Buscar_cliente_alquileres  - Busca los Alquileres de un Cliente.
		 
                 . Buscar_vendedores          - Crea una lista de todos los Vendedores.
		 
                 . Buscar_vendedor_alquileres - Busca los Alquileres de un Vendedor.
		 
                 . Completar                  - Completa el Registro, buscando la información que falta del registro Alquiler  
		                                         (bicicleta, cliente, vendedor, precio, Pct_descuento)
		 
                 . Bus_promocion              - Calcula el Descuento si tiene Promoción)
		 
                 . Act_descuento              - Actualiza los datos del alquiler con el Pct_descuento si le corresponde.
		 
 
