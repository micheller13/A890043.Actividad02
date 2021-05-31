using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A890043.Actividad02
{
    class Producto
    {

        static void Main(string[] args)
        {
            int opcion;
            int ingreso, id;
            bool validacionid;
            bool negativo;
            int stock;
            bool validacionstock;
            int[,] catalogo;
            bool validacionpedido;
            bool validacionentrega;

            do
                {
                    Console.WriteLine("Bienvenido al sistema de control de stock de productos farmacéuticos.\n");

                    Console.WriteLine(
                        "\n 1. Crear un producto en el catalogo" +
                        "\n 2. Ingresar un pedido" +
                        "\n 3. Ingresar una entrega" +
                        "\n 4. Visualizar un informe del stock final" +
                        "\n 5. Salir");

                    Console.Write("\nSeleccione una opción: ");
                    opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                 
                         do
                            {
                                Console.Write("Por favor, ingrese el numero de productos a ingresar: ");
                                ingreso = Convert.ToInt32(Console.ReadLine());
                                if (ingreso <= 0)
                                {
                                    Console.WriteLine("Su ingreso no es válido,sólo se puede ingresar un mro mayor a 0. Para intentarlo nuevamente presione enter");
                                    Console.ReadKey();

                                    negativo = false;
                                    Console.Clear();
                                }
                                else negativo = true;
                            } while (negativo == false);

                        catalogo = new int[ingreso, 2];

                        for (int i = 0; i < ingreso; i++)
                        {
                            do
                            {
                                Console.Write("Ingrese el ID del producto: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                if (id <= 0)
                                {
                                    Console.Write("Su ingreso no es válido,sólo se puede ingresar un nro mayor a 0. Para intentarlo nuevamente presione enter");
                                    validacionid = false;
                                    Console.ReadKey();
                                    
                                }
                                else validacionid = true;


                            } while (validacionid == false);


                            do
                            {
                                Console.Write("Ingrese el stock para el producto correspondiente: ");
                                stock = Convert.ToInt32(Console.ReadLine());
                                if (stock <= 0)
                                {
                                    Console.WriteLine("Su ingreso no es válido,sólo se puede ingresar un nro mayor a 0. Para intentarlo nuevamente presione enter");
                                    validacionstock = false;
                                    Console.ReadKey();
                                }
                                else validacionstock = true;
                            } while (validacionstock == false);

                            catalogo[i, 0] = id;
                            catalogo[i, 1] = stock;
                        }
                      
                        
                        break;

                    case 2:
                        int cantidadpedido;
                        
                            do
                            {
                                Console.Write("Ingrese la cantidad del pedido");
                                cantidadpedido = Convert.ToInt32(Console.ReadLine());
                                if (cantidadpedido <= 0)
                                {
                                    Console.Write("Su ingreso no es válido,sólo se puede ingresar un nro mayor a 0. Para intentarlo nuevamente presione enter");
                                    validacionpedido = false;
                                    Console.ReadKey();

                                }
                                else validacionpedido = true;


                            } while (validacionpedido == false);

                    break;
                       
                    case 3:
                        int cantidadentrega;
                        do
                        {
                            Console.Write("Ingrese la cantidad del pedido");
                            cantidadentrega = Convert.ToInt32(Console.ReadLine());
                            if (cantidadentrega <= 0)
                            {
                                Console.Write("Su ingreso no es válido,sólo se puede ingresar un nro mayor a 0. Para intentarlo nuevamente presione enter");
                                validacionentrega = false;
                                Console.ReadKey();

                            }
                            else validacionentrega = true;


                        } while (validacionentrega == false);
                   break;

                    case 4:
                        break;







                      
                   case 5:
                            Console.WriteLine("Saliendo del sistema. Por favor, presione enter.");
                   break;

                   default:
                            Console.WriteLine("Por favor, ingrese una opción valida"
                   break;
                    }
                    Console.ReadKey();
                } while (opcion != 5);

            }

        }
    }
