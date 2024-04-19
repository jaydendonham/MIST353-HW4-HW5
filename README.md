# MIST 353 FINAL PROJECT

## All sections and relevant ReadMes are included in this Readme, including HW4, HW5, and API Documentation

### Deployment Guide

1. Make sure you have Visual Studio Code and SQL Server Installed
2. Run SQL Server. Take note of the server name. Click "Connect."
3. Run Visual Studio Code. Clone this repo.
4. Go into File Explorer. Navigate to this repo. Open the SQL folder
5. In the SQL Folder, open each of these files and execute them in SQL server. Do not open another file without executing. First, open/execute DatabaseCreation, then DatabaseData, then the SPs.
6. In Visual Studio, right click TravelPortal Solution in Solution Explorer. Click Properties
7. Select Multiple Startup Projects. In the dropdown menu next to TravelPortal and TravelPortalAPI, click "Start"
8. Click "Apply"
9. Go under TravelPortal in Solution explorer, click on "appsettings.json"
10. Change the DataSource in the DataConnection line to the name of your SQL server
11. Repeat 9-10 for TravelPortalAPI
12. The app should now function properly when started via VSS

# API Documentation
## Formerly a part of HW4 ReadMe

![image](https://github.com/jaydendonham/MIST353-HW4/assets/142524952/ed693ab7-6896-473b-a302-935855a0af5c)


## Driver

### What It Does

Adds a driver to the portal-wide database of employees, whether they work for a company or are freelance.

### Inputs

- DPosition: Position of Driver (ex. Car Hauler)
- D_First: First Name of Driver (ex. John)
- D_Last: Last Name of Driver (ex. Doe)
- D_Hometown: Homeetown of Driver, where they are based (ex. Fairmont)
- D_LNum: Drivers License Number of Driver (ex. A123456789)


### Outputs

Code is written to return the inputs given.

## POI

### What It Does

Finds points of interest in a given state

### Inputs

{poi_state}: State POIs may be in (undecided if they will be a 2-letter code or full name)

### Outputs

- POI_Name: Name of POI (ex. Washington Monument)
- POI_Add_Num: Address Number of POI (ex. 123)
- POI_Street: POI Street (ex. Conch St.)
- POI_City: City of POI (ex. Morgantown)
- POI_State: State of POI (ex. West Virginia)
- POI_ZIP: ZIP of POI (ex. 12345)

## Location

### What It Does

Gets all location details to show the information stored on a searched area.

### Inputs

- State
- City
- Zipcode

### Outputs

Code is written to return the inputs given. The intention is for the user to be able to enter either a state, a city, or a zipcode and see the other information returned. For example, enter a zipcode and find out what city or state is associated with it.

## Occupation

### What It Does

Gets all occupation details to show the information stored on a job.

### Inputs

- Position
- Wage

### Outputs

Code is written to return the inputs given. Look for a position and find out the wages available for it or vice versa.

## Part

### What It Does
Retrieves part information as well as allows user to add/remove parts from the program. 
### Inputs
- Part number
### Outputs
- Part manufacturer
- Part category
- Part country
- Part price
- Part description
  
## Vehicle

### What It Does
Retrieves vehicle information using user inputs.

### Inputs
- Make
- Model
- Year

### Outputs

Code is written to return the inputs given.

# Application Description
## Formerly a part of HW4 ReadMe

Following our merger into Electric Elephant Electronics, our group is moving forward with dseigning our web app outlined in our previous assignment. Our end goal still remains to design a functional "portal" for driving-based/driving-intensive careers. We developed some initial stored procedures that are being modified or outright changed to be incorporated into APIs for the web app.

## Pages

The web app currently has six pages planned. The pages are as follows:

| Page No. | Purpose | API Present? |  API Used | 
|-----:|-----------|-----------|-----------|
|     1|Home Page|No| N/A |
|     2|Driver List|Yes| Driver | 
|     3|Adding Location/Jobs|Yes| Location & Occupation |
|     4|Manufacturer/Part Library|Yes| Part & Vehicle |
|     5|Register for Account|No| N/A |
|     6|Map|Yes| External Weather API & POI |

All APIs are elaborated upon in the [API Documentation](TravelPortalAPI/README.md)

THIS API DOCUMENTATION IS ALSO PROVIDED LATER IN THIS README FOR GRADING PURPOSES

### Page 1

Page 1 will serve as a home page for our web application. Basic company information as well as a synopsis regarding the purpose of the site will be on this page. This page will also house a navbar, which may be shared across all pages on the site. This NavBar can assist users with navigation to other pages on the Portal.

### Page 2

Page 2 will serve as a hub for viewing drivers, their organizations, relevant information, etc. Potential employers can view drivers they wish to offer/hire and current employers can view their employees. 

This will use the API 'Driver'

### Page 3

Page 3 allows people to view location details for considering job postings that are available in the area.

This will use the APIs 'Location' and 'Occupation'

### Page 4

Page 4 will look somewhat similar to an e-commerce page as it will show different vehicle parts and information regarding that part. Anyone ranging from a freelance driver to a mechanic can use this page to find the parts they need for their vehicle.

This will use the APIs 'Vehicle' and 'Part'

### Page 5

Page 5 will allow users to make an account or login in order to use the websites services. This is similar to most major web applications as they have some sort of account system in place.

### Page 6

Page 6 will act similarly to something like Google Maps or MapQuest and show the relevant climate data for a route shown. This page will incorporate the external climate data API to show drivers about historical climate data along their routes or at certain points of interest.

This will also incorporate 'POI' in addition to the external API.

# Developer Documentation

If a future developement team were to adopt this project, welcome! We hope you can take TravelPortal and help it meet its full potential. Currently the app needs a lot of work. All APIs outlined in API Documentation need to be fully deployed aside from POI, which is deployed but is made to be changed to meet user needs. Registration also needs support. 

# MIST353-HW5
[HW5 ReadMe](TravelPortal/Pages/README.md)
## Pages

### Index (Main)

Jayden Donham
Index acts as the main home page of the web application.

On this page, users can learn about Travel Portal and what it is all about. This page describes in detail the intended capabilities of our web application and also how it works.

### Careers

Jayden Donham
The Careers web page serves to help users find jobs related to driving.

On this page, the Occupation API and the Location API are meant to be used. Occupation is supposed to show available job listings, and Location is meant to show where these listings are available.


### DriverInfo

Josh Keller
Designed to incorporate Driver API. Was unable to as "GET" function proved to be difficult to integrate.

Form is on this page to allow a driver to insert themselves into the database. However, due to the lack of an in-class example of a POST API in javascript in addition to failed attempts to scour the internet and ChatGPT for assistance, API was not able to be implemented as intended. To my knowledge, all other functionality needed (SPs, SQL, etc.) is present.

Eventually a second GET API can be incorporated to show Drivers in the database. Can also be used to show a POST that was just made, giving user confirmation their addition went through. 

### Map

Josh Keller
Incorporates POI API in an easy-to-migrate drop-down format. Makes it easier to migrate to an actual map, including external API.

Intended to eventaully evolve into an interactable map, like Google Maps or MapQuest. **POI API** is an example of something that can be used alongside the map to add unique functionality. POI is currently in a drop-down format, which while not as streamlined as we eventually intend it to be, is still relatively user-friendly. API is fully usable to my knowledge.

In its current form POI API can be easily changed to be used in different ways.

This page would likely become the "main" part of the app.

### Part Library

Ryan Sladic

### Vehicle Info

Ryan Sladic

### Registration

Misc. Page
Josh Keller


