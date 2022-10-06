using System;

namespace Ejercicio_12
{

    class Program
    {
        // Main 
        static void Main(string[] args)
        {
            int meses = 13;
            int dias = 31;
            int colaboradores = 17;
            int hmax = 16; // Se guardo el costo total de cada dia 

            // Array [dias, meses, empleados]
            int[,,] array = new int[dias, meses, colaboradores];

            // Metodo incializacion del array
            inicializacion(ref array, meses, dias, colaboradores);

            // Comienzo del ingreso de datos
            for (int j = 1; j < meses; j++) // Meses
            {
                for (int i = 1; i < dias; i++) // Dias 
                {
                    // impresion del dia
                    Console.WriteLine($"Fecha de hoy: Dia: {i} Mes: {j}");

                    // Metodo ingreso del costo del dia y de los colaboradores
                    ingresoCostoyColab(ref array, colaboradores, j, i);

                    // Metodo costo del dia, ausentes, produccion total, alerta de ensamble y promedioT2
                    costoAusentesProduccion(ref array, i, j, colaboradores, hmax);

                    // costoAusentesProduccion tambien llama a la impresion de los datos calculados
                }
            }

            // Metodo para el calculo del dia de mayor produccion
            produccionMayor(ref array, meses, dias, hmax);

            // Metodo para promediar la produccion del mes 6
            promedioMes6(ref array, dias, hmax);

            Console.ReadKey();
        } // Fin main 

        //incializacion del array
        public static void inicializacion(ref int[,,] array, int m, int d, int c)
        {
            for (int j = 0; j < m; j++) // Estos son los meses
            {
                for (int i = 0; i < d; i++) // Estos son los dias
                {
                    for (int h = 0; h < c; h++) // Estos son los colaboradores 
                    {
                        array[i, j, h] = 0;
                    }
                }
            }
        } // Fin metodo 

        // Ingreso costo y colaboradores
        public static void ingresoCostoyColab(ref int[,,] array, int colaboradores, int j, int i)
        {

            for (int h = 0; h < colaboradores - 1; h++) // Costo y colaboradores
            {
                if (h == 0)
                {
                    // El primer ingreso del dia es el costo unitario en el primer indice (0)
                    Console.WriteLine("Ingrese el costo unitario del dia de hoy");               
                }
                else
                {
                    Console.WriteLine($"Cuanto produjo el colaborador {h}?");
                }
                array[i, j, h] = int.Parse(Console.ReadLine());
            }
        } // Fin metodo 

        // Costo del dia, ausentes, produccion total, alerta de ensamble
        public static void costoAusentesProduccion(ref int[,,] array, int i, int j, int colaboradores, int hmax)
        {
            // Seteo y reinicio de variables
            int ProduccionTotal = 0;
            int CostodelDia = 0;
            int ausente = 0;
            int TrabajadoresT2 = 0;
            int ProduccionT2 = 0;
            int PromedioT2;

            // Calculo de Costo del dia, ausentes y produccion total
            for (int h = 1; h < colaboradores - 1; h++)
            {
                CostodelDia = CostodelDia + (array[i, j, h] * array[i, j, 0]); // Lo que hizo el colaborador en el dia y mes por el costo unitario 
                if (array[i, j, h] == 0)
                {
                    ausente++;
                }
                ProduccionTotal = ProduccionTotal + array[i, j, h];
            }

            // Condicional de la alerta de ensamble
            if (ProduccionTotal < 400 || ProduccionTotal > 1700)
            {
                Console.WriteLine("ALERTA DE ESAMBLE");
            }

            // Recorrido para promediar la produccion del segundo turno del empleado 6° al 10°
            for (int h = 6; h < 11; h++)
            {
                TrabajadoresT2++;
                ProduccionT2 = ProduccionT2 + array[i, j, h];
            }
            PromedioT2 = ProduccionT2 / TrabajadoresT2;


            // Almacenamiento de la variable ProduccionTotal en la ultima posicion
            array[i, j, hmax] = ProduccionTotal;


            impresion(CostodelDia, ProduccionTotal, ausente, PromedioT2); // Esto se imprime al final de cada día
        }

        // Impresion de datos (llamado desde costo del dia, ausentes...)
        public static void impresion(int CostodelDia, int ProduccionTotal, int ausente, int Promedio)
        {
            Console.WriteLine($"El costo del dia fue {CostodelDia}");
            Console.WriteLine("La produccion total es de " + ProduccionTotal);
            Console.WriteLine($"La cantidad de ausentes es {ausente}");
            Console.WriteLine($"El promedio del turno 2 es {Promedio}");
            Console.WriteLine("______________________________________________");

        } // Fin metodo

        // Calculo del mayor dia de produccion
        public static void produccionMayor(ref int[,,] array, int m, int d, int hmax)
        {
            int ProduccionMayor = 0;
            int MesMayor = 0;
            int DiaMayor = 0;

            // Recorrido para determinar cual fue el dia y el mes de mayor produccion
            for (int j = 1; j < m; j++)
            {
                for (int i = 1; i < d; i++)
                {
                    // En el indice 6 guardamos la produccion total de cada dia
                    if (ProduccionMayor < array[i, j, hmax])
                    {
                        // Guardamos cada variable maxima
                        ProduccionMayor = array[i, j, hmax];
                        MesMayor = j;
                        DiaMayor = i;
                    }
                }
            } // Fin recorrido mayor produccion
            Console.WriteLine($"En dia {DiaMayor} del mes {MesMayor} fue la producción maxima con un ensamble de {ProduccionMayor}");
        } // Fin metodo

        // Calculo del promedio del sexto mes
        public static void promedioMes6(ref int[,,] array, int dias, int hmax)
        {
            int PromedioMes6;
            int ProduccionMes6 = 0;
            int DiasMes6 = 0;

            for (int i = 1; i < dias; i++)
            {
                DiasMes6++;
                ProduccionMes6 = ProduccionMes6 + array[i, 6, hmax]; // Usando la produccion total de la sexta posicion
                                                                     // de cada dia del mes 6 (j = 6)
            }
            PromedioMes6 = ProduccionMes6 / DiasMes6;
            Console.WriteLine($"El promedio diario de productos esamblados del mes 6 es {PromedioMes6}");
            // Fin recorrido e impresion

        }  // Fin metodo
    }


}
