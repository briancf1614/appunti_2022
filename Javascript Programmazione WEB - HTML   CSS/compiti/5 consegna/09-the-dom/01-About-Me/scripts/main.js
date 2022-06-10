let body = document.querySelector('body');
body.style.fontFamily = 'Arial, sans-serif';

let Nickname=document.querySelector('li #nickname');
Nickname.innerHTML+='Briancito';
let Favorites=document.querySelector('li #favorites');
Favorites.innerHTML+='games';
let Hometown=document.querySelector('li #hometown');
Hometown.innerHTML+='Turin';

let classes=document.querySelector('li')
classes.className('list-item');