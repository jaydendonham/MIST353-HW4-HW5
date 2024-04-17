// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function displayCareersDetails(CareersID) {
    const response = await fetch(`https://localhost:7173/api/Careers/${CareersID}`); //web port 7185
    const data = await response.json();
    document.getElementById('CareersName').innerHTML = data[0].name;
    document.getElementById('CareersName').style.visibility = "visible";
}

async function displayPOIDetails(POI_ID) {
    const response = await fetch(`https://localhost:7173/api/POI`)
    const data = await response.json();
    document.getElementById('POI_Name').innerHTML = data[0].name;
    document.getElementById('POI_Name').style.visibility = "visible";
    document.getElementById('POI_Add_Num').innerHTML = data[0].add_num;
    document.getElementById('POI_Add_Num').style.visibility = "visible";
    document.getElementById('POI_Street').innerHTML = data[0].street;
    document.getElementById('POI_Street').style.visibility = "visible";
    document.getElementById('POI_City').innerHTML = data[0].city;
    document.getElementById('POI_City').style.visibility = "visible";
    document.getElementById('POI_State').innerHTML = data[0].state;
    document.getElementById('POI_State').style.visibility = "visible";
    document.getElementById('POI_ZIP').innerHTML = data[0].zip;
    document.getElementById('POI_ZIP').style.visibility = "visible";
}