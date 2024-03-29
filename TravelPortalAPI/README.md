# API Documentation

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

Code is written to return the inputs given.

## Occupation

### What It Does

Gets all occupation details to show the information stored on a job.

### Inputs

- Position
- Wage

### Outputs

Code is written to return the inputs given.

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
