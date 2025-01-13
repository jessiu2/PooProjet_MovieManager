# PooProjet_MovieManager

## Introduction
Le projet MovieManager est un utilitaire en ligne de commande qui permet de manipuler une collection de films. Vous pouvez ajouter, lister, charger, sauvegarder et rechercher des films. Le programme supporte également le changement de langue.

## Commandes disponibles
- **help** : Afficher la liste des commandes disponibles.
- **add** : Ajouter un nouveau film à la collection.
- **list** : Lister tous les films dans la collection.
- **lang** : Changer la langue du programme. Exemple : `lang fr` pour changer la langue en français.
- **load** : Charger des films à partir d'un fichier JSON. Exemple : `load movies.json`.
- **save** : Sauvegarder la collection de films dans un fichier JSON. Exemple : `save movies.json`.
- **search** : Rechercher des films dans la collection. Exemple : `search Taal`.
- **exit** : Quitter le programme.

## Utilisation
1. Lancez le programme en exécutant `dotnet run`.
2. Utilisez les commandes listées ci-dessus pour manipuler la collection de films.

## Exemple
```plaintext
> help
Commandes disponibles : aide, ajouter, lister, lang, charger, enregistrer, rechercher, quitter.

> add
Ajoutez un nouveau film:
Title: Taal
Film 'Taal' ajouté.

> list
- Taal

> lang fr
Langue changée avec succès.

> load movies.json
Films chargés avec succès.

> save movies.json
Films enregistrés avec succès.

> search Taal
Résultats de la recherche :
- Taal

> exit

## Données utilisées
Les données des films sont stockées dans un fichier JSON nommé **movie.json**. Ce fichier contient une liste de films avec leurs détails tels que le titre, la description, les acteurs, le réalisateur, la note IMDB, la catégorie et la date de sortie.
