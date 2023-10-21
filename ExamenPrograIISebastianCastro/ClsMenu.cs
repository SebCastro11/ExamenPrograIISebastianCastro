using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograIISebastianCastro
{
    internal class ClsMenu
    {

        static public List<ClsEmpleado> empleados = new List<ClsEmpleado>();

        private static int op = 0;

        static public void ShowMenu()
        {

            while (op != 7)
            {
                Console.Clear();


                Console.WriteLine(" ****Menu Principal**** \n ");
                Console.WriteLine(" 1. Inicializar arreglos \n 2. Agregar Empleados \n 3. Consultar Empleados \n 4. Modificar Empleados \n 5. Borrar Empleados \n 6. Reportes \n 7. Salir ");



                Console.Write(" \n Ingrese la opcion deseada:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        //Utilice una lista, por lo cual no habi necesidad de inicializar arreglos

                        Console.WriteLine("Inicializando arreglos ;)");
                        Console.ReadKey();

                        break;

                    case 2:

                        Agregar();

                        break;

                    case 3:

                        BuscarPorCedula();

                        break;

                    case 4:

                        Modificar();

                        break;

                    case 5:

                        Borrar();

                        break;

                    case 6:

                        Reportes();

                        break;

                    case 7:

                        //Nos fuimos

                        break;

                    default:

                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();

                        break;
                }

            }

        }

        //Metodos

        static public void Agregar()
        {

            while (true)
            {

                Console.Clear();

                Console.WriteLine("Ingrese los datos del empleado:");
                Console.Write("Cédula: ");
                string cedula = Console.ReadLine();

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Dirección: ");
                string direccion = Console.ReadLine();

                Console.Write("Teléfono: ");
                string telefono = Console.ReadLine();

                Console.Write("Salario: ");
                double.TryParse(Console.ReadLine(), out double salario);

                empleados.Add(new ClsEmpleado(cedula, nombre, direccion, telefono, salario));


                Console.Write("¿Desea agregar otro empleado? (S/N): ");
                if (Console.ReadLine().Trim().ToUpper() != "S")
                {
                    break;
                }
            }


        }

        static public void BuscarPorCedula()
        {
            Console.Clear();
            Console.Write("Ingrese la cédula del empleado que desea buscar: ");
            string inputCed = Console.ReadLine();

            List<ClsEmpleado> empleadosEncontrados = empleados.FindAll(empleado => empleado.cedula == inputCed);

            if (empleadosEncontrados.Count > 0)
            {

                Console.WriteLine("\nEmpleados encontrados con la cédula " + inputCed + ":");
                foreach (ClsEmpleado empleado in empleadosEncontrados)
                {
                    Console.WriteLine($" Cédula: {empleado.cedula} \n Nombre: {empleado.nombre} \n Dirección: {empleado.direccion} \n Teléfono: {empleado.telefono}\n Salario: {empleado.salario}");
                }

            }
            else
            {

                Console.WriteLine("\nNo se encontraron empleados con la cédula " + inputCed);

            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();


        }

        static public void Modificar()
        {
            int op = 0;

            Console.Clear();

            Console.WriteLine("Ingrese la cedula del empleado que desea modificar: ");
            string inputMC = Console.ReadLine();

            List<ClsEmpleado> empleadosEncontrados = empleados.FindAll(empleado => empleado.cedula == inputMC);

            if (empleadosEncontrados.Count > 0)
            {


                while (op != 5)
                {
                    Console.Clear();

                    Console.WriteLine("****Elija que atributo desea modificar del empleado**** \n  ");
                    Console.WriteLine(" 1. Nombre \n 2. Direccion \n 3. Telefono \n 4. Salario \n 5. Volver al Menu Principal");

                    Console.Write(" \n Ingrese la opcion deseada:");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:

                            Console.WriteLine("\n Ingrese el nuevo nombre: ");
                            string newName = Console.ReadLine();

                            foreach (ClsEmpleado empleado in empleadosEncontrados)
                            {
                                empleado.nombre = newName;
                            }

                            Console.WriteLine("Se editó correctamente.");
                            Console.ReadKey();

                            break;

                        case 2:

                            Console.WriteLine("\n Ingrese la nueva direccion: ");
                            string newDireccion = Console.ReadLine();

                            foreach (ClsEmpleado empleado in empleadosEncontrados)
                            {
                                empleado.direccion = newDireccion;
                            }

                            Console.WriteLine("Se editó correctamente.");
                            Console.ReadKey();

                            break;

                        case 3:

                            Console.WriteLine("\n Ingrese el nuevo telefono: ");
                            string newtelefono = Console.ReadLine();

                            foreach (ClsEmpleado empleado in empleadosEncontrados)
                            {
                                empleado.telefono = newtelefono;
                            }

                            Console.WriteLine("Se editó correctamente.");
                            Console.ReadKey();

                            break;

                        case 4:

                            Console.WriteLine("\n Ingrese el nuevo salario: ");
                            double.TryParse(Console.ReadLine(), out double newSalario);

                            foreach (ClsEmpleado empleado in empleadosEncontrados)
                            {
                                empleado.salario = newSalario;
                            }

                            Console.WriteLine("Se editó correctamente.");
                            Console.ReadKey();

                            break;

                        case 5:
                            break;

                        default:

                            Console.WriteLine("\n Ingrese una opcion valida");
                            Console.ReadKey();

                            break;

                    }


                }
            }
            else
            {

                Console.WriteLine("\nNo se encontraron empleados con la cédula " + inputMC);
                Console.ReadKey();

            }

        }
        public static void Borrar()
        {

            Console.Clear();

            Console.WriteLine("Ingrese la cedula del empleado que desea eliminar: ");
            string inputDC = Console.ReadLine();

            List<ClsEmpleado> empleadosEncontrados = empleados.FindAll(empleado => empleado.cedula == inputDC);

            if (empleadosEncontrados.Count > 0)
            {

                foreach (ClsEmpleado empleado in empleadosEncontrados)
                {

                    empleados.Remove(empleado);

                    Console.WriteLine("Empleado eliminado exitosamente.");
                    Console.ReadKey();

                }
            }
            else
            {

                Console.WriteLine("\nNo se encontraron empleados con la cédula " + inputDC);
                Console.ReadKey();

            }
        }
        public static void Reportes()
        {

            int op = 0;

            while (op != 5)
            {
                Console.Clear();

                Console.WriteLine("****Reportes**** \n  ");
                Console.WriteLine(" 1. Consultar Empleados \n 2. Listar Todos los Empleados \n 3. Mostrar Promedio de Salarios \n 4. Mostrar Salario mas Alto y Mas Bajo \n 5. Volver al Menu Principal");

                Console.Write(" \n Ingrese la opcion deseada:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        BuscarPorCedula();

                        break;

                    case 2:

                        Console.Clear();

                        Console.WriteLine("Lista de empleados \n");


                        foreach (var item in empleados)
                        {

                            Console.WriteLine("Cedula: " + item.cedula);
                            Console.WriteLine("Nombre: " + item.nombre);
                            Console.WriteLine("Direccion: " + item.direccion);
                            Console.WriteLine("Telefono: " + item.telefono);
                            Console.WriteLine("Salario: " + item.salario + " \n");


                        }

                        Console.ReadKey();

                        break;

                    case 3:

                        Console.Clear();

                        double salarioProme = empleados.Average(empleado => empleado.salario);

                        Console.WriteLine("El promedio de salarios es de: " + salarioProme);

                        Console.ReadKey();


                        break;

                    case 4:

                        Console.Clear();

                        double salarioBajo = empleados.Min(empleado => empleado.salario);
                        double salarioAlto = empleados.Max(empleado => empleado.salario);

                        Console.WriteLine("El salario mas alto es de: " + salarioAlto);

                        Console.WriteLine("El salario mas bajo es de: " + salarioBajo);

                        Console.ReadKey();

                        break;

                    case 5:
                                        
                break;

                    default:

                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();

                        break;


                }


            }



        }
    }
}
