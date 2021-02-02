using System;

namespace G4E1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROGRAMACION ESTRUCTURADA GRUPO 07L
             * EJERCICIO 1 GUIA 3
             * 
             * OSCAR ROLANDO CAÑAS VALDIZON
             */

            Console.Title = "Test de Capacitacion";
            //VARIABLES
            string datos_base;
            int ptotales, pcontest, porcentaje;
            //TITULO
            string title = "TEST DE CAPACITACION";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            Console.WriteLine("\nBienvenido al test de capacitacion.");
            Console.WriteLine("\nEn este programa mide la capacidad de cada persona en base a las preguntas contestadas.");
            //SOLICITUD DE DATOS NECESARIOS
            Console.WriteLine("\nPor favor ingrese el numero de preguntas realizadas, seguido del numero de preguntas contestadas SEPARADOS POR UNA COMA Y UN ESPACIO...");
            Console.WriteLine("Asi:\n\tSi por ejemplo se preguntaron 300 preguntas y de ellas solo 64 respondio debera ingresar 300, 64 con el teclado.");
            datos_base = Console.ReadLine();
            //SEPARACION Y CONVERSION DE DATOS
            ptotales = int.Parse(datos_base.Substring(0, datos_base.IndexOf(',')));
            pcontest = int.Parse(datos_base.Substring((datos_base.IndexOf(',') + 2)));
            //IMPRESION DE DATOS POR CUALQUIER ERROR DE LECTURA Y/O INGRESO DE DATOS
            Console.WriteLine("\nEL NUMERO DE PREGUNTAS TOTALES SON: " + ptotales);
            Console.WriteLine("EL NUMERO DE PREGUNTAS CONTESTADAS SON: " + pcontest);
            Console.WriteLine("NOTA: Si cree que existe un error ingrese de nuevo los datos con la sintaxis correcta:");
            Console.WriteLine("      Preguntas_Totales, Preguntas_Contestadas   --->   300, 64\n\n");
            //OBTENCION DE PORCENTAJE
            porcentaje = (100 * pcontest) / ptotales;
            //CONDICIONALES CON SU IMPRESION DE RESULTADOS
            if (porcentaje >= 90)
            {
                Console.WriteLine("En base a sus resultados, el porcentaje de conocimiento es de " + porcentaje + "% y por lo tanto usted posee un NIVEL MAXIMO de conocimiento.");
                Console.WriteLine("FELICIDADES POR SU LOGRO");
            }
            else if (porcentaje >= 75 && porcentaje < 90)
            {
                Console.WriteLine("En base a sus resultados, el porcentaje de conocimiento es de " + porcentaje + "% y por lo tanto usted posee un NIVEL MEDIO de conocimiento.");
            }
            else if (porcentaje >= 50 && porcentaje < 75)
            {
                Console.WriteLine("En base a sus resultados, el porcentaje de conocimiento es de " + porcentaje + "% y por lo tanto usted posee un NIVEL BAJO de conocimiento.");
            }
            else if (porcentaje < 50)
            {
                Console.WriteLine("En base a sus resultados, el porcentaje de conocimiento es de " + porcentaje + "% y por lo tanto usted se encuentra FUERA DE NIVEL de conocimiento.");
            }
            //FIN DEL PROGRAMA
            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
