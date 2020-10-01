using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using EFcoreTutorial.Ejemplos;

namespace EFcoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }

        private static void Menu()
        {
            int opcion = 0;
            string auxOpcion = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("NOTA: En el contexto y en las entidades hay configuraciones que le ayudan a estos ejemplos que hice.");
                Console.WriteLine("\n\n                                 MENU:                               ");
                Console.WriteLine("1. Guardar un estudiante en la BD.");
                Console.WriteLine("2. Hacer un simple Query.");
                Console.WriteLine("3. Hacer un doble Query.");
                Console.WriteLine("4. Hacer un query usando SQL.");
                Console.WriteLine("5. Actualizar data de una entidad.");
                Console.WriteLine("6. Borrar data de una entidad.");
                Console.WriteLine("7. Actualizar data de una entidad usando Range en un escenario desconectado.");
                Console.WriteLine("8. Borrar data de una entidad usando en Range en un escenario desconectado.");
                Console.WriteLine("9. Hacer ChangeTracker a varias entidades.");
                Console.WriteLine("10. Hacer DetachedContext a propiedades de una entidad.");
                Console.WriteLine("11. Hacer un Graph en un escenario desconectado.");
                Console.WriteLine("12. Hacer Querry Parametrizado.");
                Console.WriteLine("13. Salir.");
                Console.WriteLine("OPCION:");
                auxOpcion = Console.ReadLine();
                opcion = Convertir(auxOpcion);
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        EjemplosEFcore.GuardarStudentDB();//Ejemplo de guardar en DB
                        Console.ReadKey();
                        break;
                    case 2:
                        EjemplosEFcore.SimpleQueryDB(); //Ejemplo de hacer un query en DB
                        Console.ReadKey();
                        break;
                    case 3:
                        EjemplosEFcore.DoubleQueryDB(); //Ejemplo de query con Include
                        Console.ReadKey();
                        break;
                    case 4:
                        EjemplosEFcore.QuerryUsingSql(); //Ejemplo de query usando expresion SqlRaw
                        Console.ReadKey();
                        break;
                    case 5:
                        EjemplosEFcore.UpdatingData(); //Ejemplo de modificando data
                        Console.ReadKey();
                        break;
                    case 6:
                        EjemplosEFcore.DeletingData(); //Ejemplo de borrando data
                        Console.ReadKey();
                        break;
                    case 7:
                        EjemplosEFcore.UpdatingOnDisconnectedScenario(); //Ejemplo de actualizando con Range y desconectado
                        Console.ReadKey();
                        break;
                    case 8:
                        EjemplosEFcore.DeletingOnDisconnectedScenario(); //Ejemplo de borrando con range y desconectado
                        Console.ReadKey();
                        break;
                    case 9:
                        EjemplosEFcore.ChangeTracker(); //ejemplo para rastrear los metodos que invoquen el Contexto
                        Console.ReadKey();
                        break;
                    case 10:
                        EjemplosEFcore.DetachedContext(); //Este ejemplo sirve para separar un registro de la tabla de manera conectada
                        Console.ReadKey();
                        break;
                    case 11:
                        EjemplosEFcore.EntityGraphDisconnected(); //Ejemplo de graph desconectado del escenario
                        Console.ReadKey();
                        break;
                    case 12:
                        EjemplosEFcore.QuerryParametrizado();  //Ejemplo de querying parametrizado
                        Console.ReadKey();
                        break;
                    case 13:
                        break;
                }
            }
            while (opcion != 13);
        }

        private static int Convertir(string aux)
        {
            int opcion = 0;
            try
            {
                opcion = Convert.ToInt32(aux);
                return opcion;
            }
            catch (Exception)
            {

                Console.WriteLine("Debe ser un numero...");
            }
            return opcion;
        }
    }
}
