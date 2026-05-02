# Creació, configuració i ús de GitHub

En aquesta entrada explico com he creat, configurat i fet servir GitHub fins al moment de redactar aquesta activitat. També explico com he utilitzat **GitHub Desktop** i **Obsidian** per crear les entrades en format **Markdown** i pujar-les al repositori.

## Creació del compte de GitHub

Per començar, he accedit al meu compte existent. GitHub és una plataforma que permet allotjar repositoris de codi, gestionar versions dels projectes i publicar documentació o pàgines web mitjançant GitHub Pages.

En aquesta activitat he utilitzat **GitHub** per desar la documentació del treball, el codi font del programa i les entrades escrites en format Markdown.

## Instal·lació i ús de GitHub Desktop

Per treballar d’una manera més senzilla he utilitzat **GitHub Desktop**. Aquesta aplicació permet gestionar repositoris de forma visual, sense necessitat d’utilitzar totes les ordres de **Git** des de la terminal.

Des de **GitHub Desktop** he pogut crear un repositori local, veure els fitxers modificats i publicar els canvis al meu compte de GitHub.

## Creació del repositori

He creat un repositori anomenat **AEA4-RA2-A01**. Aquest repositori conté la documentació de l’activitat, les entrades escrites en format Markdown i el codi font del programa desenvolupat en C#.

L’estructura del repositori inclou diferents fitxers **.md**, que funcionen com a entrades del web o bloc, i una carpeta amb el codi font del programa.

## Ús d’Obsidian per escriure les entrades

Per escriure les entrades he utilitzat Obsidian, ja que permet treballar fàcilment amb fitxers Markdown. He utilitzat directament la carpeta del repositori de GitHub com a bòveda d'Obsidian. D’aquesta manera, els fitxers que edito amb Obsidian són els mateixos que GitHub Desktop detecta com a canvis del repositori.

## Inclusió del codi font

A més de documentar el programa dins d’una entrada, també he afegit el fitxer de codi font al repositori. El fitxer Program.cs es troba dins d’una carpeta específica per al codi font.

D’aquesta manera, el repositori no només conté l’explicació de l’activitat, sinó també el fitxer real del programa desenvolupat en C#.

## Configuració del fitxer .gitignore

Com que he utilitzat Obsidian dins de la carpeta del repositori, ha creat automàticament una carpeta anomenada **.obsidian**, que conté configuracions internes, però no forma part del contingut que vull publicar a GitHub.

Per evitar que aquesta carpeta es pugi al repositori, he modificat el fitxer **.gitignore** i hi he afegit la regla següent:

```gitignore
.obsidian/
```

## Publicació dels canvis al repositori

Un cop creats els fitxers Markdown i afegit el codi font del programa, he utilitzat GitHub Desktop per revisar els canvis detectats dins del repositori.

Finalment, he publicat el repositori al meu compte de GitHub mitjançant l’opció de publicar o sincronitzar els canvis. D’aquesta manera, els fitxers creats en local han quedat disponibles també al repositori remot de GitHub.

## Creació del web amb GitHub Pages

Per convertir el repositori en un petit web, he utilitzat GitHub Pages. Aquesta eina permet publicar el contingut d’un repositori com una pàgina web accessible des del navegador.

Per configurar-ho, he accedit al repositori des de GitHub i he entrat a l’apartat de configuració. Dins de l’opció Pages, he seleccionat la branca principal del repositori com a origen de publicació.

A partir d’aquesta configuració, GitHub Pages genera una adreça web pública on es pot consultar el contingut del repositori. En aquest cas, el web conté una pàgina principal i dues entrades escrites en Markdown: una sobre la creació i ús de GitHub, i una altra sobre el desenvolupament del programa en C#.

D’aquesta manera, el repositori no només serveix per desar el codi i la documentació, sinó que també funciona com un petit web de presentació de l’activitat.

## Enllaços finals

- [Repositori de GitHub:](https://github.com/davidbf1392DAM/AEA4-RA2-A01)
- Web publicada amb GitHub Pages: pendent d’afegir l’enllaç