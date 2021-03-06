#Cahier de recette

##Introduction
Le cahier de recette est constitué de :
- la liste des campagnes de test
- les fiches descriptives de chaque cas de test.


##Liste des campagnes de test
1. Au depart, et avant aucune erreur, aucun morceau du pendu et aucune lettre ne sont affichés (seuls des asterisques sont visibles).
- Au bout de 8 erreurs, la partie est terminé. Le pendu complet est affiché.
- Lorsque la partie est fini, l'ordinateur doit afficher le mot à trouver (que les joueurs gagnent ou perdent).
- En cas d'erreur (mot, lettre fausse ou lettre déjà proposée), un bout du pendu s'affiche à l'écran.
- Vérification que le mot proposé par le joueur repond aux differents critères (3-10 lettres, compris dans le dictionnaire)
- A chaque tour, on indique differents choix au joueur  : 
  1. Le joueur peut proposer une lettre ou un mot  :
    1. On affiche le nombre de lettre à trouver, 
    - les lettres trouvées 
    - un asterisque est visible sur les lettres restants à trouver
  - Il peut abandonner la partie
  - Il peut demander un affichage des règles du jeu
- Lors d'une proposition correcte, si il s'agit d'une lettre, on affiche toutes les occurences de cette lettre dans le mot à trouver.

##Fiches descriptives des cas de tests

### Cas N°1 : "Au depart, et avant aucune erreur, aucun morceau du pendu et aucune lettre ne sont affichés (seuls des asterisques sont visibles)"
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Le morceau du pendu ne s'affiche pas tant que le joueur ne rentre pas une erreur| Un bout du pendu s'affiche alors que aucune erreur n'a été commise                 |
|Les lettres du mot à trouver sont affichés avec des asterisques, tant que le joueur n'a pas trouvé une lettre correcte|Les lettres sont visibles par le joueur|

### Cas N°2 : "Au bout de 8 erreurs, la partie est terminé. Le pendu complet est affiché."
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
| Lorsque le joueur a fait 8 fautes, on affiche le pendu complet et on indique que le joueur a perdu| Rien n'est affiché (ni le pendu complet, ni l'indication qu'il a perdu|
| |Le joueur fait moins de 8 fautes, on lui affiche le pendu complet ou/et on lui indique qu'il a perdu la partie|

### Cas N°3 : "Lorsque la partie est fini, l'ordinateur doit afficher le mot à trouver (que les joueurs gagnent ou perdent)"
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Lorsque le joueur perd, une notification est affichée avec le mot à trouver| La notification n'est pas affichée|                 |
|Lorsque le joueur gagne, une notification est affichée avec le mot à trouver| La notification n'est pas affichée|

### Cas N°4 : "En cas d'erreur (mot, lettre fausse ou lettre déjà proposée), un bout du pendu s'affiche à l'écran"
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Lorsque le joueur propose un mot, s'il est incorrect, un bout du pendu s'affiche| Le mot est validé, la partie est finie et/ou un bout du pendu n'est pas incrémenté|
|Lorsque le joueur propose une lettre, si elle est incorrecte, un bout du pendu s'affiche| La lettre est validée, le(s) asterisque(s) est(sont) remplacé(s) par la lettre et/ou un bout du pendu n'est pas incrémenté|
|Lorsque le joueur propose une lettre déjà proposée, un bout du pendu s'affiche | La lettre est validée, le(s) asterisque(s) est(sont) remplacé(s) par la lettre et/ou un bout du pendu n'est pas incrémenté|

### Cas N°5 : "Vérification que le mot proposé par le joueur repond aux differents critères (3-10 lettres, compris dans le dictionnaire)"
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Lorsque le joueur propose un mot, s'il contient moins de 3 ou plus de 10 lettres, la proposition est comptée comme incorrecte| Le mot est validé et la partie est gagnée|
|Lorsque le joueur propose un mot ou l'ensemble de lettres constituant ce mot, il doit être dans le dictionnaire français. S'il n'est pas dans le dictionnaire, la proposition est incorrecte | le mot est validée et la partie est gagnée |

### Cas N°6.i.a : "A chaque tour, on indique differents choix au joueur : pendant que le joueur propose une lettre ou un mot, le nombre de lettres à trouver est affiché "
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Dans chaque tour, le joueur peut connaître le nombre de lettres restant à trouver. Le nombre de lettres à trouver diminue à chaque fois qu'il trouve une bonne lettre dans le mot | Le nombre de lettres à trouver ne s'affiche pas. Le nombre de lettres à trouver est fixe malgré la ou les bonnes réponses reçues précédemment|

### Cas N°6.i.b : "A chaque tour, on indique differents choix au joueur : pendant le jeu, on affiche les lettres trouvées "
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Dans chaque tour, le joueur peut connaître les lettres trouvées. Les lettres trouvées remplacent les astérisques, s'affichent à l'écran et sont sauvegardées pour le prochain tour| Les lettres trouvées ne s'affichent pas et ne sont pas comptabilisées pour le prochain tour|

### Cas N°6.i.c : "A chaque tour, on indique differents choix au joueur : pendant le jeu, un asterisque est visible sur les lettres restantes à trouver "
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Dans chaque tour, le joueur peut connaître les lettres non trouvées : Les lettres non trouvées sont affichées avec des astérisques. Si une lettre est trouvée, l'astérisque est remplacé par la lettre correspondante| Affichage d'un autre caractère que l'astérisque sur une lettre non trouvée (vide, lettre, etc.)|

### Cas N°7 : "A chaque tour, on indique différents choix au joueur : Il peut abandonner la partie"
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Le joueur, par son choix d'abandon, perd la partie | Le joueur gagne la partie |
|Le joueur, par son choix d'abandon, quitte la partie|`On demande au joueur de proposer une lettre|

### Cas N°8 : "A chaque tour, on indique différents choix au joueur : Il peut demander un affichage des règles du jeu"
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|Le joueur, par son choix d'aide, voit s'afficher les règles du jeu |Rien ne s'affiche à l'écran du joueur|
| | Le joueur quitte la partie|

### Cas N°9 : "Lors d'une proposition correcte, si il s'agit d'une lettre, on affiche toutes les occurences de cette lettre dans le mot à trouver"
|Scénario nominale |Scénario d'erreur |
|------------------|------------------|
|La lettre proposé par le joueur, s'affiche là où la lettre correspond dans le mot à trouver|La/Les lettre(s) ne s'affiche(nt) pas dans le mot à trouver|
|Si la lettre a deja été trouvée, un bout du pendu s'affiche|Le pendu n'est pas incrémenté|
