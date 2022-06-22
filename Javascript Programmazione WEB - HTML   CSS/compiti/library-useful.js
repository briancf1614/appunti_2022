//seleziona TUTTI id con nomi uaguali
const elements1 = document.querySelectorAll(`[id^="box"], [id^="container"]`);



let nome='brian'
let cognome='mattia'
let nomeCognome=nome+' '+cognome
let age=30




age='name'
























//cancellare

let images=document.querySelectorAll("img.product-tile")
let body=document.body
let output=""
for (let i = 0; i < images.length; i++) {
    let newelement=document.createElement(Image)
    newelement.src=images[i].src
    
    
    body.innerHTML=output+images[i].src
    
}