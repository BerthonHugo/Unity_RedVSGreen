Membres :
- LE TOHIC Lysandre
- COULOMB Nicolas
- GUYOT Florian
- BERTHON Hugo

# Réflexions stratégiques et tactiques

## Scripting

## Stratégie 1

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

### Stratégie 5

Dans cette stratégie, on a estimé que le behavior tree de base était



## Deep Learning

- 
- 
- 



# Développé

- La stratégie 1 a été développé et testé, cependant, elle repose essentiellement sur le behavior tree et le taux d'échec est assez élevé.


- La stratégie 2 n'a pas été implémentée à cause de la complexité inutile qu'elle apportait.
La gestion d'un système de salve impliquait de créer un nouveau type d'état pour les tourelles et d'écouter un changement.


# Axes d'amélioration

# Remarques

Nous avons fait façe à des problèmes d'instanciation d'objets dès la 1ʳᵉ frame ce qui faisait planter la solution.

# Répartition

Le groupe s'est cindé en deux parties :
une partie qui script le comportement de l'armée rouge afin de gagner contre les vert de façon certaine.
Le deuxième groupe s'est tenté au deep learning.
Ils ont employé ML agent qui est un réseau de neurone 'profond' basé sur des agents qui apprennent de façon collectives et individuelles.