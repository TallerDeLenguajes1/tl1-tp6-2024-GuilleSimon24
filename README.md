# Respondiendo a las preguntas
## Tipo String
El tipo "String" en C#, en el contexto de .NET, es un tipo por referencia, que se comporta un poco distinto a otros tipos por referencia
## Secuencias de escape
String tiene varias secuencias de escape, muy similares a las secuencias de escape que se usaban en el printf en C, como por ejemplo **\n** para el salto de linea o **\\'** y **\\"** para comillas simples y dobles, respectivamente
## Usos de @ y $
Usando el tipo String podemos encontrar dos usos reservados para los caracteres @ y $
El @ hace que las cadenas que se guardan en un tipo string ignoren las secuencias de escape \, lo que permite usar la barra invertida sin necesidad de su respectiva secuencia "\\", esto se simplifica cuando se guardan rutas de acceso por ejemplo
Ejemplo:
  String cadena = @"Esta es la direccion C:\documents\Konami\ProEvolutionSoccer\PES2013"

En el caso del \$, se usa para interpolar cadenas, lo que permite hacer es facilitar el concatenamiento dentro de las cadenas usando llaves {} para llamar valores dentro de la cadena sin tener que concatenar con ++
Ejemplo:
  String cadenaConcatenada = "Hola me llamo "+nombre+" y tengo "+edad+" años";
  String cadenaInterpolada = \$"Hola me llamo {nombre} y tengo {edad} años";
