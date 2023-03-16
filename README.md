# Portfolio.API
This is a RESTful API for a portfolio website. It provides endpoints to retrieve and manipulate data related to projects, blog posts, and other content.

# Getting Started
To run this project locally, you will need to have the following installed:

.NET 5 SDK
<br>
Visual Studio 2019 (or another compatible IDE)
<br>
Clone this repository to your local machine.
Open the Portfolio.API.sln solution file in Visual Studio.
Build and run the solution.

## Endpoints
The following endpoints are available:

## GET /api/projects
Returns a list of all projects.

## GET /api/projects/{id}
Returns a single project by ID.

## POST /api/projects
Adds a new project to the database.

## PUT /api/projects/{id}
Updates an existing project by ID.

## DELETE /api/projects/{id}
Deletes a project by ID.

## GET /api/blog
Returns a list of all blog posts.

## GET /api/blog/{id}
Returns a single blog post by ID.

## POST /api/blog
Adds a new blog post to the database.

## PUT /api/blog/{id}
Updates an existing blog post by ID.

## DELETE /api/blog/{id}
Deletes a blog post by ID.

## Technologies Used
.NET 5
Entity Framework Core
Microsoft SQL Server

## Contributing
Contributions to this project are welcome! If you find a bug or have a feature request, please open an issue or submit a pull request.

## License
This project is licensed under the MIT License. See the LICENSE.md file for details.
