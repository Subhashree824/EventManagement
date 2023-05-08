# EventManagement
Web API for Event Management
This is a simple web API project for managing events. The API allows users to create, read, update, and delete events. It is built using C# and ASP.NET Core.

Getting Started
Prerequisites
•	Visual Studio 2019 or later
•	.NET Core SDK 3.1 or later

Installing
•	Clone the repository to your local machine.
•	Open the solution file (EventManagement.sln) in Visual Studio.
•	Build the solution.


Running the API
•	Start the API by pressing F5 in Visual Studio.
•	Use a tool like Postman or Swagger to test the API endpoints.


API Endpoints

Method	Endpoint	Description
GET	/Event	Retrieve all events
GET	/Event/{id}	Retrieve a specific event by id
POST	/Event	Create a new event
PUT	/Event/{id}	Update an existing event by id
DELETE	/Event/{id}	Delete an event by id


Event Model
•	The event model used in this API has the following properties:
•	Id (int): The unique identifier for the event
•	Name (string): The name of the event
•	Tagline (string): A brief description of the event
•	Schedule (DateTime): The date and time of the event
•	Description (string): A detailed description of the event
•	ImagePath (string): The path to the image file associated with the event
•	ModeratorId (string): The ID of the user who is hosting/moderating the event
•	Category (string): The category of the event
•	SubCategory (string): The sub-category of the event
•	RigorRank (int): An integer value that represents the level of difficulty of the event
•	Attendees (List<string>): A list of user IDs of attendees who are attending the event.

Authors

Subhashree Nayak - Initial work - https://github.com/Subhashree824/

License
This project is licensed under the MIT License
