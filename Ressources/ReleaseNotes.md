Membres :
- LE TOHIC Lysandre
- COULOMB Nicolas
- GUYOT Florian
- BERTHON Hugo

# Réflexions stratégiques et tactiques

## Scripting

### Stratégie 1

- L'objectif initial était d'utiliser uniquement le behavior tree pour battre les ennemis.
  une stratégie envisagée est de créer dans le behavior tree un 'repeat' task qui se répete à l'infini tant que l'ennemi n'est pas mort et qui s'arrete dès qu'il recoit un échec (quand l'enemi n'existe plus). Cette stratégie  est limités et il y a un probleme avec la détection de la mort de l'enemi puisque l'on tire sur une position et non sur un GameObject spécifique. Il faut donc un moyen de détecter si l'ennemi est toujours à la même place et en vie.

- Toujours à l'aide du behavior tree, on a changé et ajouté un certain nombre de task afin de mieux détecter la mort des ennemis

### Stratégie 2
 - une partie de la strégie 2 repose sur la sélection d'un ennemi commun pour toute l'armée et de lui tirer dessus. Apres la mort de l'ennemi, on peut changer de cible jusqu'a que tputes les armées ennemies soient mortes.



- Prioriser les tourelles ennemies à l'aide des tourelles et des drones.
Pour ce faire, nous lançons une salve des tourelles rouges contre une tourelle verte avant de changer de cible puis nous utilisons les drones pour achever les cibles endommagées.

### Stratégie 3

stratégie basé sur la mobilité des drones et sur leur capacité à tirer loing.

- éviter les ennemi en restant loing d'eux et raycast pour détecter si il ya des obstacles en l'ennemi et le drone alié. Cette stratégie est seulement efficace pour les drone car les tourelle ne peuvent pas se déplacer.

### Stratégie 4

Créer des escouades de drones et tourelles

### Stratégie 5

Dans cette stratégie, on a estimé que le behavior tree de base était suffisant. en effet. l'arbre permet de choisir une cible, se dirigier vers la cible en utilisant le navmesh de unity, de se positionner correctement avant de tirer.

ces comportement permettent d'englober la totalité des actions possibles par les unités.

on a commencé par supprimer le random selector puisqu'on ne veut pas que l'ennemi soit choisi au hazard.

Tout doit être déterministique.

Nous avons modifié les actions de bases (selectionner, se deplacer, se positionner, tirer), en particulier la façon de selectionner les ennemis.

Chaque ennemi possede un tag avec une valeur qui représent pour chaque type d'ennemi le chemin optimal. ce chemin optimal n'est utilisé que pour les tourelles qui ne sont pas toujours accessibles et est determiné à partir de l'accessibilité par les drones aux tourelles ennemis.

ce chemin optimal est determiné à la main et n'est donc pas valid sur un autre type de map.

les tourelles alié se charge d'éliminer les tourelles ennemis les moins accessibles tendis que les drones ignorent les drones ennemis et tire sur les tourettes ennemies les plus accessibles.

une fois toutes les tourettes eliminé, toutes les troupes aliées ont une seul consigne, tirer sur les enemis les plus provhes d'eux. 
Etant donné que les drones sont deja rassemblés ensemble, ils vont tous focus le meme ennemi et les ennemis n'ont pas le temps de tirer avant de ce faire eliminer.

on a éliminer les tourettes en premier parcequ'il peuvent infliger beaucoup de degat de zone et que les drones sont tous rassemblés ensembles.



## Deep Learning

- 
- 
- 



# Développé

- La stratégie 1 a été développé et testé, cependant, elle repose essentiellement sur le behavior tree et le taux d'échec est assez élevé.


- La stratégie 2 n'a pas été implémentée à cause de la complexité inutile qu'elle apportait.
La gestion d'un système de salve impliquait de créer un nouveau type d'état pour les tourelles et d'écouter un changement.

- la stratégie final repose sur un systeme de group (inspiré de la stratégie 4) et de la stratégie 5.
Elle modifie 


# Axes d'améliorations

## Scripting
- Comme évoqué dans la stratégie 5, le chemin optimal pour éliminer les tourelles est déterminé manuellement. il serait envisageable d'implementer un algorithme pour calculer ce chemin tout seul.

- Il y a un temps de réaction entre le moment ou l'enemi est mort et le moment ou l'armée arrete de tirer.
Ce temps de réaction est provoqué par le temps qu'un missile ou autres projectiles met pour arriver sur l'ennemi.
Cela provoque du gachit de munition sur des ennemis deja mort.
Pour éviter cela, on pourrait calculer le nombre de tire nécéssaire pour tuer un ennemi basé sur ce que le manager sait de la vie de l'ennemi (il sait tous)

## Deep Learning
- 
- 

# Remarques

Nous avons fait façe à des problèmes d'instanciation d'objets dès la 1ʳᵉ frame ce qui faisait planter la solution.

# Répartition

Le groupe s'est scindé en deux parties :
une partie qui script le comportement de l'armée rouge afin de gagner contre les vert de façon certaine.
Le deuxième groupe s'est tenté au deep learning.
Ils ont employé ML agent qui est un réseau de neurone 'profond' basé sur des agents qui apprennent de façon collectives et individuelles.