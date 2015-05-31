# TL; DR

15 / 20

Bon travail dans l'ensemble. Le style rédactionnel est à améliorer mais l'essentiel y est. Un travail de cohérence à améliorer aussi mais les contraintes (git & markdown) sont respectées sans trop d'erreurs.

# MOA Pendu

## Cahier des charges (CdC)

* Eviter le "on" dans la phrase "on choisit un mot". Qui est "on" ? L'ordinateur ? Un joueur ? L'ingénieur ?
* Le déroulement du jeu est un peu décousu. Il y a un mélange entre le déroulement et les règles globales (8 chances, affichage des règles à tout moment, etc.)
* Attention à la présence de doubles espaces.
* Quelques redondances d'informations (affichage des règles à tout moment, le fait de pouvoir rejouer une partie). Je pense qu'il manque un travail de relecture finale.
* Le style des phrases est un peu poussif. e.g.

> `lorsque une proposion, il y a erreur lorsque proposition est xxx` devrait être `lorsque proposition est xxx, il y a une erreur`  
> `Si `**tous les mots du dictionnaire**` ont été joués, on peut alors rejouer `**tous les mots du dictionnaire**` à nouveau.`

* Cahier des charges qui énonce clairement les règles du jeu sans rentrer dans des détails d'implémentation technique. Bon travail.

## Cahier de recettes (CdR)

* Incohérence avec le CdC pour `Lorsque la partie est finie, l'ordinateur doit afficher le mot à trouver` : ce n'est précisé nulle part dans le cahier des charges.
* Incohérence avec le CdC pour `Vérification que le mot proposé par le joueur repond aux differents critères` : ces critères ne sont pas précisés dans le cahier des charges.
* La bonne orthographe est "scénario nominal" (sans le `e`).
* Le CdR est plutôt complet mais n'est pas écrit sous la forme d'un scénario mais plus sous l'angle d'une *check-list*.

## Soutenance

* Vous avez déroulé vos scénarios comme convenu et validé, à raison, la livraison.
* Le contenu du dictionnaire était quelque peu léger et il aurait fallu essayer d'en ajouter à la main afin de s'assurer que c'était une opération à votre portée d'une part (pas de code en dur) et qu'elle était prise en compte.

# MOE Puissance 4

## Spécifications fonctionnelles

* Spécifications vraiment sommaire : on a du mal à savoir qu'il s'agit d'un puissance 4 sauf vers la fin du document.
* La spécification fonctionnelle ressemble beaucoup à du pseudo-code.
* La présentation de la spécification sous forme de *workflow* est intéressante mais du coup un simple diagramme d'état aurait fait l'affaire (le genre de ceux qu'on trouve sur 9gag !)

## Spécifications techniques

* Absente, mais présence d'un schéma de classe dans le compte-rendu. Celui-ci manque un peur d'air et est un peu confus : il aurait fallu regrouper les classes par concept.

# Rapport

* Le style manque de formalisme et d'explication. Pourquoi VisualStudio était un calvaire (à cause des vm) ? Pourquoi l'utilisation de git & GitHub n'était pas simple ?
* Vous avez été confrontés à un problème de communication dans la nomenclature de vos variables (x/y, row/col, etc.), à quel moment et par quels moyens l'avez-vous résolu ?
* `être testé en partie dans son intégralité` cette phrase est mythique !
* Attention à l'orthographe sur ce document en particulier, le reste est plus ou moins exempts mais celui-ci s'avère pénible à lire. Relisez-vous !
* Vous avez mal identifié la complexité de la *feature* bonus. A chaque tour, la grille ne change qu'aux deux endroits où sont ajoutés les pions. Il fallait donc vérifier que ces nouvelles positions ne généraient pas de potentielles chaînes de 3 plutôt que de scanner l'intégralité de la grille.
* Compte-rendu un peu expéditif, il manque de structure, d'explications. On sent qu'il a été rédigé un peu rapidement en cherchant à mettre les informations demandées. C'est dommage, je termine par ce document et du coup je reste un peu sur ma faim.
* Prenez le temps de bien rédiger les documentations et n'hésitez pas à les faire relire par des informaticiens et surtout des non-informaticiens. A un niveau fonctionnel, c'est comme une interface : si vous devez l'expliquer, c'est que ce n'est pas bon.