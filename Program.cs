// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
int a; 
int b; 
a=10; 
b=a; 
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//Ejercicio 1
/*
string cadena;
cadena = Console.ReadLine();
int numero;
bool resultado = int.TryParse(cadena, out numero);
if (resultado)
{   
    int invertido=0;
    int digito;
    if (numero > 0)
    {
        while (numero > 0)
        {
            digito = numero%10;
            invertido = invertido *10 + digito;
            numero /=10;
        }
    }
Console.WriteLine("Valor del invertido: "+invertido);    
}*/


//Ejercicio 4
/*
string cadena;
cadena = Console.ReadLine();
int longitud = cadena.Length;
Console.WriteLine("Longitud: "+longitud);
string cadena2;
cadena2 = Console.ReadLine();
string resultadoSuma = cadena + " " + cadena2;
Console.WriteLine("Resultado de la concatenacion: "+resultadoSuma);*/
/*
string subCadena = resultadoSuma.Substring(0, 1);
Console.WriteLine(subCadena);

int num1 = 5;
int num2 = 7;
string cadenaNUM1 = num1.ToString();
string cadenaNUM2 = num2.ToString();
int resultado = num1+num2;
string cadenaResultado = resultado.ToString();
Console.WriteLine("La suma de "+cadenaNUM1+" y "+cadenaNUM2+" es: "+cadenaResultado);

foreach (char buscar in resultadoSuma)
{
    Console.WriteLine(buscar);
}

Console.WriteLine("Ingrese la cadena a buscar");
string buscar = Console.ReadLine();

int indice = resultadoSuma.IndexOf(buscar);

if(indice != -1)
{
    string buscada = resultadoSuma.Substring(indice, buscar.Length);
    Console.WriteLine("La cadena \""+buscada+"\" fue encontrada");
}
else
{
    Console.WriteLine("No se encontro la cadena");
}

string cadenaMayus = resultadoSuma.ToUpper();
Console.WriteLine(cadenaMayus);

string cadenaMinus = resultadoSuma.ToLower();
Console.WriteLine(cadenaMinus);
*/


string cadenaMate = Console.ReadLine();


// Eliminar espacios en blanco
        cadenaMate = cadenaMate.Replace(" ", string.Empty);

        // Variables para almacenar los operandos y el operador
        double num1, num2;
        char operador;

        // Buscar el operador en la expresión
        int operadorIndex = -1;
        if (cadenaMate.Contains("+"))
        {
            operadorIndex = cadenaMate.IndexOf("+");
            operador = '+';
        }
        else if (cadenaMate.Contains("-"))
        {
            operadorIndex = cadenaMate.IndexOf("-");
            operador = '-';
        }
        else if (cadenaMate.Contains("*"))
        {
            operadorIndex = cadenaMate.IndexOf("*");
            operador = '*';
        }
        else if (cadenaMate.Contains("/"))
        {
            operadorIndex = cadenaMate.IndexOf("/");
            operador = '/';
        }
        else
        {
            throw new InvalidOperationException("Operador no soportado.");
        }

        // Dividir la expresión en operandos
        string[] partes = cadenaMate.Split(new char[] { operador });

        // Asegurarse de que la expresión tiene dos partes (dos operandos)
        if (partes.Length != 2)
        {
            throw new InvalidOperationException("Expresión inválida.");
        }

        // Convertir los operandos a números
        double resultado;
        if (!double.TryParse(partes[0], out num1) || !double.TryParse(partes[1], out num2))
        {
            throw new InvalidOperationException("Operandos no válidos.");
        }

        // Evaluar la expresión según el operador
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine("El resultado es: "+resultado);
                break;
            case '-':
                resultado = num1 - num2;
                Console.WriteLine("El resultado es: "+resultado);
                break;
            case '*':
                resultado = num1 * num2;
                Console.WriteLine("El resultado es: "+resultado);
                break;
            case '/':
                if (num2 == 0)
                {
                    throw new DivideByZeroException("División por cero.");
                }
                resultado = num1 / num2;
                Console.WriteLine("El resultado es: "+resultado);
                break;
            default:
                throw new InvalidOperationException("Operador no soportado.");
        }

