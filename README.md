String es un tipo por referencia. En C#, los tipos por referencia almacenan una referencia a la dirección de memoria donde se encuentra el objeto real.
Por lo tanto, cuando se manipula una cadena (string), se está trabajando con una referencia al objeto de cadena en la memoria, no con los datos de la cadena en sí.

Las secuencias de escape que se pueden utilizar en una cadena (string) en C# incluyen:

\n : Nueva línea
\r : Retorno de carro
\t : Tabulación horizontal
\\ : Barra invertida
\" : Comilla doble
\' : Comilla simple
\0 : Carácter nulo
\a : Alerta (campana)
\b : Retroceso
\f : Avance de página
\v : Tabulación vertical

Carácter @: Se utiliza para definir una cadena literal verificada (verbatim string). Esto significa que la cadena se toma tal cual, sin procesar las secuencias de escape. 
Además, las comillas dobles dentro de la cadena se representan como comillas dobles dobles ("").
Carácter $: Se utiliza para definir una cadena interpolada (interpolated string). Esto permite incluir expresiones dentro de la cadena que se evalúan y se insertan en la cadena resultante. 
Las expresiones se encierran entre llaves {}.
