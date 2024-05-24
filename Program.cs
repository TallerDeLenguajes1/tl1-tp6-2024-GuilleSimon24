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

string cadena;
cadena = Console.ReadLine();
int longitud = cadena.Length;
Console.WriteLine("Longitud: "+longitud);
string cadena2;
cadena2 = Console.ReadLine();
string resultadoSuma = cadena + " " + cadena2;
Console.WriteLine("Resultado de la concatenacion: "+resultadoSuma);
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
}*/

string cadenaMayus = resultadoSuma.ToUpper();
Console.WriteLine(cadenaMayus);

string cadenaMinus = resultadoSuma.ToLower();
Console.WriteLine(cadenaMinus);

