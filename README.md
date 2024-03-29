# MIST353-HW4
## Designing a Web App

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


