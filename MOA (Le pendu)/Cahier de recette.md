#Cahier de recette

##Introduction
Le cahier de recette est constitué de :
- la liste des campagnes de test
- les fiches descriptives de chaque scénario
- les fiches descriptives de chaque cas de test.


##Liste des campagnes de test
1. Au depart, et avant aucune erreur, aucun morceau du pendu n'est affiché
- Lorsque la partie est fini, l'ordinateur doit afficher le mot à trouver (que les joueurs gagnent ou perdent)
- En cas d'erreur (mot, lettre fausse ou lettre déjà proposée), un bout du pendu s'affiche à l'écran
- Au bout de 8 erreurs, la partie est terminé. Le pendu complet est affiché.
- Vérification que le mot proposé par le joueur repond aux differents critères (3-10 lettres, compris dans le dictionnaire)
- A chaque tour, on indique differents choix au joueur  : 
  1. Le joueur peut proposer une lettre ou un mot  :
    1. On affiche le nombre de lettre à trouver, 
    - les lettres trouvées 
    - un asterisque est visible sur les lettres restants à trouver
  - Il peut abandonner la partie
  - Il peut demander un affichage des règles du jeu
- Lors d'une proposition correcte, si il s'agit d'une lettre, on affiche toutes les occurences de cette lettre dans le mot à trouver.

##Fiches descriptives des scénarios

##Fiches descriptives des tests
