# Introduction

The project TeamSuite is an in-house business support tool to keep track of various business processes within small organizations. From documenting routine processes and tracking issues encountered to maintaining a members / team database.

# Architecture / Patterns

The project adopts a simple repository pattern within an onion architecture. 
Uses MVC together with WebAPI.
Frontend logic is powered by VueJS version 2

# Database Setup

PostgreSQL is used.
Set up your connection string within appsettings.json
Available migrations will be executed automatically when the application is run.

# Running the Project
CD into the solution directory and type <br>
<code>dotnet run</code> from command line. 
You can also execute from within an IDE