# CMS Codign Challenge 

## Clone and Run

Clone the repo:
    
    git clone https://github.com/eryxjose/cms-coding-challenge-dotnet5.git

Run the app:

* Open api folder on terminal and run 'dotnet run' command.
* Access 'http://localhost:5000/swagger' on the browser.

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

* dotnet5 / C#
* ef core/code first
* swagger
* sqlite
* MediatR
* Automapper
