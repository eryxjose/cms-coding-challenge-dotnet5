# CMS Codign Challenge 

## Resume 
This application contains a architecture working skelleton and domain specific features to present an tagged article with a side bar showing articles with the same tags. 

The api can be accessed and tested from swagger auto generated ui and currently provide the following endpoints.

* Articles/GetArticles 
  * This endpoint supports filter and paging parameters.
  * Clients can provide a tag name filter param to obtain all articles containing a specific tag.
* Articles/GetArticle
  * This endpoint receive an article id and returns the article with its tags.

The architecture for the application uses CQRS/Mediator pattern with the following layers:

* api - webapi project
* Application - classlib project for business roles
* Domain - classlib project for domain entities
* Persistence - classlib project for database persistence
* client-app - reactjs project for cliente web application

## Technologies

* Dotnet5
* Ef core/code first
* Swagger
* Sqlite
* MediatR
* Automapper
* 
