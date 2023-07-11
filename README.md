# Movie Groovy Database

With the Movie Database, you can access a wealth of information about movies, ranging from classic masterpieces to the latest blockbusters. Our platform is meticulously curated to offer a diverse selection of genres, directors, actors, and more, ensuring that there is something for everyone's cinematic taste.


## Project Goals and Objectives

1. Centralized Movie Information: Develop a centralized repository of movie information that brings together data from various sources, providing users with a one-stop platform to access comprehensive details about movies, including title, release year, genre, director, cast, plot summary, ratings, and reviews.
2. Improved Access and Searchability: Enable movie enthusiasts to easily search and discover movies based on their preferences, allowing them to explore by genre, director, actor, or other relevant criteria. Implement robust search functionalities that provide accurate and efficient results, ensuring users can quickly find the movies they are interested in.
3. Enhanced User Engagement: Foster a highly engaging and interactive user experience within the movie database. Implement features that enable users to rate and review movies, allowing them to share their opinions and insights with the community. Encourage discussions and social interactions around movies to create a vibrant and active user community.
4. Personalized Recommendations: Utilize algorithms and user profiling techniques to offer personalized movie recommendations tailored to individual users' interests and viewing history. By analyzing user preferences, ratings, and watch history, the system will suggest relevant and appealing movie options, enhancing the discovery process and providing a curated movie selection.
5. Streamlined Movie :Collection Management Provide users with tools to easily manage their movie collections, enabling them to track the movies they have watched, create watchlists, and organize their favorite movies. Offer features such as marking movies as watched, saving favorites, and creating personalized lists, ensuring users have an efficient and intuitive way to manage their movie preferences.
6. Seamless User Interface and Accessibility: Design a user-friendly and visually appealing interface that offers a seamless navigation experience. Ensure the platform is accessible across various devices, including desktops, tablets, and mobile devices, enabling users to access the movie database anytime, anywhere.

## Database connectivity with front-end

### Backend Setup (SSMS):
Set up and configure our SQL Server database using SSMS.
Create the necessary tables, such as Movies, Genres, Directors, Actors, etc., in the database.
Define the appropriate relationships between the tables using primary and foreign keys.

### Frontend Setup (Visual Studio):
Create a new project in Visual Studio, such as a Windows Forms Application or ASP.NET Web Application.
Add the necessary controls and components to the frontend application's interface for interacting with the movie database, such as buttons, textboxes, dropdowns, and grids.
Configure the project to include the required references for database connectivity.

### Database Connectivity:
In Visual Studio, add a connection string to establish a connection to the SSMS database. The connection string will include the server name, database name, and authentication details.
Use of the appropriate ADO.NET library, such as SqlConnection and SqlCommand, to connect to the SSMS database from our Visual Studio project.
Use the SQLConnection class to establish a connection to the database by providing the connection string.
Use the SqlCommand class to execute SQL queries or stored procedures against the database.

### Frontend Integration:
We will write the necessary code in the Visual Studio project to interact with the SSMS database using ADO.NET.
Use SQL queries or stored procedures to fetch, insert, update, or delete data from the database.
Bind the retrieved data to the frontend controls (e.g., grids, textboxes) to display the movie information.
Implement event handlers for user interactions, such as button clicks, to trigger the corresponding database operations.
Ensure proper error handling and validation of user inputs to maintain data integrity.

## Use Case Diagram
![image](https://github.com/lapm93/Movie-Groovy/assets/100726201/78f9f440-74ab-42e7-bbb5-1c85b1826da0)


## Authors

- [@LuisPena](https://github.com/lapm93)
- [@LibbyBlair](https://github.com/LibbyB3)
- [@GarrisonBell](https://github.com/iqxoh)
