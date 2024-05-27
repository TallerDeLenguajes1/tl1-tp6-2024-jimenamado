
internal class Program
{
    private static void Main(string[] args)
    {
         
        int flag = 1;
        float operacion, resultadoOperacion;
        float num1, num2;

        while (flag == 1)
        {
            Console.WriteLine("Ingrese la operacion a realizar:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Valor Absoluto");
            Console.WriteLine("6. Cuadrado");
            Console.WriteLine("7. La raiz cuadrada");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Coseno");
            Console.WriteLine("10. Parte entera de un tipo float");
            Console.WriteLine("11. Finalizar");

            operacion = 0;
            var codigo = Console.ReadLine();
            bool result = float.TryParse(codigo, out operacion);


            if (result && (operacion >= 1 && operacion <= 11))
            {

                if (operacion < 5)
                {
                    Console.WriteLine("Ingrese el primer numero");
                    num1 = 0;
                    var cad1 = Console.ReadLine();
                    bool result1 = float.TryParse(cad1, out num1);

                    Console.WriteLine("Ingrese el siguiente numero");
                    num2 = 0;
                    var cad2 = Console.ReadLine();
                    bool result2 = float.TryParse(cad2, out num2);


                    if (result1 && result2)
                    {
                        switch (operacion)
                        {
                            case 1:
                                resultadoOperacion = num1 + num2;
                                Console.WriteLine("Suma =" + resultadoOperacion);
                                break;
                            case 2:
                                resultadoOperacion = num1 - num2;
                                Console.WriteLine("Resta =" + resultadoOperacion);
                                break;
                            case 3:
                                resultadoOperacion = num1 * num2;
                                Console.WriteLine("Producto =" + resultadoOperacion);
                                break;
                            case 4:
                                if (num2 > 0)
                                {
                                    resultadoOperacion = num1 / num2;
                                    Console.WriteLine("Division =" + resultadoOperacion);
                                }
                                else
                                {
                                    Console.WriteLine("Indefinido");
                                }
                                break;

                        }
                    }

                }
                else
                {
                    if (operacion >= 5 && operacion < 11)
                    {
                        Console.WriteLine("Ingrese un numero");

                        num1 = 0;
                        var cad1 = Console.ReadLine();
                        bool result1 = float.TryParse(cad1, out num1);

                        if (result1)
                        {
                            switch (operacion)
                            {
                                case 5:
                                    resultadoOperacion = Math.Abs(num1);
                                    Console.WriteLine($"Valor Absoluto ({num1}) = {resultadoOperacion}");
                                    break;
                                case 6:
                                    resultadoOperacion = num1 * num1;
                                    Console.WriteLine($"Cuadrado ({num1}) = {resultadoOperacion}");
                                    break;
                                case 7:
                                    resultadoOperacion = (float)Math.Sqrt(num1);
                                    Console.WriteLine($"Raiz Cuadrada ({num1}) = {resultadoOperacion}");
                                    break;
                                case 8:
                                    resultadoOperacion = (float)Math.Sin(num1);
                                    Console.WriteLine($"Seno ({num1}) = {resultadoOperacion}");
                                    break;
                                case 9:
                                    resultadoOperacion = (float)Math.Cos(num1);
                                    Console.WriteLine($"Coseno ({num1}) = {resultadoOperacion}");
                                    break;
                                case 10:
                                    int resultadoEntero;
                                    resultadoEntero = (int)Math.Round(num1);
                                    Console.WriteLine($"Raiz Cuadrada ({num1}) = {resultadoEntero}");
                                    break;
                            }
                        }

                    }
                    else
                    {
                        flag = 0;
                        Console.WriteLine("calculadora finalizada");

                    }
                }

            }
        }

    }
}