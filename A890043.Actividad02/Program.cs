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
            int opcion = 0;
            int ingreso, id;
            // string s1 = null;
            bool validacionid;
            bool negativo;
            int stock;
            bool validacionstock;
            int[,] catalogo;

            do
                {
                    Console.WriteLine("Bienvenido al sistema de control de stock de productos farmacéuticos.");
                    Console.WriteLine("\n" +
                        "\n 1. Crear un producto en el catalogo" +
                        "\n 2. Crear un pedido" +
                        "\n 3. Crear una entrega" +
                        "\n 4. Visualizar un informe del stock final" +
                        "\n 5. Salir");

                    Console.WriteLine("Seleccione una opción: ");
                    opcion = Convert.ToInt16(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            {
                                do
                                {
                                    Console.WriteLine("Por favor, ingrese el numero de productos a ingresar:");
                                    ingreso = Convert.ToInt32(Console.ReadLine());
                                    if (ingreso <= 0)
                                    {
                                        Console.WriteLine("Su ingreso no es válido,sólo se puede ingresar un mro mayor a 0. Para intentarlo nuevamente presione enter");
                                        negativo = false;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else negativo = true;
                                } while (negativo == false);
                            }

                            for (int i = 1; i < ingreso; i++)
                            {
                                do
                                {

                                    Console.WriteLine("Ingrese el ID del producto");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    if (id <= 0)
                                    {
                                        Console.WriteLine("Su ingreso no es válido,sólo se puede ingresar un nro mayor a 0. Para intentarlo nuevamente presione enter");
                                        validacionid = false;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else validacionid = true;

                                } while (validacionid == false);

                                do
                                {
                                    Console.WriteLine("Ingrese el stock para el producto correspondiente");
                                    stock = Convert.ToInt32(Console.ReadLine());
                                    if (stock <= 0)
                                    {
                                        Console.WriteLine("No se puede ingresar un valor igual o menor a 0");
                                        validacionstock = false;
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else validacionstock = true;
                                } while (validacionstock == false);

                                catalogo[i, 1] = id;
                                catalogo[i, 0] = stock;
                            }
                        break;
    
                        case 2;
                        break

                        case 3;
                        break

                        case 4;
                        break;







                      
                        case 5:
                            Console.WriteLine("Saliendo del sistema");
                            break;

                        default:
                            Console.WriteLine("Por favor, ingrese una opción valida");
                            break;
                    }
                    Console.ReadKey();
                } while (opcion != 5);

            }

        }
    }