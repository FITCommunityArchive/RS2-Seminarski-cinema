# Introduction 
Cinema is a bundle of different applications:
1. Cinema back-end REST API (ASP.NET Core 3.1)
2. Cinema Desktop Client: provides movies, screenings, employees, and content management. (Windows Forms)
3. Cinema Mobile: screening reservations and reviews mobile application. (Xamarin)

# Getting Started
1.	Clone/Download project
2.	Enter EmailConfiguration data in appsettings.json of Cinema.Web.Api (If data is already present, proceed to next step)
3.  Set Cinema.WinUI and Cinema.Mobile.UWP as solution Startup projects
4.  Start Docker Desktop
5. 	Open console, open "cinema" root folder in console
6.  Run "docker-compose build"
6.  Run "docker-compose up"
7. 	After a console message that the application has started, open http://localhost:5000/swagger/index.html

