# Use modular architecture

* Status: accepted 
* Date: 2020-08-30

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
* monolith
* modular monolith

## Decision Outcome

Chosen option: modular monolith, because [justification. e.g., only option, which meets k.o. criterion decision driver | which resolves force force | … | comes out best (see below)].

### Positive Consequences <!-- optional -->

* [e.g., improvement of quality attribute satisfaction, follow-up decisions required, …]
* …

### Negative Consequences <!-- optional -->

* [e.g., compromising quality attribute, follow-up decisions required, …]
* …

## Pros and Cons of the Options <!-- optional -->

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


### [monolith]

* Good, because [argument a]
* Good, because [argument b]
* Bad, because [argument c]
* … <!-- numbers of pros and cons can vary -->

### [option 3]

[example | description | pointer to more information | …] <!-- optional -->

* Good, because [argument a]
* Good, because [argument b]
* Bad, because [argument c]
* … <!-- numbers of pros and cons can vary -->

## Links <!-- optional -->

* [Link type] [Link to ADR] <!-- example: Refined by [ADR-0005](0005-example.md) -->
* … <!-- numbers of links can vary -->