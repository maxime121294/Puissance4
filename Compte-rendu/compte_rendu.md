#Compte-rendu Génie Logiciel

## Présentation de l'équipe

Dans le cadre de notre projet, nous nous sommes divisés en 3 équipes.

* Equipe développeurs : Medhi BEAUVILLAIN & Samy HAMICHE
* Equipe testeurs : Amandla BEAUTIN & Yong Qin JIN
* Equipe specs : Maxime REBIBO & Corine TANG

La division en équipe n'était pas totalement fixe, il nous arrivait parfois de s'entraider entre différentes équipes.

## Introduction

Durant ce module de Génie Logiciel, nous avons disposé de plusieurs semaines afin de réaliser une application Puissance4 à développer en C# sous l'IDE Visual Studio créé par Microsoft.
Pour ce projet, nous étions à la fois MOA d'une équipe (création du cahier des charges d'un jeu "Le pendu") tout en développant notre application Puissance4 d'après un cahier des charges d'une autres équipe (qui était donc notre MOA).

## Difficultés rencontrées

Durant le projet, nous avons du faire face à certaines difficultés:

* Pour la réalisation des développements en équipe, nous avions parfois du mal à comprendre le code de chacun en raison de la façon dont chacun nommait les lignes et colonnes de la grille (tableau) du puissance4 (x/y, row/col, i/j)
* La fonction de vérification de fin de partie était également difficile à réaliser car nous voulions un minimum de code (fonction unique) capable de vérifier une éventuelle victoire simplement en changeant un vecteur (vérifiant ainsi toutes les directions). Pour cela, un iterator a été mis en place.
* Pour certains membre de l'équipe, l'utilisation de Git et Github n'était pas simple au départ
* Il a également fallu s'habituer au langage C# qui nous était alors inconnu à tous
* Pour certains, l'utilisation de Visual Studio sous Mac OS était un vrai calvaire
* La partie rédaction du cahier des recettes était plus complexe que celle du cahier des charges. En effet, nous n'avions pas en main un "modèle" précis du plan et une recherche plus poussée sur internet était nécessaire contrairement aux modèles du cahier des charges qui étaient largement plus répandus.
* Perte de temps énorme dûe à la lenteur et aux plantages (plusieurs documents non sauvegardés au moment du "bug") des PC à l'iut.

## Tests unitaires

Afin que chacune des fonctions du Puissance4 puisse être testée, nous avons mis en place une série de tests unitaires permettant d'éviter les régressions à chaque mise à jour du projet.
En effet, ce sont ces tests unitaires qui nous permettaient de vérifier si une fonction retournait bien le résultat attendu. Grâce à cela, le projet pouvait être testé en partie dans son intégralité avant chaque "release" sur le Repository Github. <br/>
La classe Power4, qui contenait la methode Run(), ne fut pas vérifier. En effet, comme vu pendant le cours, nous devions utilisé des "Container" qui implementait les Interfaces une seule fois. Cela fut difficile à coder. Seul la classe ContainerTest fut établit.

## Feature Bonus

La feature bonus consistait à indiquer au joueur la possibilité de placer un jeton dans la grille afin d'avoir un alignement de 3 jetons ou plus.
Cette fonctionnalité a été relativement longue à implémenter dans le sens où il a fallu totalement revoir le système d'analyse de la grille de jeu. En effet, pour vérifier s'il y avait une victoire, la fonction checkEnd se basait sur le dernier jeton joué. Or, pour cette fonctionnalité il a fallu prendre en compte la totalité du tableau à 2 dimensions, ce qui rendait la tâche plus complexe que prévu.

## Ecrans de l'application

## Diagramme de classes

![](https://github.com/maxime121294/Puissance4/blob/master/Compte-rendu/Images/DCPuissance4.png)

* Ecran d'accueil
  
![](https://github.com/maxime121294/Puissance4/blob/master/Compte-rendu/Images/ScreenAccueil.png)

* Ecran grille vide
  
![](https://github.com/maxime121294/Puissance4/blob/master/Compte-rendu/Images/ScreenGrilleVide.png)

* Ecran grille remplie
  
![](https://github.com/maxime121294/Puissance4/blob/master/Compte-rendu/Images/ScreenGrilleRemplie.png)

* Ecran des erreurs possibles
  
![](https://github.com/maxime121294/Puissance4/blob/master/Compte-rendu/Images/ScreenErreur.png)

* Ecran de victoire
  
![](https://github.com/maxime121294/Puissance4/blob/master/Compte-rendu/Images/ScreenErreur.png)


## Conclusion

Durant la réalisation de ce projet Puissance4, nous avons beaucoup appris. Tout d'abord, nous avons pu tous nous familiariser avec l'IDE Visual Studio afin de développer en C#, langage également découvert en même temps que Visual Studio pour l'ensemble de notre groupe.
De plus, Git et Github ont été très intéressant à prendre en main, bien qu'un peu difficile au premier abord. Pour certains cela a été vraiment une décourverte car Github est pratique. Il permet de travailler chez soi tout en ayant différentes versions des documents sauvegardés automatiquement.
Dans l'ensemble, il y avait une bonne coordination dans les rôles de chacun des membres du groupe et une bonne entente au sein de l'équipe était présente.
Le fait de devoir coder de manière SRP tout en faisant des tests unitaires était relativement nouveau pour nous (du moins, dans la pratique).
Mais c'est surtout l'aspect MOA/MOE qui changeait radicalement des autres projets de développement informatique que nous avions déjà réalisés au cours de l'année.
Par ailleurs, l'approche du cycle est V est pertinente sur un projet de cette envergure. En effet, les besoins exprimés sont bien délimités et ne nécessitent pas un développement sur une longue durée. Par contre une approche agile est mieux adaptée pour les projets dont les spécifications fonctionnelles sont étendues et les retours utilisateurs primordiaux.
