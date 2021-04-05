Jeu-Le-mur-

Pour vous déplacer, vous réaliserez un contrôleur classique à la première personne. Vous devez
utiliser les touches du clavier « WASD » et vous devez pouvoir effectuer une rotation en bougeant la
souris de gauche à droite et orienter l’élévation de la caméra de haut en
bas.

Lorsqu’on appuie sur la barre d’espacement, un projectile est tiré.

Chaque « brique » du mur doit avoir son propre comportement physique.
Afin de garder votre scène propre, le mur doit être généré à partir d’un script d’initialisation. Ce
script devrait donc instancier chaque brique du mur et les positionner à l’endroit désiré. Le script doit
créer un nombre de briques selon deux paramètres (largeur et hauteur) qui sont exposés pour un
designer qui voudrait changer la taille du mur dans l’environnement Unity. L’environnement statique
et votre personnage principal peuvent être par défaut dans la scène.

Lorsqu’on appuie sur la touche R, le mur doit être réinitialisé et reconstruit à sa position d’origine.
Afin que votre mur soit « beau », ajoutez une texture de brique ou de roche à vos blocs. De plus, vos
projectiles devraient être tirés du bout d’un canon qui sera toujours visible dans le bas de l’écran
(élément de HUD).

Gérez vos projectiles afin de ne pas causer de fuites de mémoire. Les projectiles qui ne sont plus
visibles, qui sont tombés à l'extérieur de la zone de jeu, les projectiles trop nombreux, ne devraient
pas causer de problèmes à long terme, assurez-vous de faire ce qu’il faut.

Finalement, votre code doit respecter l’architecture (le découplage des classes) du patron de
programmation MVC.
