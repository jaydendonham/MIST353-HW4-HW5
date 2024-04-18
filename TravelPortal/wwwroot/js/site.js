// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function displayCareersDetails(OccupationID) {
    const response = await fetch(`https://localhost:7173/api/Careers/${OccupationID}`); //web port 7185
    const data = await response.json();
    document.getElementById('CareersName').innerHTML = data[0].name;
    document.getElementById('CareersName').style.visibility = "visible";
}

async function displayPOIDetails(POI_State) {
    const response = await fetch(`https://localhost:7173/api/POI/${POI_State}`);
    const data = await response.json();
    document.getElementById('POI_Name').innerHTML = data[0].poI_Name;
    document.getElementById('POI_Name').style.visibility = "visible";
    document.getElementById('POI_Add_Num').innerHTML = data[0].poI_Add_Num;
    document.getElementById('POI_Add_Num').style.visibility = "visible";
    document.getElementById('POI_Street').innerHTML = data[0].poI_Street;
    document.getElementById('POI_Street').style.visibility = "visible";
    document.getElementById('POI_City').innerHTML = data[0].poI_City;
    document.getElementById('POI_City').style.visibility = "visible";
    document.getElementById('POI_State').innerHTML = data[0].poI_State;
    document.getElementById('POI_State').style.visibility = "visible";
    document.getElementById('POI_ZIP').innerHTML = data[0].poI_ZIP;
    document.getElementById('POI_ZIP').style.visibility = "visible";
}

