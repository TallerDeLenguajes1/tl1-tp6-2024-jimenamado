internal class Program
{
    private static void Main(string[] args)
    {
        string cadena1, cadena2, concatenado, palabraBuscada;

        do
        {
            Console.WriteLine("Ingrese una frase:");
            cadena1 = Console.ReadLine();
            
        } while (String.IsNullOrEmpty(cadena1));        //devuelve true si la cadena es NULL o vacia
       
        // Longitud de una cadena
        int longitudCad = cadena1.Length;
        Console.WriteLine("Longitud de la cadena:"+longitudCad);
        
        //Concatenar cad1 y cad2
        do
        {
            Console.WriteLine("Ingrese una frase:");
            cadena2 = Console.ReadLine();

        } while (String.IsNullOrEmpty(cadena2));

        concatenado = string.Concat(cadena1," ", cadena2);
        Console.WriteLine("cadena concatenada:"+concatenado);

        //recorrer la cadena con un ciclo foreach
        foreach(var caracteres in concatenado)
        {
            Console.WriteLine(caracteres);
        }

        /*Determinar ocurrencia de una palabra ingresada
        ejemplo: int index = "hello world".IndexOf("world"); // 6*/
        do
        {
            Console.WriteLine("Ingrese la palabra que busca");
            palabraBuscada = Console.ReadLine();

        } while (String.IsNullOrEmpty(palabraBuscada));

        int indice = concatenado.IndexOf(palabraBuscada,StringComparison.OrdinalIgnoreCase);
        //indexOf distingue entre mayusculas y minusculas
        //StringComparison.OrdinalIgnoreCase sirve para que la busqueda se haga sin diferenciar Mayus y minusc.
        
        Console.WriteLine("Indice donde comienza la palabra buscada:" +indice);

        /*Convertir cadena en Minuscula y Mayuscula
        ejemplo:
        ToUpper();
        string upper = "hello".ToUpper(); // "HELLO"
        ToLower();
        string lower = "HELLO".ToLower(); // "hello"*/

        string CadenaMinuscula = concatenado.ToUpper();
        Console.WriteLine(CadenaMinuscula);

        String cadenaMayuscula = concatenado.ToLower();
        Console.WriteLine(cadenaMayuscula);

        /*usando split():Divide una cadena en una matriz de subcadenas basadas en uno o más caracteres delimitadores.
        ejemplo: string[] parts = "apple,banana,cherry".Split(','); // ["apple", "banana", "cherry"]        
        */
        string[] parts = concatenado.Split(' ');
        Console.WriteLine(parts);



        
    }
}