// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
int a; 
int b; 
a=10; 
b=a; 
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//Ejercicio 1

/*string cadena;
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



//Ejercicio 3

Console.WriteLine("Ingrese un numero: ");
string cadena = Console.ReadLine();

int numero;
bool anda = int.TryParse(cadena, out numero);

if (anda)
{
    Console.WriteLine("El valor absoluto es: "+numero+" y -"+numero);
    int cuadrado = numero*numero;
    Console.WriteLine("El cuadrado es: "+cuadrado);
    double numReal;
    bool andaReal = double.TryParse(cadena, out numReal); 
    if (andaReal)
    {
        double raiz;
        raiz = Math.Sqrt(numReal);
        Console.WriteLine("La raiz cuadrada es: "+raiz);
        double seno = Math.Sin(numReal);
        double Coseno = Math.Cos(numReal);
        string cadenaSeno = seno.ToString("F2");
        string cadenaCoseno = Coseno.ToString("F2");
        Console.WriteLine("El Seno es: "+cadenaSeno);
        Console.WriteLine("El Coseno es: "+cadenaCoseno);
        string cadenaReal = numReal.ToString("F2");
        Console.WriteLine("La parte entera del numero "+numReal+" es: "+numero);


    }
    
}else
{
    Console.WriteLine("Ingreso un numero invalido");
}   

Console.WriteLine("Ahora ingrese dos numeros distintos");
cadena = Console.ReadLine();
int num1;
bool andaNum1 = int.TryParse(cadena, out num1);
Console.WriteLine("Ingrese el segundo numero: ");
cadena = Console.ReadLine();
int num2;
bool andaNum2 = int.TryParse(cadena, out num2);
if (andaNum1 && andaNum2 && (num1 != num2))
{
    if (num1 > num2)
    {
        Console.WriteLine("El numero "+num1+" es mayor que el numero "+num2);
    }else
    {
        Console.WriteLine("El numero "+num2+" es mayor que el numero "+num1);
    }

}else
{
    Console.WriteLine("Ingreso numeros invalidos");
}