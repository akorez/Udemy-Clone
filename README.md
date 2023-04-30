# Microservices Project - Udemy Clone
### In this project, a clone of popular online education platform Udemy.com is created using microservice architecture.
![plot](https://user-images.githubusercontent.com/34706028/129094300-ce025284-e362-49bc-b046-2d828ce3d150.png)
## Features :
- Synchronous and asynchronous communication between microservices using .Net5
- Implementation of OAuth 2.0 and OpenID Connect protocols in Microservices architecture
- Using Eventual Consistency model to ensure consistency in databases of microservices
- Dockerize all microservices using docker-compose
- Asp.Net Core MVC Client for UI
- User Register via IdentityServer4
- Asynchronous order and payment process
- Asynchronous course name update process between catalog, order and basket microservices

## Microservices :
### Catalog Microservice
It is microservice that is responsible for maintaining and presenting information about courses.
- MongoDb (Database)
- One-To-Many/One-To-One relation
### Basket Microservice
It is microservice that is responsible for basket operations.
- RedisDB (Database)
### Discount Microservice
It is microservice that is responsible for discount coupons to be defined to the user.
- PostgreSQL (Database)
### Order Microservice
It is the microservice that is responsible for order processing. This microservice is developed using the Domain Driven Design approach. In addition, the MediatR library is used to implement the CQRS design pattern.
- SqlServer (Database)
- Domain Driven Design
- CQRS (MediatR library)
### FakePayment Microservice
It is Microservice that is responsible for payment processes.
### Identity Microservice
It is the microservice responsible for keeping user data, generating tokens and refresh tokens.
- SqlServer(Database)
- Protect Microservices using Access Token
- OAuth 2.0 / OpenID Connect protocols
### PhotoStock Microservice
It is the microservice that is responsible for keeping and presenting course photos.
### API Gateway
- Ocelot Library
### Message Broker
RabbitMQ is used as message queue system. MassTransit library is also used for microservices to communicate with RabbitMQ.
- RabbitMQ (MassTransit Library)
### Asp.Net Core MVC Microservice
It is the UI microservice that displays the data received from Microservices to the user and is responsible for interacting with the user.
