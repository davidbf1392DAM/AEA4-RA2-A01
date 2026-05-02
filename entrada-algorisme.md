[Inici](index.md) | [Creació, configuració i ús de GitHub](entrada-github.md) 
# Càlcul de la lletra del DNI amb Csharp#

En aquesta part de l’activitat he desenvolupat un programa en **C#** utilitzant **Visual Studio Code**. L’objectiu del programa és calcular la lletra corresponent a un número de DNI introduït per l’usuari.  
  
## Entorn de desenvolupament  

Per fer aquesta activitat he utilitzat **Visual Studio Code** com a entorn de desenvolupament i el **SDK** de **.NET** per crear, compilar i executar el projecte en llenguatge **C#** des de la terminal.

Per preparar l’entorn he instal·lat l’extensió **C# Dev Kit**, que afegeix suport per treballar amb projectes **C#** i **.NET** dins de **VSCode**. Aquesta extensió facilita l’escriptura del codi amb **IntelliSense**, permet detectar errors, navegar pel projecte i executar o depurar aplicacions de consola.

En instal·lar **C# Dev Kit** també s’han instal·lat extensions relacionades, com **C#** i **.NET Install Tool**, que complementen el suport necessari per desenvolupar aplicacions en **C#** dins de **Visual Studio Code**.
  
## Funcionament del programa  
  
El programa demana a l’usuari que introdueixi els 8 dígits numèrics del DNI, sense la lletra. A continuació, valida que l’entrada tingui exactament 8 dígits i que tots siguin numèrics.  
  
Després, el programa calcula el residu de dividir el número del DNI entre 23. Aquest residu s’utilitza com a posició dins de la cadena de lletres vàlides del DNI:  
  
```text  
TRWAGMYFPDXBNJZSQVHLCKE  
```  
  
Finalment, el programa mostra la lletra calculada i el DNI complet.

## Prova d’execució 1  

En aquesta prova he introduït un número de DNI correcte i el programa ha calculat la lletra corresponent.
  
```text  
Introdueix el número del DNI sense lletra: 87654321 
```  
  
Sortida del programa:  
  
```text  
La lletra del DNI és: X  
DNI complet: 87654321X
```  
  
## Prova d’execució 2  (validació d'entrada)  

En aquesta prova he introduït primer un valor incorrecte, ja que no conté exactament 8 dígits numèrics. El programa detecta l’error i torna a demanar el número del DNI.

```text  
Introdueix el número del DNI sense lletra: 1234  
Error: has d'introduir exactament 8 dígits numèrics.

Introdueix el número del DNI sense lletra: 87654321  
```  

Sortida del programa:

```text
La lletra del DNI és: X  
DNI complet: 87654321X  
```

## Vídeo explicatiu  

<iframe width="560" height="315" src="https://www.youtube.com/embed/j29AUkp2ImE?si=S8HdWKf18LAG2Puo" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>