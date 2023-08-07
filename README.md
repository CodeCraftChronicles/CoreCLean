# CoreCLean
# CoreClean MultiProject Boilerplate

CoreClean MultiProject Boilerplate est un modèle de démarrage pour les projets .NET Core qui adoptent l'architecture propre (Clean Architecture) et englobent plusieurs sous-projets pour construire une solution complète. Il fournit une base solide et bien organisée pour développer des applications en suivant les principes de séparation des préoccupations, de maintenabilité et d'extensibilité.

## Sous-Projets inclus

Ce modèle contient les sous-projets suivants, chacun étant conçu pour remplir un rôle spécifique dans une solution d'application complète :

1. **CoreClean.Gateway** : Un projet pour gérer les API et les points d'entrée externes. Il utilise des technologies modernes pour créer une passerelle robuste entre les clients et les services internes.

2. **CoreClean.MauiClient** : Un projet qui implémente une interface utilisateur cross-platform avec .NET MAUI (Multi-platform App UI). Il offre une expérience utilisateur cohérente sur plusieurs plateformes.

3. **CoreClean.SSO** : Un projet dédié à l'implémentation d'un système Single Sign-On (SSO). Il permet une authentification centralisée et sécurisée pour l'ensemble de votre solution.

## Caractéristiques

- Architecture propre (Clean Architecture) préconfigurée pour chaque sous-projet.
- Séparation claire des couches (Présentation, Application, Domaine, Infrastructure).
- Configuration flexible et extensible pour chaque sous-projet.
- Gestionnaire de dépendances intégré pour une meilleure modularité.
- Exemples de mise en œuvre pour chaque sous-projet afin de guider le développement.
- Tests unitaires préparés pour les principales fonctionnalités de chaque sous-projet.

## Prérequis

Avant de commencer, assurez-vous d'avoir les éléments suivants installés :

- .NET Core SDK [lien vers la page de téléchargement]
- Git [lien vers la page de téléchargement]

## Comment utiliser

1. Clonez ce référentiel sur votre machine locale :

```bash
git clone https://github.com/votre-utilisateur/CoreClean-MultiProject.git
```

2. Accédez au répertoire du projet :

```bash
cd CoreClean-MultiProject
```

3. Sélectionnez le sous-projet que vous souhaitez exécuter en accédant au répertoire correspondant :

```bash
cd CoreClean.Gateway
```

4. Lancez l'application en exécutant la commande suivante :

```bash
dotnet run
```

5. Accédez à l'URL ou à l'application correspondante pour chaque sous-projet :

   - Gateway : http://localhost:5000
   - MauiClient : Lancez l'application .NET MAUI
   - SSO : Accédez à l'URL spécifique pour le système Single Sign-On

## Structure du projet

Le projet est structuré de la manière suivante :

- `src/` : Contient les sous-projets de l'application.
  - `CoreClean.Gateway/` : Projet de gestion des API et des points d'entrée externes.
  - `CoreClean.MauiClient/` : Projet d'interface utilisateur cross-platform avec .NET MAUI.
  - `CoreClean.SSO/` : Projet pour le système Single Sign-On.
- `test/` : Contient les tests unitaires pour chaque sous-projet.
- `README.md` : Ce fichier README.

## Contribution

Les contributions sont les bienvenues ! Si vous avez des idées d'amélioration, des correctifs de bogues ou de nouvelles fonctionnalités, n'hésitez pas à ouvrir une demande de pull.

## Licence

Ce projet est sous licence [MIT](https://opensource.org/licenses/MIT).

---

Créé par [WOAGOU Pouguinipo Daniel}(https://github.com/daniwxcode)
```
