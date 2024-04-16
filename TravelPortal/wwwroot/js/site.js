// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function displayCareersDetails(CareersID) {
    const response = await fetch(`https://localhost:7173/api/Careers/${CareersID}`); //web port 7185
    const data = await response.json();
    document.getElementById('CareersName').innerHTML = data[0].name;
    document.getElementById('CareersName').style.visibility = "visible";
}