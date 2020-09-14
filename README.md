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
### Cinema Desktop
#### Dashboard
![eCinemaDashboard](https://user-images.githubusercontent.com/7669004/93137833-64a61500-f6de-11ea-86fb-3d0895e7d0cf.png)

#### Movies and Movie details
![eCinemaMovies](https://user-images.githubusercontent.com/7669004/93137839-65d74200-f6de-11ea-9c61-73b3baaaf362.png)
![eCinemaMoviesDetails](https://user-images.githubusercontent.com/7669004/93137841-65d74200-f6de-11ea-9cb9-c40c034dcced.png)

#### Pricing
![eCinemaPRicing](https://user-images.githubusercontent.com/7669004/93137844-67086f00-f6de-11ea-9512-2678b3d59931.png)

#### Reports
![eCinemaReports1](https://user-images.githubusercontent.com/7669004/93137845-67a10580-f6de-11ea-853c-bc5c8ad571c4.png)
![eCinemaReports2](https://user-images.githubusercontent.com/7669004/93137846-67a10580-f6de-11ea-93ec-d305ef09bf90.png)

#### Reservations
![eCinemaReservations](https://user-images.githubusercontent.com/7669004/93137848-68399c00-f6de-11ea-8c3b-a140efc8efec.png)

#### Screenings
![eCinemaScreenings](https://user-images.githubusercontent.com/7669004/93137849-68399c00-f6de-11ea-9a15-daf128c5a23e.png)

#### Users
![eCinemaUsers](https://user-images.githubusercontent.com/7669004/93137850-68399c00-f6de-11ea-9c41-b47c761c693f.png)

### Cinema Mobile
#
#
##### Now Showing
![eCinemaNow-showing](https://user-images.githubusercontent.com/44144469/93139967-f2373400-f6e1-11ea-9776-9298de32316a.jpg)

#
#
#### Movie Details
![eCinemaMovie-details](https://user-images.githubusercontent.com/44144469/93140011-04b16d80-f6e2-11ea-91f2-8de4e5501f65.jpg)

#
#
#### Seat Reservation
![eCinemaReservation](https://user-images.githubusercontent.com/44144469/93140037-11ce5c80-f6e2-11ea-980b-add22e4363c8.jpg)

#### Reservation Confirmation
#
#
![eCinemaMobileConfirm](https://user-images.githubusercontent.com/44144469/93139825-ba2ff100-f6e1-11ea-93cc-c09e6a1c80cf.jpg)

#
#
#### Thank You Page
![eCinemaThankyou](https://user-images.githubusercontent.com/44144469/93140079-21e63c00-f6e2-11ea-89e3-c7d2f224c942.jpg)

#
#
#### My Reservations
![eCinemaMyreservations](https://user-images.githubusercontent.com/44144469/93140126-34f90c00-f6e2-11ea-8a25-2d0edf1ef028.jpg)
#
#
#### News
![eCinemaNews](https://user-images.githubusercontent.com/44144469/93140137-3de9dd80-f6e2-11ea-9ebb-1d08cae6a4dd.jpg)
