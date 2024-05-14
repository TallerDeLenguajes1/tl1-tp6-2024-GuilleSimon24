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

Console.WriteLine("Elija una opcion");
Console.WriteLine("1 sumar");
Console.WriteLine("2 restar");
Console.WriteLine("3 dividir");
Console.WriteLine("4 multiplicar");
string cadena = Console.ReadLine();

int opcion;
bool resultado = int.TryParse(cadena, out opcion);

if (resultado)
{
    bool resulta2;
    bool resulta3;
    int res;
    int numeroA;
    int numeroB;
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el numero 1");
            cadena = Console.ReadLine();
            resulta2 = int.TryParse(cadena, out numeroA);
            Console.WriteLine("Ingrese el numero 2");
            cadena = Console.ReadLine();
            resulta3 = int.TryParse(cadena, out numeroB);
            if (resulta2 && resulta3)
            {
                res = numeroA +numeroB;
                Console.WriteLine("El resultado es: "+res);    
            }
        break;

        case 2:
            Console.WriteLine("Ingrese el numero 1");
            cadena = Console.ReadLine();
            resulta2 = int.TryParse(cadena, out numeroA);
            Console.WriteLine("Ingrese el numero 2");
            cadena = Console.ReadLine();
            resulta3 = int.TryParse(cadena, out numeroB);
            if (resulta2 && resulta3)
            {
                res = numeroA - numeroB;
                Console.WriteLine("El resultado es: "+res);    
            }
            
        break;
        case 3:
            Console.WriteLine("Ingrese el numero 1");
            cadena = Console.ReadLine();
            resulta2 = int.TryParse(cadena, out numeroA);
            Console.WriteLine("Ingrese el numero 2");
            cadena = Console.ReadLine();
            resulta3 = int.TryParse(cadena, out numeroB);
            if (resulta2 && resulta3 && numeroB != 0)
            {
                res = numeroA / numeroB;
                Console.WriteLine("El resultado es: "+res);    
            }

        break;

        case 4:
            Console.WriteLine("Ingrese el numero 1");
            cadena = Console.ReadLine();
            resulta2 = int.TryParse(cadena, out numeroA);
            Console.WriteLine("Ingrese el numero 2");
            cadena = Console.ReadLine();
            resulta3 = int.TryParse(cadena, out numeroB);
            if (resulta2 && resulta3)
            {
                res = numeroA * numeroB;
                Console.WriteLine("El resultado es: "+res);    
            }

        break;

        default:

        break;
        
    }
}