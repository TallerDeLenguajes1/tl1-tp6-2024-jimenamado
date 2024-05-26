// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("el valor de a:"+a);
Console.WriteLine("el valor de b:",+b);

//EJERCICIO 1 - INVERTIR NUMERO

Console.WriteLine("Ingrese el numero que quiere invertir:");
string cadena = Console.ReadLine();                            //lee un cadena de texto
Console.WriteLine("la cadena ingresada:"+cadena);

int num=0;//inicializado
bool resultado = int.TryParse(cadena, out num);

if (resultado)     
{
    if (num>0)
    {
        int numInvertido = 0;

        while (num > 0)
        {
            int digito = num%10;
            numInvertido = numInvertido * 10 + digito;
            num = num/10;

        }
        Console.WriteLine("El numero invertido es:"+numInvertido);

    }else if (num < 0)
    {
        Console.WriteLine("El Numero Ingresado es < 0");
    }
    else
    {
    Console.WriteLine("El Numero Ingresado es 0");
    }
}else
{
    Console.WriteLine("Caracter ingresado no valido");
}
