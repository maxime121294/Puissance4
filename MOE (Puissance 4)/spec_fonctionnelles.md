#Specifications fonctionnelles 

##Début d'une partie

###Choix du noms des joueurs

* Afficher en console: "Nom du joueur 1 ?"
* Le joueur 1 saisit le nom du joueur 1 et tape "entrée"
* Afficher en console: "Nom du joueur 2 ?"
* Le joueur 2 saisit le nom du joueur 2 et tape "entrée"

###Attribution d'une couleur pour chaque joueur

- Afficher en console: "< Nom_du_joueur_1 > -> couleur jaune"
- Afficher en console: "< Nom_du_joueur_2 > -> couleur rouge"

Les couleurs doivent être attribuées aléatoirement.

##Déroulement d'un tour

Le joueur jaune commence la partie.

* Afficher en console l'état actuel de la partie (la grille)
* Afficher en console le nom du joueur qui doit jouer
* Le joueur saisit le numéro de la colonne

Vérifier si le numéro de la colonne saisit par l'utilisateur est valide.

###Si la colonne n'existe pas:

* Afficher en console: "Cette colonne n'existe pas. Veuillez en saisir une autre."
* Le joueur saisit à nouveau un numéro de colonne.

###Si la colonne existe mais est déjà pleine:

* Afficher en console: "Cette colonne est déjà pleine. Veuillez en saisir une autre."
* Le joueur saisit à nouveau un numéro de colonne.

###Si la colonne est valide:

Vérifier si le joueur a fait un puissance4 !

- Si oui, c'est la fin de la partie.
- Sinon, c'est la fin d'un tour.

##Fin de la partie

Si un joueur réussit à faire un puissance4:

- Afficher en console la grille en mettant en avant les 4 jetons alignés.
- Afficher en console: "< Nom_du_joueur > a gagné la partie !!".

Si la grille est entièrement remplie avant qu'un joueur ne réussisse à faire un puissance4, afficher en console: "Match nul :("