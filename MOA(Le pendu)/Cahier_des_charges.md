![](http://activitesbebes.com/wp-content/uploads/2014/03/pendu.gif "LE JEU DU PENDU")

#LE JEU DU PENDU   

##REGLES DU JEU  

Les règles du jeu du pendu sont les suivantes :  

###LE BUT DU JEU  

Il s'agit de retrouver un mot choisi aléatoirement par l'ordinateur. Le joueur peut faire un nombre fini de propositions.  

###LE DEROULEMENT DU JEU  

On choisit un mot au hasard dans le dictionnaire. C'est ce mot qui sera le mot à trouver par le joueur.  
Le joueur peut proposer soit une lettre, soit un mot complet,  soit un abandon,  soit un affichage des règles du jeu.  
Le joueur a 8 chances de trouver le mot. Lorsqu’une proposition est correcte, le joueur ne perd pas de chance. A partir du dessin suivant :

![Pendu ASCII](http://i.imgur.com/ZviFNrT.png "LE JEU DU PENDU")


On affiche dans un premier temps la potence, puis la corde, le visage, le bras gauche, le bras droit, le torse, la jambe gauche et enfin la jambe droite. Une fois le pendu complet révélé, le joueur a perdu la partie.  
Le joueur fait une proposition. Tant que les conditions de  fin de partie ne sont pas atteintes, le joueur peut faire une nouvelle proposition.  

###UNE PROPOSITION    

Avant chaque proposition, on indique le nombre de lettres du mot à trouver, les lettres déjà découvertes sont affichées à leur place, et les lettres qu'on doit encore découvrir sont symbolisées par des astérisques ‘*’.  
Lorsque la proposition est une lettre ou un mot, on dit qu'elle est erronée lorsque la lettre proposée n'appartient pas au mot, ou bien lorsque la lettre a déjà été proposée,  ou en fin lorsque le mot proposé n'est pas égal au mot à trouver.  
Dans ce cas, un morceau supplémentaire du corps du pendu est dessiné sous la potence. Le corps du pendu est constitué d'une tête d'un tronc de deux bras (droit et gauche) de deux jambes (droite et gauche).  
Avant la première proposition, aucun morceau du corps du pendu n'est sous la potence.  
Lorsque une lettre proposée est correcte, on doit découvrir la (ou toutes les) occurrence(s) de cette lettre dans le mot à trouver.  

###FIN DE PARTIE  

La partie se termine lorsque :  

* Le pendu est complètement dessiné. Le joueur a alors perdu.  
* Le joueur a découvert le mot à trouver. Dans ce cas, le joueur a gagné.  
* Soit en découvrant les lettres une par une soit en proposant le mot complet.   
* Le joueur a décidé d'abandonner, et il a alors perdu.  

##LE TRAVAIL A FAIRE  

###CAHIER DES CHARGES  

Vous devez réaliser un programme qui permet de jouer au pendu. Après chaque partie, l'utilisateur peut éventuellement vouloir rejouer une partie, il faut offrir cette possibilité. 
Enfin lors de chaque proposition, l'utilisateur doit pouvoir consulter les règles.  

###FEATURE SUPPLÉMENTAIRE

A la fin d'une partie, il faut donner la possibilité à l'utilisateur de rejouer. Lorsqu'une nouvelle partie est relancée, il ne faut pas retomber sur les mêmes mots des parties précédentes jusqu'à épuisement du dictionnaire. Si tous les mots du dictionnaire ont été joués, on peut alors rejouer tous les mots du dictionnaire à nouveau.
