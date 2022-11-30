using System;

namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("hola mundo");
            //numero entero
            int numero=7;
            String cadena="hola";

            Console.WriteLine(numero);
            if(numero>5) {
                Console.WriteLine("has aprobado");
            }else{
                Console.WriteLine("has suspendido");
            }
            Console.WriteLine(cadena);
            */
            /*
            for (int i=0;i<10;i++) {

                Console.WriteLine("hola"+i);
            }
            int j=0;

            while (j<10) {
                Console.WriteLine("hola"+j);
                j++;
            }
            */
            int[] lista= new int[] {1,3,7,8,1};

            for (int i=0;i<lista.Length;i++) {

                Console.WriteLine(lista[i]);
            }
            
            String [] lista2 = new String[] {"hola","que","tal"};


            for (int i=0;i<lista2.Length;i++) {

                Console.WriteLine(lista2[i]);
            }

        }
    }
}
