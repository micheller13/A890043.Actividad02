using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A890043.Actividad02
{
    class Producto
    {
        //public int[] id;
        //public string[] producto;
        //public int[] stock;
        int cantidad;
            //, cant;
        public void IngresodeProductos()
        {
            do
            {
                Console.Write("Por favor, ingrese la cantidad de productos farmacéuticos que desea ingresar en el catalogo: ");
                string cantingresada = Console.ReadLine();
                bool ingreso = int.TryParse(cantingresada, out cantidad);
                if (ingreso)
                {
                    if (cantidad < 1)
                    {
                        Console.WriteLine($"La cantidad de productos que requiere ingresar ({cantidad}) no es válido. Presione, enter para intentarlo nuevamente");
                        Console.ReadKey();
                        //Console.Clear();
                        //continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Su ingreso no es válido, por favor presione enter para intentarlo nuevamente");
                    Console.ReadKey();
                    //Console.Clear();
                    //continue;
                }
            } while (true);
            /*
            id = new int[prod];
            producto = new string[prod];
            stock = new int[prod];
            int cont = -1;
            for (int x = 0; x < prod; x++)
            {
                cont = cont + 1;
                Console.Write($"Ingrese el nombre del producto N° {x} a registrar: ");
                string name = Console.ReadLine();
                id[x] = cont;
                producto[x] = name;
            }
        }
        public void CargaInicial()
        {
            for (int x = 0; x < prod; x++)
            {
                do
                {
                    Console.Write($"Por favor ingrese el stock inicial del producto {x}: ");
                    string ingreso = Console.ReadLine();
                    bool validez = int.TryParse(ingreso, out cant);
                    if (validez)
                    {
                        if (cant < 0)
                        {
                            Console.WriteLine($"El stock ingresado ({cant}) no es válido. Presione Enter para intentarlo nuevamente");
                            Console.ReadKey();
                            continue;
                        }
                        else
                        {
                            stock[x] = cant;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Su ingreso no es válido, por favor presione Enter para intentarlo nuevamente");
                        Console.ReadKey();
                        continue;
                    }
                } while (true);
            }
        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.Write("Menú principal de la farmacia\n\n1) Registrar pedidos\n2) Registrar entregas\nX) Finalizar\n\nPor favor seleccione la acción que quiera realizar: ");
                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Catálogo Principal\n");
                        Imprimir();
                        Console.Write("\nEn caso de querer volver al menú inicial ingrese 'X'\nPor favor ingrese el id del producto a actualizar: ");
                        string ingreso = Console.ReadLine();
                        bool validez = int.TryParse(ingreso, out int eleccion);
                        if (validez)
                        {
                            if (eleccion > -1 && eleccion < producto.Length)
                            {
                                Console.Write($"Ingrese la cantidad del producto '{producto[eleccion]}' a ingresar: ");
                                string cantidad = Console.ReadLine();
                                bool validar = int.TryParse(cantidad, out int ing);
                                if (validar)
                                {
                                    if (ing < 1)
                                    {
                                        Console.WriteLine($"La cantidad de productos ingresados ({prod}) no es válido. Presione Enter para intentarlo nuevamente");
                                        Console.ReadKey();
                                        Console.Clear();
                                        continue;
                                    }
                                    else
                                    {
                                        stock[eleccion] = stock[eleccion] + ing;
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Su ingreso no es válido, por favor presione Enter para intentarlo nuevamente");
                                    Console.ReadKey();
                                    Console.Clear();
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Usted no ha ingresado una opción válida. Presione Enter para intentarlo nuevamente");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                        }
                        else
                        {
                            if (ingreso == "X" || ingreso == "x")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Usted no ha ingresado una opción válida. Presione Enter para intentarlo nuevamente");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                        }
                    } while (true);
                    continue;
                }
                if (opcion == "2")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Catálogo Principal\n");
                        Imprimir();
                        Console.Write("\nEn caso de querer volver al menú inicial ingrese 'X'\nPor favor ingrese el id del producto a actualizar: ");
                        string ingreso = Console.ReadLine();
                        bool validez = int.TryParse(ingreso, out int eleccion);
                        if (validez)
                        {
                            if (eleccion > -1 && eleccion < producto.Length)
                            {
                                Console.Write($"Ingrese la cantidad del producto '{producto[eleccion]}' a ingresar: ");
                                string cantidad = Console.ReadLine();
                                bool validar = int.TryParse(cantidad, out int ing);
                                if (validar)
                                {
                                    if (ing < 1)
                                    {
                                        Console.WriteLine($"La cantidad de productos ingresados ({prod}) no es válido. Presione Enter para intentarlo nuevamente");
                                        Console.ReadKey();
                                        Console.Clear();
                                        continue;
                                    }
                                    if (ing > stock[eleccion])
                                    {
                                        Console.WriteLine($"No se cuenta con capacidad de stock suficiente para poder retirar {ing} productos actualmente");
                                        Console.ReadKey();
                                        continue;
                                    }
                                    else
                                    {
                                        stock[eleccion] = stock[eleccion] - ing;
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Su ingreso no es válido, por favor presione Enter para intentarlo nuevamente");
                                    Console.ReadKey();
                                    Console.Clear();
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Usted no ha ingresado una opción válida. Presione Enter para intentarlo nuevamente");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                        }
                        else
                        {
                            if (ingreso == "X" || ingreso == "x")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Usted no ha ingresado una opción válida. Presione Enter para intentarlo nuevamente");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                        }
                    } while (true);
                    continue;
                }
                if (opcion == "X" || opcion == "x")
                {
                    Console.Clear();
                    Console.WriteLine("Muchas gracias por utilizarnos para su gestión. A continuación el menú con el listado actualizado:\n");
                    Imprimir();
                    Console.WriteLine("\nQue tenga un buen día !!!\n\n*Por favor pulse cualquier tecla para finalizar el programa*");
                    break;
                }
                else
                {
                    Console.WriteLine("Su ingreso no es válido, por favor reintentelo nuevamente");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            } while (true);
        }
        public void Imprimir()
        {
            Console.WriteLine("| ID | Nombre Producto | Stock |");
            for (int x = 0; x < producto.Length; x++)
            {
                Console.Write("| " + id[x] + " | " + producto[x] + " | " + stock[x] + " |");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Producto variable = new Producto();
            variable.IngresodeProductos();
            variable.CargaInicial();
            variable.Menu();
            Console.ReadKey();*/
        }
    }
}
