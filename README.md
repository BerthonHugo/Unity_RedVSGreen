# Red VS Green

![Game (Red VS Green)](./Ressources/Game.png)

# Objectifs

* Découverte de certaines techniques d’IA utilisées dans le jeu vidéo pour la prise de décision des PNJ, en particulier les arbres de comportement (Behavior Trees)
* Elaboration d’arbres de comportement pour des unités combattantes dans un mini-jeu de genre “RTS Wargame”
![Game (Red VS Green)](./Ressources/objectifs.png)

# Modalités
* Présentation magistrale à base de slides
* Projet TP de développement en groupes de 4 étudiants sous Unity3D/C#

# Pré-requis

Une première expérience de développement sous Unity3D/C# est préconisée pour la réalisation du projet.

# Logiciels à Installer
* Unity3D version LTS 2021.3.30f1 (...ou supérieure). Tous les membres d’une même
équipe devront utiliser la même version
* Un IDE de développement C# compatible avec Unity3D: Visual Studio, Visual Studio
Code, Jetbrains Rider
* Un client Git: SourceTree, GitKraken, GitHub Desktop


# Projet
Deux armées (ROUGE et VERTE) s’affrontent sur un terrain de 60m x 60m constitué d’une plaine, de terrasses surplombantes et d’obstacles divers.
Chaque armée occupe un côté de la map. Deux types d’unités sont proposées:
* des drones mobiles capables de se rapprocher d’une cible, de viser puis tirer des missiles à la trajectoire “rectiligne”
* des tourelles d’artillerie (mortiers) statiques et orientables, capables de viser et de tirer des grenades à la trajectoire parabolique (comportement balistique)

Un missile tiré par un drone n’inflige des dégâts qu’à l’unité adverse
avec laquelle il collisionne.
Une grenade tirée par un mortier, lorsqu’elle retombe sur le sol, inflige des dégâts de zone
aux unités adverses se trouvant dans son rayon d’action.


