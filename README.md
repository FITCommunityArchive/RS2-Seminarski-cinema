# Introduction 
Cinema is a bundle of the following applications:
#### Cinema back-end REST API (ASP.NET Core 3.1)
Technical implementations of Cinema.Web.Api:
- SQL Server database
- Repository pattern with Unit of Work
- Service layer
- ML .NET based movie recommender system
- Email service
- Automapper
- JWT Authorization with Bearer scheme
#### Cinema Desktop Client (Windows Forms)
- Movies, screenings, pricing, employees, reservations and content management
- Sales and screenings dashboard overview
- Yearly sales report
- Screening capacities report
- Print to Excel/PDF/Printer feature
#### Cinema Mobile (Xamarin)
- Customer registration and profile edit
- Now showing movies
- Recommended movies
- Screening reservations with seat overview and seat picker
- Sending reservation code to email feature
- "My reservations" overview with reservation cancelation
- News and events overview

# Getting Started
1.	Clone/Download project
2.	Enter EmailConfiguration data in appsettings.json of Cinema.Web.Api (If data is already present, proceed to next step)
3.  Open Visual Studio, right click the solution and go to "Properties". Select "Common Properties", "Startup Project". Select "Multiple startup projects", and set Cinema.Mobile.UWP and Cinema.WinUI values to "Start"
4.  While In solution "Properties", select "Configuration Properties". Check "Build" and "Deploy" checkboxes next to Cinema.Mobile.UWP
5.  Start Docker Desktop
6. 	Open console, then open "cinema" root folder in console
7.  Run "docker-compose build"
8.  Run "docker-compose up"
9. 	After a console message that the application has started appears, open http://localhost:5000/swagger/index.html in browser
**NOTE: docker-compose build may take a few minutes, due to the number of Reviews being seeded (required for the MovieRecommenderService)**

# Login Credentials

#### Cinema Desktop:
**username:** "desktop"
**password:** "test"
(role: administrator)

**username:** "content.editor"
**password:** "test"
(role: content editor)

#### Cinema Mobile:
**username:** "mobile"
**password:** "test"
(role: customer)

**username:** "customer598t"
**password:** "test"
(role: customer) (with enough data to show recommendations instantly)

# Screenshots

![eCinemaDashboard](https://user-images.githubusercontent.com/7669004/93137833-64a61500-f6de-11ea-86fb-3d0895e7d0cf.png)
![eCinemaEventDetails](https://user-images.githubusercontent.com/7669004/93137837-653eab80-f6de-11ea-8861-9fd815bc40d0.png)
![eCinemaMovies](https://user-images.githubusercontent.com/7669004/93137839-65d74200-f6de-11ea-9c61-73b3baaaf362.png)
![eCinemaMoviesDetails](https://user-images.githubusercontent.com/7669004/93137841-65d74200-f6de-11ea-9cb9-c40c034dcced.png)
![eCinemaNews](https://user-images.githubusercontent.com/7669004/93137843-67086f00-f6de-11ea-8b7c-cfcc0fdca2a5.png)
![eCinemaPRicing](https://user-images.githubusercontent.com/7669004/93137844-67086f00-f6de-11ea-9512-2678b3d59931.png)
![eCinemaReports1](https://user-images.githubusercontent.com/7669004/93137845-67a10580-f6de-11ea-853c-bc5c8ad571c4.png)
![eCinemaReports2](https://user-images.githubusercontent.com/7669004/93137846-67a10580-f6de-11ea-93ec-d305ef09bf90.png)
![eCinemaReservations](https://user-images.githubusercontent.com/7669004/93137848-68399c00-f6de-11ea-8c3b-a140efc8efec.png)
![eCinemaScreenings](https://user-images.githubusercontent.com/7669004/93137849-68399c00-f6de-11ea-9a15-daf128c5a23e.png)
![eCinemaUsers](https://user-images.githubusercontent.com/7669004/93137850-68399c00-f6de-11ea-9c41-b47c761c693f.png)
