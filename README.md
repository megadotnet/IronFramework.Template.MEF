Iron Framework MEF(Managed Extensibility Framework) Template
=============
[![Mono Build Status](https://travis-ci.org/megadotnet/IronFramework.Template.MEF.svg?branch=master)](https://travis-ci.org/megadotnet/IronFramework.Template.MEF)

## Introduction

Domain Driven Design(DDD),Layered architecture,Aspect-oriented programming(AOP) rapid development infrastructure
focus on enterprise solution based on Microsoft .Net Framework. 
Combine with Entity Framework, Enterprise Library, WCF, Asp.net MVC
components implement:

  - Layered Architecture
  - DDD (Domain Driven Design),
  - AOP (Aspect-oriented programming)
  - Service-Oriented Architecture

There architectural styles offer flexible extension and rapid developed infrastructure.
Focus on enterprise solution based on Microsoft .Net Framework. Features:

  - Dependency Injection, Common Service Locator 

  - [Managed Extensibility Framework(MEF)](https://mef.codeplex.com/)
  
  - Entity Framework POCO and T4 template code generation 

  - Repository and Unit of Work Pattern 

## What is MEF?

The Managed Extensibility Framework or MEF is a library for creating lightweight, extensible applications. It allows application developers to discover and use extensions with no configuration required. It also lets extension developers easily encapsulate code and avoid fragile hard dependencies. MEF not only allows extensions to be reused within applications, but across applications as well.

## Hightlight

Here is demo solution that show how to integrate the T4 template of IronFramework with MEF2.
The purpose is not depends on Enterprise Library Unity container block any more. 
Using MEF2 to solve interface object .

Should balance MEF as IOC container with cutting-concern perspective feature.

## Design Goals and Non-Goals

### Goals

Using emerging technique and extremely popular architectural style based on Microsoft .net platform to construct enterprise common rapid developed framework. Demonstrate some reuse library and coding trick and design skill that we have accumulated.

### Non-Goals

It is not cover all about Domain Driven Design (DDD). Domain Driven Design is much more than Architecture and Design Patterns. It implies a specific way of working for development teams and their relationship with Domain experts, a good identification of Domain Model elements (Aggregates/Entity Model, etc.) based on the Ubiquitous Language for every Model we can have, identification of Bounded-Contexts related to models, and a long etcetera related to the application life cycle that we are not covering.

## License
(The MIT License)

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
'Software'), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.