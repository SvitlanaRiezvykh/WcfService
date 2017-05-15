# WcfService
Création d’un service RESTful aven utilisant WCF 

Windows Communication Foundation (WCF) est un SDK pour le développement et le déploiement de services sur Windows. WCF fournit un environnement d'exécution pour vos services, vous permettant d'exposer les types CLR en tant que services et de consommer d'autres services en tant que types CLR. 

## Prérequis
*	Microsoft Visual Studio 2013 ou supérieur 
* Postman pour tester notre API: https://www.getpostman.com/apps

## Création du projet WCF

1. Démarrer Visual Studio.
2. Fichier > Nouveau > Projet
3. Visual C# et sélectionnez WCF, puis **Application de service WCF**

## Configuration du fichier web.config

Ajouter le code ci-dessous dans la section <system.serviceModel>
```xml
      <services>
      <service name="WcfService.BookService"  behaviorConfiguration="ServiceBehavior">

        <endpoint binding="webHttpBinding" contract="WcfService.IBookService" behaviorConfiguration="web">
        </endpoint>
        
      </service>
    </services>
```

WebHttpBinding est la liaison spécifiquement proposée pour les services RESTful dans Windows Communication Foundation version 3.5.

EndpointBehavior est "webHttp" pour le service RESTful.


## Test avec postman

Demarrer l'application. 	

| Action        | HTTP method   |URI|
| ------------- |:-------------:| -----|
| Ajouter un livre    | POST |api/book/AddBook/{book} |
| Liste des livres     | GET      |api/book/GetAllBooks/ |
| Selectionner un livre | GET     |api/book/GetBook/{id} |
| Supprimer un livre |DELETE      |api/book/DeleteBook/{idBook} |
| Modifier un livre | PUT     |api/book/UpdateBook/{book}|
