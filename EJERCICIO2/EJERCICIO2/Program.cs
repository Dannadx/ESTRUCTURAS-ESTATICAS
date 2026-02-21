using System;

class CODIGOASCII
{
    static void Main()
    {
        Console.WriteLine("EJERCICIO 2 ");//LINEA PARA MOSTRAR MENSAJE EN PANTALLA
        Console.Write("Ingrese el código a interpretar "); //solicitar el codigo
        string codigo = Console.ReadLine();//almacenar codigo en variable y permitir que el usuario ingrese datos

        //ciclo for para recorrer el codigo, siempre y cuando sea menor al ancho del codigo
        for (int i =0; i< codigo.Length; i++) 
        {
            char caracter = codigo[i]; //variable para guardar cada valor del código
            int cod = (int)caracter + 3; //convierte los caracteres a enteros para poder realizar la suma
            Console.Write(cod + " ");//escribe el numero y le suma 3 
        }
        

    }
}