// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
int a; 
int b; 
a=10; 
b=a; 
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//Ejercicio 1

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
}




