# Use modular architecture

* Status: accepted 
* Date: 2020-09-03

## Context and Problem Statement

This projet will be used for private lessons application. At this moment I don't know many bussines logic also I don't have any deadline. This Application is also for learning purposes but finally it will go live.

## Decision Drivers <!-- optional -->

* separated concerns
* easy to maitain
* easy to change bounded context borders
* easy to realase
* project will be raised by 1 developer with mid level of experience

## Considered Options

* microservices
* modular monolith

## Decision Outcome

Chosen option: modular monolith, because it's easier to maintain by single developer. This type of architecture is simple enouch to lern DDD. Also deployment could be done easier compared to microservices. 

## Pros and Cons of the Options

### [microservices]

pros:
* decoupes domain logic
* scalable
* enables independent realases

cons:
* hard to change bounded context borders
* hard to maitain for 1 person
* I don't have experience with this type of archotecture
* poor performance (comparing to simplicity of this project in monolith) due to network communication level (serialize, send via http, deserialize, process and again ...)
* big infrastructure is needed.
* problems with async operations and eventual consistency


### [modular monolith]
pros:
* decouples domain logic
* easy to maintain
* easier to change bounded context borders
* easy to realase
* less error prone for bad architecture decisions 
* no http communication between modules

cons:
* hard to scale
* realases have to be done with whole application