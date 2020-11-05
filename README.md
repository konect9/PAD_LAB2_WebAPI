# PAD_LAB2_WebAPI
Simplest REST WEB API To communicate between client and data warehouse

This is the simplest REST Web Api.

It uses MongoDB as database for the Data Warehouse server.

In order to use this API you would need to install, configure and populate a MongoDB database.
Name of database : SocialDb
Name of collection : Posts

You can populate the database with data from the social_data.json file, which is in the project folder.
All the data on MongoDB database is stored in form of files, each of them having a unique ID and common fields. 
Theese fields can contain data or be null.


The API uses the next HTTP Methods:
      GET - Is used to print information from the datawarehouse to the client
      POST - Is used to create a new piece of data on the datawarehouse
      PUT - Is used to update/change data on the datawarehouse
      DELETE - Is used to delete data from the datawarehouse
      

