let cars=[ { "id":0, "Name":"chevrolet chevelle malibu", "Miles_per_Gallon":18, "Cylinders":8, "Displacement":307, "Horsepower":130, "Weight_in_lbs":3504, "Acceleration":12, "origin":["1970-01-01","USA"], "used":true, "demolition":null }, { "id":1, "Name":"buick skylark 320", "Miles_per_Gallon":15, "Cylinders":8, "Displacement":350, "Horsepower":165, "Weight_in_lbs":3693, "Acceleration":11.5, "origin":["1970-01-01","USA"], "used":true, "demolition":null }, { "id":2, "Name":"plymouth satellite", "Miles_per_Gallon":18, "Cylinders":8, "Displacement":318, "Horsepower":150, "Weight_in_lbs":3436, "Acceleration":11, "origin":["1970-01-01","USA"], "used":true, "demolition":null }, { "id":3, "Name":"amc rebel sst", "Miles_per_Gallon":16, "Cylinders":8, "Displacement":304, "Horsepower":150, "Weight_in_lbs":3433, "Acceleration":12, "origin":["1970-01-01","USA"], "used":true, "demolition":null }, { "id":4, "Name":"ford torino", "Miles_per_Gallon":17, "Cylinders":8, "Displacement":302, "Horsepower":140, "Weight_in_lbs":3449, "Acceleration":10.5, "origin":["1970-01-01","USA"], "used":true, "demolition":null } ]

let carsJson=JSON.stringify(cars);
console.log(carsJson);
console.log(typeof carsJson);
let carsObject=JSON.parse(carsJson);
console.log(carsObject[0].Name);

let body=document.body
const div=document.createElement("div");
div.className="container";
div.appendChild(newLi);
const newLi=document.createElement("ul");
newLi.className="MyCars";
newLi.textContent="questaa è una lista delle mie macchine";
const myCar=document.createElement(li);
mycar.appendChild(newLi);
const currentLi=document.getElementById("myCar");

const container=document.getElementsByClassName("container");
container.appendChild(newLi);

/*let body=document.body;
let newElement=document.createElement("p");
let text=document.createTextNode("questa è una lista delle mie macchine");
newElement.appendChild(text);
body.appendChild(newElement);
*/
let p=$('<p class="cars">questa è una lista delle mie macchine</p>');
p.css("color","red");

$('body').append(p);
console.log(p);