# Càlcul de la lletra del DNI amb Csharp#

En aquesta part de l’activitat he desenvolupat un programa en **C#** utilitzant **Visual Studio Code**. L’objectiu del programa és calcular la lletra corresponent a un número de DNI introduït per l’usuari.  
  
## Entorn de desenvolupament  
  
Per fer aquesta activitat he utilitzat **Visual Studio Code** com a entorn de desenvolupament i el **SDK de .NET** per poder crear i executar projectes en **C#**. També he treballat amb un projecte de consola de **C#**, que permet executar el programa des de la terminal integrada de **VSCode**.

Per preparar l’entorn he instal·lat l’extensió **C# Dev Kit**, que afegeix suport per treballar amb projectes **C# i .NET** dins de VSCode. Aquesta extensió facilita l’escriptura del codi amb ajuda d’**IntelliSense**, permet detectar errors, navegar pel projecte i executar o depurar aplicacions de consola. També s’han instal·lat les extensions relacionades que **VSCode** necessita per donar suport complet al desenvolupament amb **C#**.
  
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
  
## Prova d’execució 2    

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

