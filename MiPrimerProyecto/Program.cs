using System;

namespace MiPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            tiposDeVariables();
            tipoDeOperaciones();
            operadoresDeAsignacion();
            operadoresDeComparacion();
            condicionales();
            trianguloDePascal();
            objetos();
            Console.ReadLine();

        }

        public static void objetos()
        {
            var nombre = (nombre1:"Alex",
                          edad:23
                );

            Console.WriteLine($"{nombre.nombre1} mi edad es {nombre.edad} ");
        }


        public static void trianguloDePascal()
        {
            int pisos = 0;
            int[] arr = new int[1];
            Console.WriteLine("ingrese el numero de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());
            for(int i = 1; i <= pisos; i++)
            {
                int[] pascal = new int[i];
                for (int j = pisos; j < i; j--){
                    Console.Write("");
                }

                for (int k = 0; k < i; k++)
                {
                    if(k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        pascal[k] = arr[k] + arr[k - 1];
                    }
                    Console.Write("[" + pascal[k] + "]");
                }
                arr = pascal;
                Console.WriteLine(" ");
            }
        }


        public static void condicionales()
        {
            int valor1 = 0;
            int valor2 = 1;
            var data = valor1 != valor2;
            if (data)
            {
                Console.WriteLine("Condicionales ==> No son inguales ");
            }

            string name = "juan";
            string name2 = "juan";
            string name3 = true ? "valencia" : "salgado";
        }


        public static void operadoresDeComparacion()
        {
            int valor1 = 1;
            int valor2 = 5;

            Boolean valor3 = valor1< valor2;
            Boolean valor4 = valor1 <= valor2;
            var valor5 = valor1 == valor2;

            Console.WriteLine("OperadoresDeAsignacion Valor3 =" + valor5);


        }


        public static void operadoresDeAsignacion()
        {
            int valor1 = 1;
            int valor2 = 5;

            valor2 += valor1;

            Console.WriteLine("OperadoresDeAsignacion Valor2 =" + valor2);

        }

        /**
         * Tipos de operadores
         */
        public static void tipoDeOperaciones()
        {
            int valor1 = 2;
            int valor2 = 3;

            int suma = valor1 + valor2;
            int resta = valor1 - valor2;
            double divicion = valor1 / valor2;
            int multiplicacion = valor1 * valor2;
            int mod = valor1 % valor2;

            Console.WriteLine("TipoDeOperaciones");
            Console.WriteLine("suma  =  " + suma + ";  resta  =  " + resta + ";  multiplicacion  =  " + multiplicacion + ";  divicion  =  " + divicion +";  residuo  =   "+ mod);
        }

        /**
         * inicializacion de variables
         */
        public static void tiposDeVariables()
        {
            Console.WriteLine("Asignacion de variables");
            //Inicializar atributos
            int prueba = 0;
            int year = 2;
            double deciMal = 2.9;
            string nombre = "Juan";
            string nombres = "maria";
            decimal decimals = 2.123M;
            float flotante = 8.0f;
            bool verdadero = false;
            char letra = 'A';
            Decimal de = 28.5M;


            //como convertir datos de tipo string a int
            int año = Convert.ToInt16("12");

            Console.WriteLine("Hello " + nombre + "! {0} {1} {2}", year, prueba, año);
            Console.WriteLine("Hello " + nombres + "! {0} {1} {2}", deciMal, nombre, decimals);
            Console.WriteLine("Hello! {0}", flotante);

        }
    }

}
