# EzDVF
[![.NET](https://github.com/louisonsarlinmagnus/EzDVF/actions/workflows/dotnet.yml/badge.svg)](https://github.com/louisonsarlinmagnus/EzDVF/actions/workflows/dotnet.yml)
## Introduction
Ce programme a pour but de facilité les requètes dans la base DVF(Demandes de Valeur Foncière).

## Ressources
- Le [GitHub de l'application officielle](https://github.com/etalab/DVF-app)
- L'[api de Christian Quest](http://api.cquest.org/dvf)
- La [documentationd de l'API de Christian Quest](/docs/READ_ME_API_CQ.md)

- [Un lien de test](http://api.cquest.org/dvf?numero_plan=94068000CQ0110)

## Dev

J'utilise Visual Studio Code en environnement de dev C#.

Il faut d'abord installer la librairie pour le JSON: `dotnet add package Newtonsoft.Json --version 12.0.3`

Pour exécuter le code il faut faire `dotnet run` en s'étant placé dans le bon répertoire

Pour contempler le résultat: [ici](https://localhost:5001/)
