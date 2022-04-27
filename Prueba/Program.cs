using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pruebas: " + "\n 1. Serie" +
                "\n 2. Operaciones con fechas" + "\n Ingrese una opción.");
            int op = int.Parse(Console.ReadLine());
            if(op == 1)
            {
                Console.WriteLine("Elija una Opción" +
                                "\n 1. Utilizar la serie por defecto." + "\n 2. Generar una serie.");
                int op1 = int.Parse(Console.ReadLine());               
                if (op1 == 1)
                {
                    String cad = "";
                    int[] serie = { 7, 6, 8, 4, 9, 2, 10, 0, 11, -2 };
                    Console.WriteLine("La serie es:");
                    for (int i = 0; i < serie.Length; i++)
                    {
                        if (i == serie.Length - 1)
                        {
                            cad += serie[i];
                        }
                        else
                        {
                            cad += serie[i] + ",";
                        }
                    }
                    Console.WriteLine("Ingresa un valor para x.");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa un valor para y.");
                    int y = int.Parse(Console.ReadLine());
                    int res = sumSerie(x, y, serie);
                    Console.WriteLine(res);
                }else if (op1 == 2)
                {
                    Console.WriteLine("Escriba un tamaño para la serie.");
                    int n = int.Parse(Console.ReadLine());
                    String cad = "";
                    int[] serie = new int[n];
                    for (int i = 0; i < serie.Length; i++)
                    {
                        Console.WriteLine("Escriba un numero para la posicion "+ (i+1) +" de la serie");
                        serie[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("La serie es:");
                    for (int i = 0; i < serie.Length; i++)
                    {
                        if (i == serie.Length - 1)
                        {
                            cad += serie[i];
                        }
                        else
                        {
                            cad += serie[i] + ",";
                        }
                    }
                    Console.WriteLine("Ingresa un valor para x.");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa un valor para y.");
                    int y = int.Parse(Console.ReadLine());
                    int res = sumSerie(x, y, serie);
                    Console.WriteLine(res);
                }
                else
                {
                    Console.WriteLine("Elija una opción valida.");
                    Console.WriteLine("Elija una Opción" +
                                "\n 1. Utilizar la serie por defecto." + "\n 2. Generar una serie.");
                    op1 = int.Parse(Console.ReadLine());
                }
            }else if (op == 2)
            {
                Console.WriteLine("Escriba el numero del dia de la semana que desea calcular. \n 1 = Lunes y 7 = Domingo");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba la fecha pivote con el siguiente formato yyyy-MM-dd.");
                String fec = Console.ReadLine(); 
                String[] fechas = eightDayOfWeek(day, fec);
                for (int i = 0; i < fechas.Length; i++)
                {
                    Console.WriteLine(fechas[i]);
                }
            }
            else
            {
                Console.WriteLine("Eliga una opción valida.");
                Console.WriteLine("Pruebas: " + "\n 1. Serie" +
                "\n 2. Operaciones con fechas" + "\n Ingrese una opción.");
                op = int.Parse(Console.ReadLine());
            }
        }

        public static int sumSerie(int x, int y, int[] serie)
        {
            
            if((x > 0 && x <= 255) && (y > 0 && y <= 255))
            {
                return serie[x-1] + serie[y-1];
            }
            else
            {
                return -1;
            }
            
        }

        public static String[] eightDayOfWeek(int day, String fecha)
        {
            String[] dt = new string[8];
            DateTime t = DateTime.Parse(fecha);

            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    for (int j = 1; j < 8; j++)
                    {
                        if (day == 7)
                        {
                            t = t.AddDays(1);
                            if ((int)t.DayOfWeek == 0)//Validacion para domingo
                                //En esta funcion el domingo == 0
                            {
                                dt[i] = t.ToString("yyyy-MM-dd");
                                break;
                            }
                        }
                        else
                        {
                            t = t.AddDays(1);
                            if ((int)t.DayOfWeek == day)
                            {
                                dt[i] = t.ToString("yyyy-MM-dd");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    t = t.AddDays(7);
                    dt[i] = t.ToString("yyyy-MM-dd");
                }
            }               
            return dt;
        }
    }
}
