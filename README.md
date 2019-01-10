# Web_Api_Demo
A small project demonstrating web Api

#### -[Search Query](#Search_Query)

#### -[Ajax](#Ajax)

#### -[Contacts Controller](#ContactController)

#### -[Contacts Controller EF](#ContactControllerEF)

#### -[Atrribute Routing](#AttributeRouting)



# **Search Query**

Started out by creating a text box to search for contacts in a database

![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/SearchBar.jpg)

The Initial search would return what was already inside of the database.

![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/InitialDatabaseSearch.jpeg)

The add, put, and delete buttons was hard coded with a contact variable that held some data about a new contact.
![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/ActionResults.jpg)

[Back To Top](#Web_Api_Demo)

# **Ajax**

Inside of my index page I used jQuery in order to call the Get, Put, Post, and Delete methods

![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/IndexPagejQuery.jpeg)

[Back To Top](#Web_Api_Demo)

# **ContactController**

Inside the controller method I originally created an array of contacts for the user to search through. Underneath that is where I created my methods and actions of what I wanted to happen when each of them was called through jQuery functions on the index page.

![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/ContactController.jpg)

[Back To Top](#Web_Api_Demo)

# **ContactControllerEF**

Later on I had decided that I didn't like that the data wasn't persistent so I added in entity framework so I could bring in a database for my methods to update. I created a controller labeled ContactControllerEF.
![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/ContactControllerEF.jpg)

[Back To Top](#Web_Api_Demo)

# **AttributeRouting**
I both of these controllers I had deleted the default method of routing and created attribute routing for simplicity. This saved a lot of time writing full routes above each method

![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/ContactController.jpg)

![alt text](https://github.com/Tmc802/Web_Api_Demo/blob/master/ApiDemo/ApiDemo/ApiDemoPhotos/ContactControllerEF.jpg)

[Back To Top](#Web_Api_Demo)
