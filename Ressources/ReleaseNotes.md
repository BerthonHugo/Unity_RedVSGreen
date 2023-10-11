membres:
- LE TOHIC Lysandre
- COULOMB Nicolas
- GUYOT Florian
- BERTHON Hugo

# Réflexions stratégiques et tactiques

## Scripting

### Stratégie 1
- 
- Prioriser les tourelles ennemi a l'aide des tourelles et des drones.
Pour ce faire, nous lançons une salve des tourelles rouge contre une tourelle verte avant de changer de cible puis nous utilisons les drones pour achever les cibles endommagées.

- L'objectif initial était d'utiliser uniquement le behavior tree pour battre les ennemis.
une stratégie envisagée est de créer dans le behavior tree un 'repeat' task qui se répete à l'infini tant que l'ennemi n'est pas mort et qui s'arrete dès qu'il recoit un échec (quand l'enemi n'existe plus). Cette stratégie  est limités et il y a un probleme avec la détection de la mort de l'enemi puisque l'on tire sur une position et non sur un GameObject spécifique. Il faut donc un moyen de détecter si l'ennemi est toujours à la même place et en vie.

- toujours à l'aide du behavior tree, on a changé et ajputé un certain nombre de task afin de mieux détecter la mort des ennemis


## Deep Learning



# Développé

# Axes d'amélioration

# Remarques

# Répartition

Le groupe s'est cindé en deux partie:
une partie qui script le comportement de l'armée rouge afin de gagner contre les vert de façon certaine.
Le deuxieme groupe s'est tenté au deep learning.
Il ont employés ML agent qui est un réseau de neurone 'profond' basé sur des agents qui apprennent de façon collectives et individuelles.